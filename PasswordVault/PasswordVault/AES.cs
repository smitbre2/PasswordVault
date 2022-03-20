using System;
using System.Xml;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.IO;

// Thank you microsoft for making this a little less painless than if I did it all myself
class AES
{
    // Admin
    private string secret;
    string path = Directory.GetCurrentDirectory();
   

    // Authenticates the provided password. Returns true if it is the correct key, false otherwise
    public bool AuthLogin(string pass)
    {
        Aes aes = null;

        // Create a new AES key.
        aes = Aes.Create();

        // Needs more salt, will add some salt later


        // We want to salt and hash with regards to the admin password
        UnicodeEncoding UE = new UnicodeEncoding();
        byte[] passwordBytes = UE.GetBytes(pass);
        byte[] aesKey = SHA256Managed.Create().ComputeHash(passwordBytes);
        byte[] aesIV = MD5.Create().ComputeHash(passwordBytes);
        aes.Key = aesKey;
        aes.IV = aesIV;
        aes.Mode = CipherMode.CBC;
        aes.Padding = PaddingMode.PKCS7;

        // Check if bad
        secret = GetWaspFactory(aes);
        if (!string.Equals(BitConverter.ToString(aes.Key), secret))
        {
            aes.Clear();
            return false;
        }
        else
        {
            aes.Clear();
            return true;
        }
    }


    // Only gives the key if the admin password has been provided, No catch case currently for giving the wrong pass
    // Similar to what happens in Authenticate, but returns an Aes object
    public Aes GetKey(string pass)
    {
        Aes AES = null;

        // Create a new AES key.
        AES = Aes.Create();

        UnicodeEncoding UE = new UnicodeEncoding();
        byte[] passwordBytes = UE.GetBytes(pass);
        byte[] aesKey = SHA256Managed.Create().ComputeHash(passwordBytes);
        byte[] aesIV = MD5.Create().ComputeHash(passwordBytes);
        AES.Key = aesKey;
        AES.IV = aesIV;
        AES.Mode = CipherMode.CBC;
        AES.Padding = PaddingMode.PKCS7;

        return AES;
    }


    // Returns the wasp from the factory
    private string GetWaspFactory(Aes key)
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load("Vault.xml");

        try
        {
            Decrypt(xmlDoc, key);
        } 
        catch (Exception e) 
        {
            return "";
        }
        XmlNode elem = xmlDoc.SelectSingleNode("/User/WaspFactory");
        Encrypt(xmlDoc, "User", key);

        return elem.InnerText;
    }


    // Encrypts a passed xml file, looks to encrypt at the passed ElementName, using the key to encrypt
    public static void Encrypt(XmlDocument Doc, string ElementName, SymmetricAlgorithm Key)
    {
        // Check the arguments.
        if (Doc == null)
            throw new ArgumentNullException("Doc");
        if (ElementName == null)
            throw new ArgumentNullException("ElementToEncrypt");
        if (Key == null)
            throw new ArgumentNullException("Alg");

        // Find the specified element to encrypt
        XmlElement elementToEncrypt = Doc.GetElementsByTagName(ElementName)[0] as XmlElement;

        // Throw an XmlException if the element was not found.
        if (elementToEncrypt == null)
        {
            throw new XmlException("The specified element was not found");
        }

        // Start encrypting and have encryptedElement hold some info
        EncryptedXml eXml = new EncryptedXml();
        byte[] encryptedElement = eXml.EncryptData(elementToEncrypt, Key, false);
       
        // Place the encrypted data
        EncryptedData edElement = new EncryptedData();
        edElement.Type = EncryptedXml.XmlEncElementUrl;

        // Create an EncryptionMethod element so that the
        // receiver knows which algorithm to use for decryption.
        // Determine what kind of algorithm is being used and
        // supply the appropriate URL to the EncryptionMethod element.
        string encryptionMethod = null;

        if (Key is Aes)
        {
            encryptionMethod = EncryptedXml.XmlEncAES256Url;
        }
        else
        {
            // Throw an exception if the transform is not AES
            throw new CryptographicException("The specified algorithm is not supported or not recommended for XML Encryption.");
        }

        edElement.EncryptionMethod = new EncryptionMethod(encryptionMethod);

        // Add the CipherData into the edElement
        edElement.CipherData.CipherValue = encryptedElement;

        // Replace the original Element with the EncryptedElement
        EncryptedXml.ReplaceElement(elementToEncrypt, edElement, false);
        Doc.Save("Vault.xml");
    }


    // Decrypt the passed xml document with the given key. Will fail if the wrong key is supplied.
    // An incorect key can cause a padding exception to raise
    public static void Decrypt(XmlDocument Doc, SymmetricAlgorithm Alg)
    {
        // Check the arguments.
        if (Doc == null)
            throw new ArgumentNullException("Doc");
        if (Alg == null)
            throw new ArgumentNullException("Alg");

        // Find the EncryptedData element in the XmlDocument.
        XmlElement encryptedElement = Doc.GetElementsByTagName("EncryptedData")[0] as XmlElement;

        // If the EncryptedData element was not found, throw an exception.
        if (encryptedElement == null)
        {
            throw new XmlException("The EncryptedData element was not found.");
        }

        // Create an EncryptedData object and populate it.
        EncryptedData edElement = new EncryptedData();
        edElement.LoadXml(encryptedElement);

        // Create a new EncryptedXml object.
        EncryptedXml exml = new EncryptedXml();

        // Decrypt the element using the symmetric key.
        byte[] rgbOutput = exml.DecryptData(edElement, Alg);

        // Replace the encryptedData element with the plaintext XML element.
        exml.ReplaceData(encryptedElement, rgbOutput);

        // Save
        Doc.Save("Vault.xml");
    }
}
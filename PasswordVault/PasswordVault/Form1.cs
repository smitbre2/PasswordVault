using System;
using System.Security.Cryptography;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.Text;

namespace PasswordVault
{
    public partial class Form1 : Form
    {
        // Useful things I need to use mainly for QoL or neccessity (For now...)
        public static string MFK = "";
        public static DataGridView dataGridView;
        string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath),
                                        "Vault.xml");
        private AES KEY_WRAPPER = new AES();


        // This form handles the application start, first time initialization, and saving of new data.
        // When authenticated it hides and opens up the "MainForm" that will house data
        public Form1()
        {

            // First Time Use can make closing the application at start tricky
            if (IsFirstTimeUse())
            {
                // A false response is our queue to close shop
                var firstTimeSetupResult = FirstTimeSetup();
                
                if (firstTimeSetupResult == false)
                {
                    Environment.Exit(0);
                } 
            }

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // This is the click event for the initial lock Screen (This form) password input
        private void button1_Click(object sender, EventArgs e)
        {
            // Authenticate the login credentials
            if ( KEY_WRAPPER.AuthLogin(textBox1.Text) )
            {
                // Open next form password is good
                this.Hide();
                MFK = textBox1.Text;
                var mainForm = new MainForm();
                mainForm.ShowDialog();

                // When MainForm Closes, cleanup and save new data
                SaveDataFromDGV(dataGridView);
                this.Close();
            }
            else
            {
                // Login is wrong
                string errMsg = "User credentials are incorrect.";
                MessageBoxButtons errBtns = MessageBoxButtons.OK;
                MessageBox.Show(errMsg, "Invalid", errBtns);  
            }
        }


        // Called at form closing to save and encrypt the new vault entries from the dgv into vault.xml
        private void SaveDataFromDGV(DataGridView dgv)
        {
            Aes aes = KEY_WRAPPER.GetKey(MFK);
            XDocument xDoc = XDocument.Load("Vault.xml");

            // Now open text
            XmlDocument xmlDoc = DocumentExtensions.ToXmlDocument(xDoc);
            AES.Decrypt(ref xmlDoc, aes);

            // Reopen since the handle as technically been closed. This open statement must be here
            xDoc = DocumentExtensions.ToXDocument(xmlDoc);
            XElement workElem = xDoc.Element("User").Element("Logins");   // Index to replace


            // Out with old in with new
            xDoc.Descendants("Logins").Descendants().Remove();    

            // Create list of elements in regards to data and format
            XElement root;
            XElement url;
            XElement user;
            XElement pass;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                root = new XElement("Login");
                url = new XElement("WebsiteURL");
                user = new XElement("Username");
                pass = new XElement("Password");

                url.Value   = dgv.Rows[i].Cells[0].Value.ToString();
                user.Value = dgv.Rows[i].Cells[1].Value.ToString();
                pass.Value  = dgv.Rows[i].Cells[2].Value.ToString();

                // Structure
                root.Add(url);
                root.Add(user);
                root.Add(pass);
                xDoc.Element("User").Element("Logins").Add(root);
            }

            // Call encrypt
            AES.Encrypt(DocumentExtensions.ToXmlDocument(xDoc),
                          "User",
                          aes);
            aes.Clear();
        }
       

        // Has the Vault been initialized? Returns true if it exists
        private bool IsFirstTimeUse()
        {
            return !File.Exists(path);
        }


        // First time setup includes taking in the admin password and hashing into the xml
        // Returns true on succesful initialization, false if no key is provided
        private bool FirstTimeSetup()
        {
            // Alert user to happenings and prompt for an adminstrator password
            FirstStartupForm fsForm = new FirstStartupForm();
            fsForm.ShowDialog();
            string userOutput = fsForm.newPass;

            // Check if user is trying to exit application
            if (string.IsNullOrEmpty(userOutput) )
            {
                return false;
            }

            // Create the Vault xml file
            XDocument xmlDoc = new XDocument();

            // Get user input
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] passwordBytes = UE.GetBytes(userOutput);
            byte[] aesHash = SHA256Managed.Create().ComputeHash(passwordBytes);

            // Create the initial xml schema
            XElement root = new XElement("User");
            XElement wf = new XElement("WaspFactory", BitConverter.ToString(aesHash));
            XElement logins = new XElement("Logins");

            root.Add(wf);
            root.Add(logins);
            xmlDoc.Add(root);

            // Save file
            AES.Encrypt(DocumentExtensions.ToXmlDocument(xmlDoc),
                        "User",
                        KEY_WRAPPER.GetKey(userOutput));
            return true;
        }
    }
}


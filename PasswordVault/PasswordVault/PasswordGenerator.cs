using System.Security.Cryptography;

namespace PasswordVault
{
    class PasswordGenerator
    {
        public string GeneratePassword(int passwordLength)
        {
            string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string numbers = "0123456789";
            string special = "!@#$%^&*()-_=+<,>.";
            string allChars = letters + numbers + special;

            // Generate some randomness
            byte[] rand = new byte[passwordLength];
            using (var rng = RandomNumberGenerator.Create())
                rng.GetBytes(rand);

            // BreakUp string into individual characters and store the relative array length
            char[] seperatedChars = allChars.ToCharArray();
            char[] password = new char[passwordLength];
            int availableCharLength = seperatedChars.Length;
            for (int i = 0; i < passwordLength; i++)
            {
                password[i] = seperatedChars[rand[i] % availableCharLength];
            }

            return new string(password);
        }
    }
}

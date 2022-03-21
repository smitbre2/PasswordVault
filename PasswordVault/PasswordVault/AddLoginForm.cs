using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class AddLoginForm : Form
    {
        // SubForm BS. Need to return user values to main form
        public string urlReturn { get; set; }
        public string usernameReturn { get; set; }
        public string passwordReturn { get; set; }
        private PasswordGenerator gen = new PasswordGenerator();

        public AddLoginForm()
        {
            InitializeComponent();
        }


        private void AddLoginForm_Load(object sender, EventArgs e)
        {

        }


        // Btn to add new table entry
        private void addBtn_Click(object sender, EventArgs e)
        {
            // A text box is empty
            if ( string.IsNullOrEmpty(urlTB.Text) )
            {
                MessageBox.Show("No website URL was provided.", "No URL Input", MessageBoxButtons.OK);
            } else if ( string.IsNullOrEmpty(usernameTB.Text) )
            {
                MessageBox.Show("No username was provided.", "No Username Input", MessageBoxButtons.OK);
            } else if ( string.IsNullOrEmpty(passwordTB.Text) )
            {
                MessageBox.Show("No password was provided.", "No Password Input", MessageBoxButtons.OK);
            } else
            {
                // Input good, finalize return
                urlReturn = urlTB.Text;
                usernameReturn = usernameTB.Text;
                passwordReturn = passwordTB.Text;
                this.Close();
            }
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            urlReturn = null;
            usernameReturn = null;
            passwordReturn = null;
            this.Close();
        }


        // Generate a secure random password
        private void createPasswordBtn_Click(object sender, EventArgs e)
        {
            passwordTB.Text = gen.GeneratePassword((int)passwordLengthTB.Value);
        }
    }
}

using System;
using System.Windows.Forms;

namespace PasswordVault
{
    // Used only on first time startup or when the program fails to find the Vault.xml
    // Returns a user inputted string to the calling form
    public partial class FirstStartupForm : Form
    {
        public string newPass { get; set; }

        public FirstStartupForm()
        {
            InitializeComponent();
        }


        // Confirms user input for password string
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want this as your adminstrator password?",
                            "Confirm Adminstrator Password",
                            MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                newPass = adminPasswordTB.Text;
                this.Close();
            }
        }

        private void FirstStartupForm_Load(object sender, EventArgs e)
        {

        }
    }
}

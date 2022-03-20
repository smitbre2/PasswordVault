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


        // Guarantees a non-empty string to indicate the new admin pass
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            // Make sure something is provided
            if (adminPasswordTB.Text.Length == 0)
            {
                MessageBox.Show("Please provide an adminstrator password.",
                                "No Input",
                                MessageBoxButtons.OK);
            } else {

                DialogResult result = MessageBox.Show("Are you sure you want this as your adminstrator password?",
                                "Confirm Adminstrator Password",
                                MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    newPass = adminPasswordTB.Text;
                    this.Close();
                }
            }
        }

        private void FirstStartupForm_Load(object sender, EventArgs e)
        {

        }

         
        // Returns empty string to denote the user exiting the application
        private void FirstStartupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Prompt user if they want to exit application
                var result = MessageBox.Show("Do you want to exit the application?",
                                "Exit Application",
                                MessageBoxButtons.YesNo);

                if (result == DialogResult.OK)
                {
                    newPass = "";
                }
            }
        }
    }
}

using System;
using System.Xml;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class MainForm : Form
    {
        private static readonly string MFK = Form1.MFK;  // Toss it over to encrpyt at close
        private readonly AES KEY_WRAPPER = new AES();

        // Setsup DataGridView and some menu options
        public MainForm()
        {
            InitializeComponent();

            // Deletion should only be available when an entry is selected
            deleteBtn.Enabled = false;

            // Link programmatic handler
            dataGridView1.MouseClick += DataGridView1_MouseClick;
            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick1;

            // First time use of table
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Website URL";
            dataGridView1.Columns[1].Name = "Username";
            dataGridView1.Columns[2].Name = "Password";

            // Read in encrypted data and decode for the table
            PopulateDataGridView();
        }


        // Before we free all the memory of this form, toss info to calling form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Form1.dataGridView = dataGridView1;
        }
        

        // Override default handling of header clicks to not select any items
        private void DataGridView1_ColumnHeaderMouseClick1(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.dataGridView1.ClearSelection();
        }


        // In the pits of darkness use cellMouseDown as it won't fail like every other cell click handler
        // Seriously, thank you CellMouseDown handler
        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                deleteBtn.Enabled = true;
            }
        }
        

        // Add login info provided by the user
        private void AddLoginButton_Click(object sender, EventArgs e)
        {
            // Open up appropriate window for adding in a new entry
            var addLoginForm = new AddLoginForm();
            addLoginForm.ShowDialog();

            // Strap those results into an accessbile array
            string[] result = {addLoginForm.urlReturn,
                                addLoginForm.usernameReturn,
                                addLoginForm.passwordReturn };

            // Add the entry if available
            if (!string.IsNullOrEmpty(result[0]))
            {
                dataGridView1.Rows.Add(result);
               
                // Do I really need this? So far it works, so...
                dataGridView1.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
            }
        }


        // Delete Login info selected by user
        private void DeleteLoginButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                var result = MessageBox.Show("Do you really want to delete the selected entry?", "Delete Selected Entry", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.dataGridView1.Rows.RemoveAt(
                        this.dataGridView1.CurrentCell.RowIndex);
                    this.dataGridView1.ClearSelection();
                }
            }
            deleteBtn.Enabled = false;  // We just deleted our selection, clear ability to acess delete button
        }


        // Use MouseClick handler to find when nothing has been clicked to clear the current selection and disable deletion
        private void DataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            // HitTest to find where the mouse was clicked and determine if it is not the DataGridView
            var hit = dataGridView1.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                deleteBtn.Enabled = false;
                dataGridView1.ClearSelection();
            }
        }


        // Grab vault and populate the datagridview
        private void PopulateDataGridView()
        {
            // Load document into memory object and load into the data table
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("Vault.xml");

            // Generate aes and Decrypt
            var aes = KEY_WRAPPER.GetKey(MFK);
            AES.Decrypt(xmlDoc, aes);

            // Try and find the login information to add to table
            var node = xmlDoc.SelectNodes("/User/Logins/Login"); 
            for (int i = 0; i < node.Count; i++)
            {
                // Get Children of Login. AKA that specific login information
                var children = node.Item(i).ChildNodes;
                string[] str = { children.Item(0).InnerText,       // Url
                                 children.Item(1).InnerText,      // User
                                 children.Item(2).InnerText };   // Pass
                
                // Add on the i'th login information to the table
                dataGridView1.Rows.Add(str);
            }
            AES.Encrypt(xmlDoc, "User", aes);
            aes.Clear();
        }



        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PasswordVault utilizes fun things like SHA256, MD5, PKCS7 to achieve an AES that securely stores your login details.\n\n\t\tCurrent Version 0.2.0",
                            "About PasswordVault",
                            MessageBoxButtons.OK);
        }
    }
}

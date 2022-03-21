
namespace PasswordVault
{
    partial class AddLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.header1 = new System.Windows.Forms.Label();
            this.urlLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.createPasswordBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.usernameTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.passwordLengthTB = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthTB)).BeginInit();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.AutoSize = true;
            this.header1.Location = new System.Drawing.Point(321, 13);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(159, 13);
            this.header1.TabIndex = 0;
            this.header1.Text = "Add new login information below";
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(121, 68);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(71, 13);
            this.urlLabel.TabIndex = 1;
            this.urlLabel.Text = "Website URL";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(121, 110);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(55, 13);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(121, 167);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // createPasswordBtn
            // 
            this.createPasswordBtn.Location = new System.Drawing.Point(124, 195);
            this.createPasswordBtn.Name = "createPasswordBtn";
            this.createPasswordBtn.Size = new System.Drawing.Size(157, 23);
            this.createPasswordBtn.TabIndex = 5;
            this.createPasswordBtn.Text = "Create Password of Length: ";
            this.createPasswordBtn.UseVisualStyleBackColor = true;
            this.createPasswordBtn.Click += new System.EventHandler(this.createPasswordBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(124, 288);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add Login";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(475, 288);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(218, 65);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(398, 20);
            this.urlTB.TabIndex = 8;
            // 
            // usernameTB
            // 
            this.usernameTB.Location = new System.Drawing.Point(218, 107);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.Size = new System.Drawing.Size(398, 20);
            this.usernameTB.TabIndex = 9;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(218, 164);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(398, 20);
            this.passwordTB.TabIndex = 10;
            // 
            // passwordLengthTB
            // 
            this.passwordLengthTB.Location = new System.Drawing.Point(296, 195);
            this.passwordLengthTB.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.passwordLengthTB.Name = "passwordLengthTB";
            this.passwordLengthTB.Size = new System.Drawing.Size(64, 20);
            this.passwordLengthTB.TabIndex = 11;
            this.passwordLengthTB.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // AddLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordLengthTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.usernameTB);
            this.Controls.Add(this.urlTB);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.createPasswordBtn);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.header1);
            this.Name = "AddLoginForm";
            this.Text = "Add New Login Information";
            this.Load += new System.EventHandler(this.AddLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header1;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button createPasswordBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox urlTB;
        private System.Windows.Forms.TextBox usernameTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.NumericUpDown passwordLengthTB;
    }
}
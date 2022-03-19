
namespace PasswordVault
{
    partial class FirstStartupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adminPasswordTB = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome! Either this is your first time using this product, or you have unfortuna" +
    "tly deleted your vault :(\r\nGo ahead and provide an adminstrator key that will be" +
    " used to open and close your vault.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(684, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = " Remember, this key should be lengthy to prevent bruteforce attempts into the vau" +
    "lt and should be memorable or written down in a secure place!";
            // 
            // adminPasswordTB
            // 
            this.adminPasswordTB.Location = new System.Drawing.Point(200, 233);
            this.adminPasswordTB.Name = "adminPasswordTB";
            this.adminPasswordTB.Size = new System.Drawing.Size(400, 20);
            this.adminPasswordTB.TabIndex = 2;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(320, 364);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(161, 23);
            this.confirmBtn.TabIndex = 3;
            this.confirmBtn.Text = "Set Adminstrator Password";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // FirstStartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.adminPasswordTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FirstStartupForm";
            this.Text = "First Time Startup";
            this.Load += new System.EventHandler(this.FirstStartupForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adminPasswordTB;
        private System.Windows.Forms.Button confirmBtn;
    }
}
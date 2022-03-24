
namespace PasswordVault
{
    partial class SettingsForm
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
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.passwordLengthLabel = new System.Windows.Forms.Label();
            this.passwordAlphabetLabel = new System.Windows.Forms.Label();
            this.windowSettingsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.vaultResolutionLabel = new System.Windows.Forms.Label();
            this.vaultBackgroundLabel = new System.Windows.Forms.Label();
            this.vaultForegroundLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordLengthTB = new System.Windows.Forms.NumericUpDown();
            this.passwordAlphabetTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.xResolutionTB = new System.Windows.Forms.NumericUpDown();
            this.yResolutionTB = new System.Windows.Forms.NumericUpDown();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.gridColorBtn = new System.Windows.Forms.Button();
            this.textColorBtn = new System.Windows.Forms.Button();
            this.textBackgroundColorBtn = new System.Windows.Forms.Button();
            this.highlightColorBtn = new System.Windows.Forms.Button();
            this.highlightedTextBtn = new System.Windows.Forms.Button();
            this.textFontBtn = new System.Windows.Forms.Button();
            this.backgroundColorBtn = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveBtn = new System.Windows.Forms.Button();
            this.settingsPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xResolutionTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yResolutionTB)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsPanel
            // 
            this.settingsPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.settingsPanel.Controls.Add(this.saveBtn);
            this.settingsPanel.Controls.Add(this.tableLayoutPanel2);
            this.settingsPanel.Controls.Add(this.windowSettingsLabel);
            this.settingsPanel.Controls.Add(this.passwordLabel);
            this.settingsPanel.Location = new System.Drawing.Point(12, 12);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(360, 457);
            this.settingsPanel.TabIndex = 0;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(5, 5);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(5);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(111, 13);
            this.passwordLabel.TabIndex = 0;
            this.passwordLabel.Text = "Password Settings";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.11111F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.88889F));
            this.tableLayoutPanel1.Controls.Add(this.passwordLengthLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordAlphabetLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.passwordLengthTB, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordAlphabetTB, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.77064F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.22935F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(360, 109);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // passwordLengthLabel
            // 
            this.passwordLengthLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordLengthLabel.AutoSize = true;
            this.passwordLengthLabel.Location = new System.Drawing.Point(3, 0);
            this.passwordLengthLabel.Name = "passwordLengthLabel";
            this.passwordLengthLabel.Size = new System.Drawing.Size(93, 26);
            this.passwordLengthLabel.TabIndex = 0;
            this.passwordLengthLabel.Text = "Password Default Length";
            // 
            // passwordAlphabetLabel
            // 
            this.passwordAlphabetLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.passwordAlphabetLabel.AutoSize = true;
            this.passwordAlphabetLabel.Location = new System.Drawing.Point(3, 61);
            this.passwordAlphabetLabel.Name = "passwordAlphabetLabel";
            this.passwordAlphabetLabel.Size = new System.Drawing.Size(98, 13);
            this.passwordAlphabetLabel.TabIndex = 1;
            this.passwordAlphabetLabel.Text = "Password Alphabet";
            // 
            // windowSettingsLabel
            // 
            this.windowSettingsLabel.AutoSize = true;
            this.windowSettingsLabel.BackColor = System.Drawing.Color.Transparent;
            this.windowSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowSettingsLabel.Location = new System.Drawing.Point(5, 138);
            this.windowSettingsLabel.Margin = new System.Windows.Forms.Padding(5);
            this.windowSettingsLabel.Name = "windowSettingsLabel";
            this.windowSettingsLabel.Size = new System.Drawing.Size(135, 13);
            this.windowSettingsLabel.TabIndex = 1;
            this.windowSettingsLabel.Text = "Vault Window Settings";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.16667F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.83333F));
            this.tableLayoutPanel2.Controls.Add(this.highlightedTextBtn, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.highlightColorBtn, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.textBackgroundColorBtn, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.textColorBtn, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.gridColorBtn, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.vaultResolutionLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 8);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.vaultForegroundLabel, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.vaultBackgroundLabel, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.xResolutionTB, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.yResolutionTB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.backgroundColorBtn, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textFontBtn, 1, 8);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 159);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 9;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(360, 264);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // vaultResolutionLabel
            // 
            this.vaultResolutionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vaultResolutionLabel.AutoSize = true;
            this.vaultResolutionLabel.Location = new System.Drawing.Point(3, 8);
            this.vaultResolutionLabel.Name = "vaultResolutionLabel";
            this.vaultResolutionLabel.Size = new System.Drawing.Size(67, 13);
            this.vaultResolutionLabel.TabIndex = 0;
            this.vaultResolutionLabel.Text = "Resolution X";
            // 
            // vaultBackgroundLabel
            // 
            this.vaultBackgroundLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vaultBackgroundLabel.AutoSize = true;
            this.vaultBackgroundLabel.Location = new System.Drawing.Point(3, 66);
            this.vaultBackgroundLabel.Name = "vaultBackgroundLabel";
            this.vaultBackgroundLabel.Size = new System.Drawing.Size(92, 13);
            this.vaultBackgroundLabel.TabIndex = 2;
            this.vaultBackgroundLabel.Text = "Background Color";
            // 
            // vaultForegroundLabel
            // 
            this.vaultForegroundLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.vaultForegroundLabel.AutoSize = true;
            this.vaultForegroundLabel.Location = new System.Drawing.Point(3, 95);
            this.vaultForegroundLabel.Name = "vaultForegroundLabel";
            this.vaultForegroundLabel.Size = new System.Drawing.Size(53, 13);
            this.vaultForegroundLabel.TabIndex = 3;
            this.vaultForegroundLabel.Text = "Grid Color";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Text Color";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Highlight Color";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Highlighted Text Color";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Text Background Color";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Text Font";
            // 
            // passwordLengthTB
            // 
            this.passwordLengthTB.Location = new System.Drawing.Point(114, 3);
            this.passwordLengthTB.Name = "passwordLengthTB";
            this.passwordLengthTB.Size = new System.Drawing.Size(120, 20);
            this.passwordLengthTB.TabIndex = 2;
            // 
            // passwordAlphabetTB
            // 
            this.passwordAlphabetTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordAlphabetTB.Location = new System.Drawing.Point(114, 29);
            this.passwordAlphabetTB.Multiline = true;
            this.passwordAlphabetTB.Name = "passwordAlphabetTB";
            this.passwordAlphabetTB.Size = new System.Drawing.Size(243, 77);
            this.passwordAlphabetTB.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Resolution Y";
            // 
            // xResolutionTB
            // 
            this.xResolutionTB.Location = new System.Drawing.Point(108, 3);
            this.xResolutionTB.Name = "xResolutionTB";
            this.xResolutionTB.Size = new System.Drawing.Size(120, 20);
            this.xResolutionTB.TabIndex = 11;
            // 
            // yResolutionTB
            // 
            this.yResolutionTB.Location = new System.Drawing.Point(108, 32);
            this.yResolutionTB.Name = "yResolutionTB";
            this.yResolutionTB.Size = new System.Drawing.Size(120, 20);
            this.yResolutionTB.TabIndex = 12;
            // 
            // gridColorBtn
            // 
            this.gridColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColorBtn.Location = new System.Drawing.Point(108, 90);
            this.gridColorBtn.Name = "gridColorBtn";
            this.gridColorBtn.Size = new System.Drawing.Size(32, 23);
            this.gridColorBtn.TabIndex = 15;
            this.gridColorBtn.Text = "...";
            this.gridColorBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gridColorBtn.UseVisualStyleBackColor = true;
            this.gridColorBtn.Click += new System.EventHandler(this.gridColorBtn_Click);
            // 
            // textColorBtn
            // 
            this.textColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textColorBtn.Location = new System.Drawing.Point(108, 119);
            this.textColorBtn.Name = "textColorBtn";
            this.textColorBtn.Size = new System.Drawing.Size(32, 23);
            this.textColorBtn.TabIndex = 16;
            this.textColorBtn.Text = "...";
            this.textColorBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.textColorBtn.UseVisualStyleBackColor = true;
            this.textColorBtn.Click += new System.EventHandler(this.textColorBtn_Click);
            // 
            // textBackgroundColorBtn
            // 
            this.textBackgroundColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBackgroundColorBtn.Location = new System.Drawing.Point(108, 148);
            this.textBackgroundColorBtn.Name = "textBackgroundColorBtn";
            this.textBackgroundColorBtn.Size = new System.Drawing.Size(32, 23);
            this.textBackgroundColorBtn.TabIndex = 17;
            this.textBackgroundColorBtn.Text = "...";
            this.textBackgroundColorBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.textBackgroundColorBtn.UseVisualStyleBackColor = true;
            this.textBackgroundColorBtn.Click += new System.EventHandler(this.textBackgroundColorBtn_Click);
            // 
            // highlightColorBtn
            // 
            this.highlightColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlightColorBtn.Location = new System.Drawing.Point(108, 177);
            this.highlightColorBtn.Name = "highlightColorBtn";
            this.highlightColorBtn.Size = new System.Drawing.Size(32, 23);
            this.highlightColorBtn.TabIndex = 18;
            this.highlightColorBtn.Text = "...";
            this.highlightColorBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.highlightColorBtn.UseVisualStyleBackColor = true;
            this.highlightColorBtn.Click += new System.EventHandler(this.highlightColorBtn_Click);
            // 
            // highlightedTextBtn
            // 
            this.highlightedTextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlightedTextBtn.Location = new System.Drawing.Point(108, 206);
            this.highlightedTextBtn.Name = "highlightedTextBtn";
            this.highlightedTextBtn.Size = new System.Drawing.Size(32, 23);
            this.highlightedTextBtn.TabIndex = 19;
            this.highlightedTextBtn.Text = "...";
            this.highlightedTextBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.highlightedTextBtn.UseVisualStyleBackColor = true;
            this.highlightedTextBtn.Click += new System.EventHandler(this.highlightedTextBtn_Click);
            // 
            // textFontBtn
            // 
            this.textFontBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFontBtn.Location = new System.Drawing.Point(108, 235);
            this.textFontBtn.Name = "textFontBtn";
            this.textFontBtn.Size = new System.Drawing.Size(32, 23);
            this.textFontBtn.TabIndex = 20;
            this.textFontBtn.Text = "...";
            this.textFontBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.textFontBtn.UseVisualStyleBackColor = true;
            this.textFontBtn.Click += new System.EventHandler(this.textFontBtn_Click);
            // 
            // backgroundColorBtn
            // 
            this.backgroundColorBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backgroundColorBtn.Location = new System.Drawing.Point(108, 61);
            this.backgroundColorBtn.Name = "backgroundColorBtn";
            this.backgroundColorBtn.Size = new System.Drawing.Size(32, 23);
            this.backgroundColorBtn.TabIndex = 13;
            this.backgroundColorBtn.Text = "...";
            this.backgroundColorBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.backgroundColorBtn.UseVisualStyleBackColor = true;
            this.backgroundColorBtn.Click += new System.EventHandler(this.backgroundColorBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveBtn.Location = new System.Drawing.Point(0, 423);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(360, 34);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save Settings";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 481);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.settingsPanel);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordLengthTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xResolutionTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yResolutionTB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label passwordLengthLabel;
        private System.Windows.Forms.Label passwordAlphabetLabel;
        private System.Windows.Forms.Label windowSettingsLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label vaultResolutionLabel;
        private System.Windows.Forms.Label vaultBackgroundLabel;
        private System.Windows.Forms.Label vaultForegroundLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button highlightedTextBtn;
        private System.Windows.Forms.Button highlightColorBtn;
        private System.Windows.Forms.Button textBackgroundColorBtn;
        private System.Windows.Forms.Button textColorBtn;
        private System.Windows.Forms.Button gridColorBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown xResolutionTB;
        private System.Windows.Forms.NumericUpDown yResolutionTB;
        private System.Windows.Forms.Button backgroundColorBtn;
        private System.Windows.Forms.Button textFontBtn;
        private System.Windows.Forms.NumericUpDown passwordLengthTB;
        private System.Windows.Forms.TextBox passwordAlphabetTB;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button saveBtn;
    }
}
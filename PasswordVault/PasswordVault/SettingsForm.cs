using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordVault
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void backgroundColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Properties.Settings.Default.MainScreenBackgroundColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.MainScreenBackgroundColor
                    = colorDialog1.Color;
            }
        }

        private void gridColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Properties.Settings.Default.DataGridColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DataGridColor
                    = colorDialog1.Color;
            }
        }

        private void textColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Properties.Settings.Default.DataTextColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DataTextColor
                    = colorDialog1.Color;
            }
        }

        private void textBackgroundColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Properties.Settings.Default.DataCellBackgroundColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DataCellBackgroundColor
                    = colorDialog1.Color;
            }
        }

        private void highlightColorBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Properties.Settings.Default.DataSelectionBackgroundColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DataSelectionBackgroundColor
                    = colorDialog1.Color;
            }
        }

        private void highlightedTextBtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Properties.Settings.Default.DataSelectionTextColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DataSelectionTextColor
                    = colorDialog1.Color;
            }
        }

        private void textFontBtn_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = Properties.Settings.Default.DataFont;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DataFont = fontDialog1.Font;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}

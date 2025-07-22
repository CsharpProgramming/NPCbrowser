using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPCbrowser.Properties;

namespace NPCbrowser
{
    public partial class SettingsForm: Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.DarkMode = checkBox1.Checked;
            Settings.Default.Save();
            BrowserTab.Instance2.ThemeManager();
            ThemeManager();
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            Settings.Default.GoogleSearch = checkBox3.Checked;
            Settings.Default.Save();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = Settings.Default.DarkMode;
            checkBox3.Checked = Settings.Default.GoogleSearch;

            ThemeManager();
        }

        private void ThemeManager()
        {
            if (Settings.Default.DarkMode)
            {
                panel1.BackColor = Color.FromArgb(40, 40, 40);
                checkBox1.ForeColor = Color.White;
                checkBox2.ForeColor = Color.White;
                checkBox3.ForeColor = Color.White;
            }

            else
            {
                panel1.BackColor = Color.White;
                checkBox1.ForeColor = Color.Black;
                checkBox2.ForeColor = Color.Black;
                checkBox3.ForeColor = Color.Black;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2; //Import web browser extension
using EasyTabs;
using NPCbrowser.Properties;

namespace NPCbrowser
{
    public partial class Form1: TitleBarTabs
    {
        public static Form1 Instance;

        public Form1()
        {
            InitializeComponent();
            Instance = this;

            AeroPeekEnabled = false;
            TabRenderer = new ChromeTabRenderer(this);
        }

        public override TitleBarTab CreateTab()
        {
            var browserTab = new BrowserTab();
            return new TitleBarTab(this)
            {
                Content = browserTab
            };
        }

        public TitleBarTab CreateSettingsTab()
        {
            var settingsForm = new SettingsForm();
            settingsForm.Dock = DockStyle.Fill;

            return new TitleBarTab(this)
            {
                Content = settingsForm,
            };
        }
    }
}

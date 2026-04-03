using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using NPC_Browser_PRO.Controls;
using NPC_Browser_PRO.Properties;

namespace NPC_Browser_PRO
{
    public partial class BrowserTab: Form
    {
        public static BrowserTab Instance2;

        public BrowserTab()
        {
            InitializeComponent();

            webView21.Source = new Uri("https://www.duckduckgo.com");
            Controls.Add(webView21);
            webView21.Location = new Point(0, 35);
            webView21.Size = new Size(this.Width, this.Height - 35);
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            modernTextBox1.Size = new Size(panel1.Width - 230, 26);
            Instance2 = this;
        }

        private async void BrowserTab_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.DocumentTitleChanged += CoreWebView2_DocumentTitleChanged;
            webView21.CoreWebView2.Navigate("file:///D:\\Code\\BrowserCustomPages\\home.html");
            modernTextBox1.RemovePlaceholder(sender, e); //Makes placeholder text actually work
            modernTextBox1.SetPlaceholderText("npc://home"); //Makes placeholder text actually work

            ThemeManager();
        }

        private void CoreWebView2_DocumentTitleChanged(object sender, object e)
        {
            string title = webView21.CoreWebView2.DocumentTitle;

            if (string.IsNullOrWhiteSpace(title))
            {
                this.Text = "New Tab";
            }

            else
            {
                this.Text = title;
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (Settings.Default.GoogleSearch == true)
            {
                webView21.Source = new Uri("https://google.com");
            }

            else
            {
                webView21.Source = new Uri("https://www.duckduckgo.com");
            }

            modernTextBox1.TextBoxText = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void Urlbar(string input)
        {
            if (input == null || input == "" || input.Contains("npc://home"))
            {
                webView21.CoreWebView2.Navigate("file:///D:\\Code\\BrowserCustomPages\\home.html");
            }

            else if (input.StartsWith("https://"))
            {
                try
                {
                    webView21.CoreWebView2.Navigate("siticoneTextBox1.Text");
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }

            else if (input.Contains("npc://"))
            {
                try
                {
                    webView21.CoreWebView2.Navigate("file:///D:\\Code\\BrowserCustomPages\\npc.html");
                }

                catch (Exception ex) { MessageBox.Show("Error: " + ex); }
            }

            else
            {
                try
                {
                    if (Settings.Default.GoogleSearch == true)
                    {
                        webView21.CoreWebView2.Navigate($"https://www.google.com/search?q={HttpUtility.UrlDecode(modernTextBox1.TextBoxText)}");
                        return;
                    }
                    webView21.CoreWebView2.Navigate($"https://duckduckgo.com/?q={HttpUtility.UrlEncode(modernTextBox1.TextBoxText)}&atb=v443-1&ia=web");
                }

                catch (Exception ex) { MessageBox.Show("Error: " + ex); }
            }
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads"));
        }

        private void MoreButton_Click(object sender, EventArgs e)
        {
            var SettingsTab = Form1.Instance.CreateSettingsTab();
            Form1.Instance.Tabs.Add(SettingsTab);
            Form1.Instance.SelectedTabIndex = Form1.Instance.Tabs.Count - 1;
        }

        public void ThemeManager()
        {
            if (Settings.Default.DarkMode)
            {
                panel1.BackColor = Color.FromArgb(40, 40, 40);
                modernTextBox1.BackColor = Color.FromArgb(40, 40, 40);
                modernTextBox1.BackgroundColor = Color.FromArgb(40, 40, 40);
                modernTextBox1.TextColor = Color.White;
                MoreButton.Image = Resources.more2;
                BackButton.Image = Resources.arrow2;
                ForwardButton.Image = Resources.right_arrow2;
                HomeButton.Image = Resources.home2;
                DownloadButton.Image = Resources.downloads2;
            }

            else
            {
                panel1.BackColor = Color.White;
                modernTextBox1.BackColor = Color.White;
                modernTextBox1.BackgroundColor = Color.White;
                modernTextBox1.TextColor = Color.FromArgb(125, 137, 149);
                MoreButton.Image = Resources.more;
                BackButton.Image = Resources.arrow;
                ForwardButton.Image = Resources.right_arrow;
                HomeButton.Image = Resources.home;
                DownloadButton.Image = Resources.downloads;
            }
        }

        private void modernTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    Urlbar(modernTextBox1.TextBoxText);
                    e.Handled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }

            this.Text = webView21.CoreWebView2.DocumentTitle;
        }

        private void BrowserTab_SizeChanged(object sender, EventArgs e)
        {
            modernTextBox1.Size = new Size(panel1.Width - 230, 26);
        }
    }
}

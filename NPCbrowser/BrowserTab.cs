using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;
using System.Diagnostics;
using NPCbrowser.Properties;

namespace NPCbrowser
{
    public partial class BrowserTab: Form
    {
        //Hello this it the actually important code, please do not judge. thank you.
        //Coded in like 3 days with a bit of help from stackoverflow.
        //Enjoy mate.


        public static BrowserTab Instance2;

        public BrowserTab()
        {
            InitializeComponent();

            webView21.Source = new Uri("https://www.duckduckgo.com");
            Controls.Add(webView21);
            webView21.Location = new Point(0, 35);
            webView21.Size = new Size(this.Width, this.Height - 35);
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Instance2 = this;
        }

        private async void BrowserTab_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.DocumentTitleChanged += CoreWebView2_DocumentTitleChanged;
            webView21.CoreWebView2.Navigate("file:///D:\\Code\\BrowserCustomPages\\home.html");
            siticoneTextBox1.Text = "npc://home";

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

            siticoneTextBox1.Text = "";
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            webView21.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            webView21.GoForward();
        }

        private void siticoneTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            if (e.KeyChar == 13 && siticoneTextBox1.Text.StartsWith("https://"))
            {
                try
                {
                    webView21.CoreWebView2.Navigate(siticoneTextBox1.Text);
                    e.Handled = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }

            else if (e.KeyChar == 13 && siticoneTextBox1.Text.Contains("npc://home"))
            {
                try
                {
                    webView21.CoreWebView2.Navigate("file:///D:\\Code\\BrowserCustomPages\\home.html");
                    e.Handled = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }

            else if (e.KeyChar == 13 && siticoneTextBox1.Text.Contains("npc://"))
            {
                try
                {
                    webView21.CoreWebView2.Navigate("file:///D:\\Code\\BrowserCustomPages\\npc.html");
                    e.Handled = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }

            else if (e.KeyChar == 13)
            {
                try
                {
                    if (Settings.Default.GoogleSearch == true)
                    {
                        webView21.CoreWebView2.Navigate($"https://www.google.com/search?q={HttpUtility.UrlDecode(siticoneTextBox1.Text)}");
                    }

                    else
                    {
                        webView21.CoreWebView2.Navigate($"https://duckduckgo.com/?q={HttpUtility.UrlEncode(siticoneTextBox1.Text)}&atb=v443-1&ia=web");
                    }

                    e.Handled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
            }
            this.Text = webView21.CoreWebView2.DocumentTitle;
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
                siticoneTextBox1.FillColor = Color.FromArgb(55, 55, 55);
                siticoneTextBox1.ForeColor = Color.White;
                MoreButton.Image = Resources.more2;
                BackButton.Image = Resources.arrow2;
                ForwardButton.Image = Resources.right_arrow2;
                HomeButton.Image = Resources.home2;
                DownloadButton.Image = Resources.downloads2;
            }

            else
            {
                panel1.BackColor = Color.White;
                siticoneTextBox1.FillColor = Color.FromArgb(230, 230, 230);
                siticoneTextBox1.ForeColor = Color.FromArgb(125, 137, 149);
                MoreButton.Image = Resources.more;
                BackButton.Image = Resources.arrow;
                ForwardButton.Image = Resources.right_arrow;
                HomeButton.Image = Resources.home;
                DownloadButton.Image = Resources.downloads;
            }
        }
    }
}

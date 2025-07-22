namespace NPCbrowser
{
    partial class BrowserTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserTab));
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.MoreButton = new System.Windows.Forms.PictureBox();
            this.DownloadButton = new System.Windows.Forms.PictureBox();
            this.ForwardButton = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.PictureBox();
            this.HomeButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoreButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(0, 35);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(801, 414);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.siticoneTextBox1);
            this.panel1.Controls.Add(this.MoreButton);
            this.panel1.Controls.Add(this.DownloadButton);
            this.panel1.Controls.Add(this.ForwardButton);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 1;
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneTextBox1.BorderRadius = 10;
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Location = new System.Drawing.Point(134, 4);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(551, 28);
            this.siticoneTextBox1.TabIndex = 5;
            this.siticoneTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.siticoneTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.siticoneTextBox1_KeyPress);
            // 
            // MoreButton
            // 
            this.MoreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoreButton.Image = global::NPCbrowser.Properties.Resources.more;
            this.MoreButton.Location = new System.Drawing.Point(754, 7);
            this.MoreButton.Name = "MoreButton";
            this.MoreButton.Size = new System.Drawing.Size(34, 21);
            this.MoreButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MoreButton.TabIndex = 4;
            this.MoreButton.TabStop = false;
            this.MoreButton.Click += new System.EventHandler(this.MoreButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadButton.Image = global::NPCbrowser.Properties.Resources.downloads;
            this.DownloadButton.Location = new System.Drawing.Point(721, 7);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(34, 21);
            this.DownloadButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DownloadButton.TabIndex = 3;
            this.DownloadButton.TabStop = false;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.Image = global::NPCbrowser.Properties.Resources.right_arrow;
            this.ForwardButton.Location = new System.Drawing.Point(80, 9);
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(34, 21);
            this.ForwardButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ForwardButton.TabIndex = 2;
            this.ForwardButton.TabStop = false;
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Image = ((System.Drawing.Image)(resources.GetObject("BackButton.Image")));
            this.BackButton.Location = new System.Drawing.Point(47, 9);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(34, 21);
            this.BackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackButton.TabIndex = 1;
            this.BackButton.TabStop = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(3, 9);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(43, 21);
            this.HomeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HomeButton.TabIndex = 0;
            this.HomeButton.TabStop = false;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // BrowserTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webView21);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowserTab";
            this.Text = "New Tab";
            this.Load += new System.EventHandler(this.BrowserTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoreButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownloadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ForwardButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox HomeButton;
        private System.Windows.Forms.PictureBox ForwardButton;
        private System.Windows.Forms.PictureBox BackButton;
        private System.Windows.Forms.PictureBox MoreButton;
        private System.Windows.Forms.PictureBox DownloadButton;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
    }
}
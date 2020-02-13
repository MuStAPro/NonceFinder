namespace NonceFinder
{
    partial class NonceFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NonceFinder));
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtNonce = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.lblpath = new System.Windows.Forms.Label();
            this.lblnonce = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version = new System.Windows.Forms.Label();
            this.about = new System.Windows.Forms.Label();
            this.copyNonce = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(109, 34);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(208, 20);
            this.txtFilePath.TabIndex = 0;
            // 
            // txtNonce
            // 
            this.txtNonce.Location = new System.Drawing.Point(61, 63);
            this.txtNonce.Name = "txtNonce";
            this.txtNonce.ReadOnly = true;
            this.txtNonce.Size = new System.Drawing.Size(256, 20);
            this.txtNonce.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(327, 34);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // lblpath
            // 
            this.lblpath.AutoSize = true;
            this.lblpath.Location = new System.Drawing.Point(13, 34);
            this.lblpath.Name = "lblpath";
            this.lblpath.Size = new System.Drawing.Size(90, 13);
            this.lblpath.TabIndex = 3;
            this.lblpath.Text = "SHSH2 File Path:";
            // 
            // lblnonce
            // 
            this.lblnonce.AutoSize = true;
            this.lblnonce.Location = new System.Drawing.Point(13, 66);
            this.lblnonce.Name = "lblnonce";
            this.lblnonce.Size = new System.Drawing.Size(42, 13);
            this.lblnonce.TabIndex = 4;
            this.lblnonce.Text = "Nonce:";
            // 
            // open
            // 
            this.open.FileName = "Browse for shsh2 file";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(414, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.version.Location = new System.Drawing.Point(190, 98);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(28, 13);
            this.version.TabIndex = 6;
            this.version.Text = "v2.0";
            // 
            // about
            // 
            this.about.AutoSize = true;
            this.about.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.about.ForeColor = System.Drawing.Color.DarkRed;
            this.about.Location = new System.Drawing.Point(299, 98);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(111, 14);
            this.about.TabIndex = 7;
            this.about.Text = "Made by MuStAPro";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // copyNonce
            // 
            this.copyNonce.Location = new System.Drawing.Point(327, 63);
            this.copyNonce.Name = "copyNonce";
            this.copyNonce.Size = new System.Drawing.Size(75, 23);
            this.copyNonce.TabIndex = 8;
            this.copyNonce.Text = "Copy";
            this.copyNonce.UseVisualStyleBackColor = true;
            this.copyNonce.Click += new System.EventHandler(this.copyNonce_Click);
            this.copyNonce.MouseHover += new System.EventHandler(this.copyNonce_MouseHover);
            // 
            // NonceFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 117);
            this.Controls.Add(this.copyNonce);
            this.Controls.Add(this.about);
            this.Controls.Add(this.version);
            this.Controls.Add(this.lblnonce);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtNonce);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "NonceFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nonce Finder";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtNonce;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblpath;
        private System.Windows.Forms.Label lblnonce;
        private System.Windows.Forms.OpenFileDialog open;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label about;
        private System.Windows.Forms.Button copyNonce;
    }
}


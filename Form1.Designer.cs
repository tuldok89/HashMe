namespace HashMe
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Sha512Radio = new System.Windows.Forms.RadioButton();
            this.Sha384Radio = new System.Windows.Forms.RadioButton();
            this.RipemdRadio = new System.Windows.Forms.RadioButton();
            this.Sha256Radio = new System.Windows.Forms.RadioButton();
            this.Sha1Radio = new System.Windows.Forms.RadioButton();
            this.Md5Radio = new System.Windows.Forms.RadioButton();
            this.CrcRadio = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hashTextBox = new System.Windows.Forms.TextBox();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.BgWorker = new System.ComponentModel.BackgroundWorker();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(330, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.AllowDrop = true;
            this.FileNameTextBox.Location = new System.Drawing.Point(13, 30);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(274, 20);
            this.FileNameTextBox.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(293, 28);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(25, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sha512Radio);
            this.groupBox1.Controls.Add(this.Sha384Radio);
            this.groupBox1.Controls.Add(this.RipemdRadio);
            this.groupBox1.Controls.Add(this.Sha256Radio);
            this.groupBox1.Controls.Add(this.Sha1Radio);
            this.groupBox1.Controls.Add(this.Md5Radio);
            this.groupBox1.Controls.Add(this.CrcRadio);
            this.groupBox1.Location = new System.Drawing.Point(13, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 97);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hash Algorithm";
            // 
            // Sha512Radio
            // 
            this.Sha512Radio.AutoSize = true;
            this.Sha512Radio.Location = new System.Drawing.Point(118, 65);
            this.Sha512Radio.Name = "Sha512Radio";
            this.Sha512Radio.Size = new System.Drawing.Size(68, 17);
            this.Sha512Radio.TabIndex = 0;
            this.Sha512Radio.Text = "SHA-512";
            this.Sha512Radio.UseVisualStyleBackColor = true;
            this.Sha512Radio.CheckedChanged += new System.EventHandler(this.Sha512Radio_CheckedChanged);
            // 
            // Sha384Radio
            // 
            this.Sha384Radio.AutoSize = true;
            this.Sha384Radio.Location = new System.Drawing.Point(118, 42);
            this.Sha384Radio.Name = "Sha384Radio";
            this.Sha384Radio.Size = new System.Drawing.Size(68, 17);
            this.Sha384Radio.TabIndex = 0;
            this.Sha384Radio.Text = "SHA-384";
            this.Sha384Radio.UseVisualStyleBackColor = true;
            this.Sha384Radio.CheckedChanged += new System.EventHandler(this.Sha384Radio_CheckedChanged);
            // 
            // RipemdRadio
            // 
            this.RipemdRadio.AutoSize = true;
            this.RipemdRadio.Location = new System.Drawing.Point(231, 19);
            this.RipemdRadio.Name = "RipemdRadio";
            this.RipemdRadio.Size = new System.Drawing.Size(67, 17);
            this.RipemdRadio.TabIndex = 0;
            this.RipemdRadio.Text = "RIPEMD";
            this.RipemdRadio.UseVisualStyleBackColor = true;
            this.RipemdRadio.CheckedChanged += new System.EventHandler(this.RipemdRadio_CheckedChanged);
            // 
            // Sha256Radio
            // 
            this.Sha256Radio.AutoSize = true;
            this.Sha256Radio.Location = new System.Drawing.Point(118, 19);
            this.Sha256Radio.Name = "Sha256Radio";
            this.Sha256Radio.Size = new System.Drawing.Size(68, 17);
            this.Sha256Radio.TabIndex = 0;
            this.Sha256Radio.Text = "SHA-256";
            this.Sha256Radio.UseVisualStyleBackColor = true;
            this.Sha256Radio.CheckedChanged += new System.EventHandler(this.Sha256Radio_CheckedChanged);
            // 
            // Sha1Radio
            // 
            this.Sha1Radio.AutoSize = true;
            this.Sha1Radio.Location = new System.Drawing.Point(6, 65);
            this.Sha1Radio.Name = "Sha1Radio";
            this.Sha1Radio.Size = new System.Drawing.Size(56, 17);
            this.Sha1Radio.TabIndex = 0;
            this.Sha1Radio.Text = "SHA-1";
            this.Sha1Radio.UseVisualStyleBackColor = true;
            this.Sha1Radio.CheckedChanged += new System.EventHandler(this.Sha1Radio_CheckedChanged);
            // 
            // Md5Radio
            // 
            this.Md5Radio.AutoSize = true;
            this.Md5Radio.Location = new System.Drawing.Point(6, 42);
            this.Md5Radio.Name = "Md5Radio";
            this.Md5Radio.Size = new System.Drawing.Size(48, 17);
            this.Md5Radio.TabIndex = 0;
            this.Md5Radio.Text = "MD5";
            this.Md5Radio.UseVisualStyleBackColor = true;
            this.Md5Radio.CheckedChanged += new System.EventHandler(this.Md5Radio_CheckedChanged);
            // 
            // CrcRadio
            // 
            this.CrcRadio.AutoSize = true;
            this.CrcRadio.Location = new System.Drawing.Point(6, 19);
            this.CrcRadio.Name = "CrcRadio";
            this.CrcRadio.Size = new System.Drawing.Size(62, 17);
            this.CrcRadio.TabIndex = 0;
            this.CrcRadio.Text = "CRC-32";
            this.CrcRadio.UseVisualStyleBackColor = true;
            this.CrcRadio.CheckedChanged += new System.EventHandler(this.CrcRadio_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hashTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 89);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hash";
            // 
            // hashTextBox
            // 
            this.hashTextBox.Location = new System.Drawing.Point(6, 20);
            this.hashTextBox.Multiline = true;
            this.hashTextBox.Name = "hashTextBox";
            this.hashTextBox.Size = new System.Drawing.Size(293, 63);
            this.hashTextBox.TabIndex = 0;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(19, 159);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(292, 19);
            this.ProgressBar.TabIndex = 5;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(101, 280);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(128, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate Hash";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // BgWorker
            // 
            this.BgWorker.WorkerReportsProgress = true;
            this.BgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorker_DoWork);
            // 
            // OpenFile
            // 
            this.OpenFile.Filter = "All Files|*.*";
            this.OpenFile.Title = "Browse";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 316);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Sha512Radio;
        private System.Windows.Forms.RadioButton Sha384Radio;
        private System.Windows.Forms.RadioButton Sha256Radio;
        private System.Windows.Forms.RadioButton Sha1Radio;
        private System.Windows.Forms.RadioButton Md5Radio;
        private System.Windows.Forms.RadioButton CrcRadio;
        private System.Windows.Forms.RadioButton RipemdRadio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox hashTextBox;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Button CalculateButton;
        private System.ComponentModel.BackgroundWorker BgWorker;
        private System.Windows.Forms.OpenFileDialog OpenFile;
    }
}


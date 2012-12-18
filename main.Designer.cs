namespace installer
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            this.InstallBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxVersions = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSDcard = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbAdvancedSDCards = new System.Windows.Forms.ComboBox();
            this.gbAdvancedBackup = new System.Windows.Forms.GroupBox();
            this.btBackup = new System.Windows.Forms.Button();
            this.gbAdvancedRestore = new System.Windows.Forms.GroupBox();
            this.btRestore = new System.Windows.Forms.Button();
            this.btSelectImage = new System.Windows.Forms.Button();
            this.tbRestoreImageLocation = new System.Windows.Forms.TextBox();
            this.restoreTimer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelDownloadStatus = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btRefreshAdvanced = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbAdvancedBackup.SuspendLayout();
            this.gbAdvancedRestore.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // InstallBtn
            // 
            this.InstallBtn.Location = new System.Drawing.Point(6, 22);
            this.InstallBtn.Name = "InstallBtn";
            this.InstallBtn.Size = new System.Drawing.Size(277, 38);
            this.InstallBtn.TabIndex = 2;
            this.InstallBtn.Text = "Install";
            this.InstallBtn.UseVisualStyleBackColor = true;
            this.InstallBtn.Click += new System.EventHandler(this.InstallBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxVersions);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 55);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Select version";
            // 
            // comboBoxVersions
            // 
            this.comboBoxVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVersions.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVersions.FormattingEnabled = true;
            this.comboBoxVersions.Location = new System.Drawing.Point(6, 22);
            this.comboBoxVersions.Name = "comboBoxVersions";
            this.comboBoxVersions.Size = new System.Drawing.Size(277, 22);
            this.comboBoxVersions.TabIndex = 1;
            this.comboBoxVersions.SelectedIndexChanged += new System.EventHandler(this.comboBoxVersions_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBoxSDcard);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 54);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Select SD card";
            // 
            // comboBoxSDcard
            // 
            this.comboBoxSDcard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSDcard.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSDcard.FormattingEnabled = true;
            this.comboBoxSDcard.Location = new System.Drawing.Point(6, 22);
            this.comboBoxSDcard.Name = "comboBoxSDcard";
            this.comboBoxSDcard.Size = new System.Drawing.Size(249, 22);
            this.comboBoxSDcard.TabIndex = 2;
            this.comboBoxSDcard.SelectedIndexChanged += new System.EventHandler(this.comboBoxSDcard_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.InstallBtn);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 70);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Install";
            // 
            // progressTimer
            // 
            this.progressTimer.Tick += new System.EventHandler(this.installTimer_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(311, 229);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(303, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Easy mode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.btRefreshAdvanced);
            this.tabPage2.Controls.Add(this.cbAdvancedSDCards);
            this.tabPage2.Controls.Add(this.gbAdvancedBackup);
            this.tabPage2.Controls.Add(this.gbAdvancedRestore);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(303, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbAdvancedSDCards
            // 
            this.cbAdvancedSDCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdvancedSDCards.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAdvancedSDCards.FormattingEnabled = true;
            this.cbAdvancedSDCards.Location = new System.Drawing.Point(6, 12);
            this.cbAdvancedSDCards.Name = "cbAdvancedSDCards";
            this.cbAdvancedSDCards.Size = new System.Drawing.Size(261, 22);
            this.cbAdvancedSDCards.TabIndex = 18;
            this.cbAdvancedSDCards.SelectedIndexChanged += new System.EventHandler(this.cbAdvancedSDCards_SelectedIndexChanged);
            // 
            // gbAdvancedBackup
            // 
            this.gbAdvancedBackup.Controls.Add(this.btBackup);
            this.gbAdvancedBackup.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdvancedBackup.Location = new System.Drawing.Point(6, 140);
            this.gbAdvancedBackup.Name = "gbAdvancedBackup";
            this.gbAdvancedBackup.Size = new System.Drawing.Size(289, 52);
            this.gbAdvancedBackup.TabIndex = 17;
            this.gbAdvancedBackup.TabStop = false;
            this.gbAdvancedBackup.Text = "Backup SD card";
            // 
            // btBackup
            // 
            this.btBackup.Location = new System.Drawing.Point(6, 22);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(277, 23);
            this.btBackup.TabIndex = 5;
            this.btBackup.Text = "One click backup";
            this.btBackup.UseVisualStyleBackColor = true;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // gbAdvancedRestore
            // 
            this.gbAdvancedRestore.Controls.Add(this.btRestore);
            this.gbAdvancedRestore.Controls.Add(this.btSelectImage);
            this.gbAdvancedRestore.Controls.Add(this.tbRestoreImageLocation);
            this.gbAdvancedRestore.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdvancedRestore.Location = new System.Drawing.Point(6, 41);
            this.gbAdvancedRestore.Name = "gbAdvancedRestore";
            this.gbAdvancedRestore.Size = new System.Drawing.Size(289, 85);
            this.gbAdvancedRestore.TabIndex = 16;
            this.gbAdvancedRestore.TabStop = false;
            this.gbAdvancedRestore.Text = "Restore image";
            // 
            // btRestore
            // 
            this.btRestore.Location = new System.Drawing.Point(187, 52);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(96, 23);
            this.btRestore.TabIndex = 4;
            this.btRestore.Text = "Restore";
            this.btRestore.UseVisualStyleBackColor = true;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // btSelectImage
            // 
            this.btSelectImage.Location = new System.Drawing.Point(7, 52);
            this.btSelectImage.Name = "btSelectImage";
            this.btSelectImage.Size = new System.Drawing.Size(174, 23);
            this.btSelectImage.TabIndex = 3;
            this.btSelectImage.Text = "Select .img";
            this.btSelectImage.UseVisualStyleBackColor = false;
            this.btSelectImage.Click += new System.EventHandler(this.btSelectImage_Click);
            // 
            // tbRestoreImageLocation
            // 
            this.tbRestoreImageLocation.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRestoreImageLocation.Location = new System.Drawing.Point(6, 22);
            this.tbRestoreImageLocation.Name = "tbRestoreImageLocation";
            this.tbRestoreImageLocation.ReadOnly = true;
            this.tbRestoreImageLocation.Size = new System.Drawing.Size(277, 21);
            this.tbRestoreImageLocation.TabIndex = 2;
            // 
            // restoreTimer
            // 
            this.restoreTimer.Tick += new System.EventHandler(this.restoreTimer_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(17, 36);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(277, 21);
            this.progressBar.TabIndex = 20;
            // 
            // labelDownloadStatus
            // 
            this.labelDownloadStatus.Location = new System.Drawing.Point(1, 9);
            this.labelDownloadStatus.Name = "labelDownloadStatus";
            this.labelDownloadStatus.Size = new System.Drawing.Size(301, 23);
            this.labelDownloadStatus.TabIndex = 21;
            this.labelDownloadStatus.Text = "Downloading XBian 1.0 Alpha 3 - 60%";
            this.labelDownloadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelDownloadStatus);
            this.groupBox4.Controls.Add(this.progressBar);
            this.groupBox4.Location = new System.Drawing.Point(4, 317);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 66);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::installer.Properties.Resources.xbianlogobluetech;
            this.pictureBox1.Location = new System.Drawing.Point(-40, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.button1.BackgroundImage = global::installer.Properties.Resources.refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(261, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 21);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btRefreshAdvanced
            // 
            this.btRefreshAdvanced.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btRefreshAdvanced.BackgroundImage = global::installer.Properties.Resources.refresh;
            this.btRefreshAdvanced.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRefreshAdvanced.FlatAppearance.BorderSize = 0;
            this.btRefreshAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefreshAdvanced.Location = new System.Drawing.Point(273, 12);
            this.btRefreshAdvanced.Name = "btRefreshAdvanced";
            this.btRefreshAdvanced.Size = new System.Drawing.Size(22, 21);
            this.btRefreshAdvanced.TabIndex = 20;
            this.btRefreshAdvanced.UseVisualStyleBackColor = true;
            this.btRefreshAdvanced.Click += new System.EventHandler(this.btRefreshAdvanced_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonInfo.Location = new System.Drawing.Point(287, 1);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(29, 27);
            this.buttonInfo.TabIndex = 24;
            this.buttonInfo.Text = "?";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.button2_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(318, 387);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XBian installer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.gbAdvancedBackup.ResumeLayout(false);
            this.gbAdvancedRestore.ResumeLayout(false);
            this.gbAdvancedRestore.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InstallBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxVersions;
        private System.Windows.Forms.ComboBox comboBoxSDcard;
        private System.Windows.Forms.Timer progressTimer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbAdvancedBackup;
        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.GroupBox gbAdvancedRestore;
        private System.Windows.Forms.Button btRestore;
        private System.Windows.Forms.Button btSelectImage;
        private System.Windows.Forms.TextBox tbRestoreImageLocation;
        private System.Windows.Forms.ComboBox cbAdvancedSDCards;
        private System.Windows.Forms.Timer restoreTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btRefreshAdvanced;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelDownloadStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonInfo;

    }
}


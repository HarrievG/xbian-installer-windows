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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxSDcard = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btRefreshAdvanced = new System.Windows.Forms.Button();
            this.cbAdvancedSDCards = new System.Windows.Forms.ComboBox();
            this.gbAdvancedBackup = new System.Windows.Forms.GroupBox();
            this.btBackup = new System.Windows.Forms.Button();
            this.gbAdvancedRestore = new System.Windows.Forms.GroupBox();
            this.btRestore = new System.Windows.Forms.Button();
            this.btSelectImage = new System.Windows.Forms.Button();
            this.tbRestoreImageLocation = new System.Windows.Forms.TextBox();
            this.restoreTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonCancelOperation = new System.Windows.Forms.Button();
            this.labelDownloadStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.InstallBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.InstallBtn.Location = new System.Drawing.Point(8, 23);
            this.InstallBtn.Margin = new System.Windows.Forms.Padding(4);
            this.InstallBtn.Name = "InstallBtn";
            this.InstallBtn.Size = new System.Drawing.Size(311, 34);
            this.InstallBtn.TabIndex = 2;
            this.InstallBtn.Text = "Install";
            this.InstallBtn.UseVisualStyleBackColor = true;
            this.InstallBtn.Click += new System.EventHandler(this.InstallBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxVersions);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(324, 55);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Select version";
            // 
            // comboBoxVersions
            // 
            this.comboBoxVersions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVersions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxVersions.FormattingEnabled = true;
            this.comboBoxVersions.Location = new System.Drawing.Point(8, 23);
            this.comboBoxVersions.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVersions.Name = "comboBoxVersions";
            this.comboBoxVersions.Size = new System.Drawing.Size(308, 24);
            this.comboBoxVersions.TabIndex = 1;
            this.comboBoxVersions.SelectedIndexChanged += new System.EventHandler(this.comboBoxVersions_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.comboBoxSDcard);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(8, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(324, 53);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Select SD card";
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.button1.BackgroundImage = global::installer.Properties.Resources.refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(290, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 26);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxSDcard
            // 
            this.comboBoxSDcard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSDcard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.comboBoxSDcard.FormattingEnabled = true;
            this.comboBoxSDcard.Location = new System.Drawing.Point(8, 23);
            this.comboBoxSDcard.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSDcard.Name = "comboBoxSDcard";
            this.comboBoxSDcard.Size = new System.Drawing.Size(278, 24);
            this.comboBoxSDcard.TabIndex = 2;
            this.comboBoxSDcard.SelectedIndexChanged += new System.EventHandler(this.comboBoxSDcard_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.InstallBtn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(8, 156);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(324, 64);
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
            this.tabControl1.Location = new System.Drawing.Point(5, 110);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(346, 250);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(338, 224);
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
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(407, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Advanced mode";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btRefreshAdvanced
            // 
            this.btRefreshAdvanced.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btRefreshAdvanced.BackgroundImage = global::installer.Properties.Resources.refresh;
            this.btRefreshAdvanced.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRefreshAdvanced.FlatAppearance.BorderSize = 0;
            this.btRefreshAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefreshAdvanced.Location = new System.Drawing.Point(364, 15);
            this.btRefreshAdvanced.Margin = new System.Windows.Forms.Padding(4);
            this.btRefreshAdvanced.Name = "btRefreshAdvanced";
            this.btRefreshAdvanced.Size = new System.Drawing.Size(29, 26);
            this.btRefreshAdvanced.TabIndex = 20;
            this.btRefreshAdvanced.UseVisualStyleBackColor = true;
            this.btRefreshAdvanced.Click += new System.EventHandler(this.btRefreshAdvanced_Click);
            // 
            // cbAdvancedSDCards
            // 
            this.cbAdvancedSDCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAdvancedSDCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbAdvancedSDCards.FormattingEnabled = true;
            this.cbAdvancedSDCards.Location = new System.Drawing.Point(8, 15);
            this.cbAdvancedSDCards.Margin = new System.Windows.Forms.Padding(4);
            this.cbAdvancedSDCards.Name = "cbAdvancedSDCards";
            this.cbAdvancedSDCards.Size = new System.Drawing.Size(347, 24);
            this.cbAdvancedSDCards.TabIndex = 18;
            this.cbAdvancedSDCards.SelectedIndexChanged += new System.EventHandler(this.cbAdvancedSDCards_SelectedIndexChanged);
            // 
            // gbAdvancedBackup
            // 
            this.gbAdvancedBackup.Controls.Add(this.btBackup);
            this.gbAdvancedBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbAdvancedBackup.Location = new System.Drawing.Point(8, 172);
            this.gbAdvancedBackup.Margin = new System.Windows.Forms.Padding(4);
            this.gbAdvancedBackup.Name = "gbAdvancedBackup";
            this.gbAdvancedBackup.Padding = new System.Windows.Forms.Padding(4);
            this.gbAdvancedBackup.Size = new System.Drawing.Size(385, 64);
            this.gbAdvancedBackup.TabIndex = 17;
            this.gbAdvancedBackup.TabStop = false;
            this.gbAdvancedBackup.Text = "Backup SD card";
            // 
            // btBackup
            // 
            this.btBackup.Location = new System.Drawing.Point(8, 27);
            this.btBackup.Margin = new System.Windows.Forms.Padding(4);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(369, 28);
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
            this.gbAdvancedRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbAdvancedRestore.Location = new System.Drawing.Point(8, 50);
            this.gbAdvancedRestore.Margin = new System.Windows.Forms.Padding(4);
            this.gbAdvancedRestore.Name = "gbAdvancedRestore";
            this.gbAdvancedRestore.Padding = new System.Windows.Forms.Padding(4);
            this.gbAdvancedRestore.Size = new System.Drawing.Size(385, 105);
            this.gbAdvancedRestore.TabIndex = 16;
            this.gbAdvancedRestore.TabStop = false;
            this.gbAdvancedRestore.Text = "Restore image";
            // 
            // btRestore
            // 
            this.btRestore.Location = new System.Drawing.Point(249, 64);
            this.btRestore.Margin = new System.Windows.Forms.Padding(4);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(128, 28);
            this.btRestore.TabIndex = 4;
            this.btRestore.Text = "Restore";
            this.btRestore.UseVisualStyleBackColor = true;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // btSelectImage
            // 
            this.btSelectImage.Location = new System.Drawing.Point(9, 64);
            this.btSelectImage.Margin = new System.Windows.Forms.Padding(4);
            this.btSelectImage.Name = "btSelectImage";
            this.btSelectImage.Size = new System.Drawing.Size(232, 28);
            this.btSelectImage.TabIndex = 3;
            this.btSelectImage.Text = "Select .img";
            this.btSelectImage.UseVisualStyleBackColor = false;
            this.btSelectImage.Click += new System.EventHandler(this.btSelectImage_Click);
            // 
            // tbRestoreImageLocation
            // 
            this.tbRestoreImageLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.tbRestoreImageLocation.Location = new System.Drawing.Point(8, 27);
            this.tbRestoreImageLocation.Margin = new System.Windows.Forms.Padding(4);
            this.tbRestoreImageLocation.Name = "tbRestoreImageLocation";
            this.tbRestoreImageLocation.ReadOnly = true;
            this.tbRestoreImageLocation.Size = new System.Drawing.Size(368, 20);
            this.tbRestoreImageLocation.TabIndex = 2;
            // 
            // restoreTimer
            // 
            this.restoreTimer.Tick += new System.EventHandler(this.restoreTimer_Tick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonCancelOperation);
            this.groupBox4.Controls.Add(this.labelDownloadStatus);
            this.groupBox4.Controls.Add(this.progressBar);
            this.groupBox4.Location = new System.Drawing.Point(5, 364);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(346, 81);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            // 
            // buttonCancelOperation
            // 
            this.buttonCancelOperation.BackgroundImage = global::installer.Properties.Resources.cross;
            this.buttonCancelOperation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCancelOperation.FlatAppearance.BorderSize = 0;
            this.buttonCancelOperation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelOperation.Location = new System.Drawing.Point(315, 45);
            this.buttonCancelOperation.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCancelOperation.Name = "buttonCancelOperation";
            this.buttonCancelOperation.Size = new System.Drawing.Size(24, 22);
            this.buttonCancelOperation.TabIndex = 22;
            this.buttonCancelOperation.UseVisualStyleBackColor = true;
            this.buttonCancelOperation.Click += new System.EventHandler(this.buttonCancelOperation_Click);
            // 
            // labelDownloadStatus
            // 
            this.labelDownloadStatus.Location = new System.Drawing.Point(4, 11);
            this.labelDownloadStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDownloadStatus.Name = "labelDownloadStatus";
            this.labelDownloadStatus.Size = new System.Drawing.Size(334, 28);
            this.labelDownloadStatus.TabIndex = 21;
            this.labelDownloadStatus.Text = "Downloading XBian 1.0 Alpha 3 - 60%";
            this.labelDownloadStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(8, 44);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(299, 26);
            this.progressBar.TabIndex = 20;
            // 
            // buttonInfo
            // 
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonInfo.Location = new System.Drawing.Point(329, 1);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(22, 21);
            this.buttonInfo.TabIndex = 24;
            this.buttonInfo.Text = "?";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::installer.Properties.Resources.Splash;
            this.pictureBox1.Location = new System.Drawing.Point(28, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(354, 363);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.Button buttonCancelOperation;
        private System.Windows.Forms.Label labelDownloadStatus;
        private System.Windows.Forms.ProgressBar progressBar;

    }
}


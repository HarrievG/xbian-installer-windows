namespace installer
{
    partial class wlanautomatic
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
            this.btRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbNetworkNotListed = new System.Windows.Forms.Label();
            this.cbWNetworks = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.btDone = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbNetworkProtection = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbManSSID = new System.Windows.Forms.TextBox();
            this.btManDone = new System.Windows.Forms.Button();
            this.gbEnterPasswordAuto = new System.Windows.Forms.GroupBox();
            this.tbManPassword = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbManPassswordConfirm = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.gbEnterPasswordAuto.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRefresh
            // 
            this.btRefresh.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.btRefresh.BackgroundImage = global::installer.Properties.Resources.refresh;
            this.btRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRefresh.FlatAppearance.BorderSize = 0;
            this.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRefresh.Location = new System.Drawing.Point(307, 23);
            this.btRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btRefresh.Name = "btRefresh";
            this.btRefresh.Size = new System.Drawing.Size(29, 26);
            this.btRefresh.TabIndex = 23;
            this.btRefresh.UseVisualStyleBackColor = true;
            this.btRefresh.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbNetworkNotListed);
            this.groupBox1.Controls.Add(this.cbWNetworks);
            this.groupBox1.Controls.Add(this.btRefresh);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(344, 99);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select wireless network";
            // 
            // lbNetworkNotListed
            // 
            this.lbNetworkNotListed.AutoSize = true;
            this.lbNetworkNotListed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNetworkNotListed.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbNetworkNotListed.Location = new System.Drawing.Point(50, 67);
            this.lbNetworkNotListed.Name = "lbNetworkNotListed";
            this.lbNetworkNotListed.Size = new System.Drawing.Size(227, 15);
            this.lbNetworkNotListed.TabIndex = 24;
            this.lbNetworkNotListed.Text = "Hold here if your network isn\'t listed here";
            // 
            // cbWNetworks
            // 
            this.cbWNetworks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWNetworks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbWNetworks.FormattingEnabled = true;
            this.cbWNetworks.Location = new System.Drawing.Point(8, 23);
            this.cbWNetworks.Margin = new System.Windows.Forms.Padding(4);
            this.cbWNetworks.Name = "cbWNetworks";
            this.cbWNetworks.Size = new System.Drawing.Size(291, 24);
            this.cbWNetworks.TabIndex = 1;
            this.cbWNetworks.SelectedIndexChanged += new System.EventHandler(this.cbWNetworks_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPassword);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(7, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(344, 55);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enter password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(8, 22);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(328, 22);
            this.tbPassword.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPasswordConfirm);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(7, 177);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(344, 55);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Confirm password";
            // 
            // tbPasswordConfirm
            // 
            this.tbPasswordConfirm.Location = new System.Drawing.Point(8, 22);
            this.tbPasswordConfirm.Name = "tbPasswordConfirm";
            this.tbPasswordConfirm.PasswordChar = '*';
            this.tbPasswordConfirm.Size = new System.Drawing.Size(328, 22);
            this.tbPasswordConfirm.TabIndex = 0;
            // 
            // btDone
            // 
            this.btDone.Location = new System.Drawing.Point(7, 239);
            this.btDone.Name = "btDone";
            this.btDone.Size = new System.Drawing.Size(344, 35);
            this.btDone.TabIndex = 27;
            this.btDone.Text = "Done";
            this.btDone.UseVisualStyleBackColor = true;
            this.btDone.Click += new System.EventHandler(this.btDone_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(367, 306);
            this.tabControl.TabIndex = 28;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btDone);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(359, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Automatic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.btManDone);
            this.tabPage2.Controls.Add(this.gbEnterPasswordAuto);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(359, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbNetworkProtection);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(8, 66);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(344, 55);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Select wireless network protection";
            // 
            // cbNetworkProtection
            // 
            this.cbNetworkProtection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNetworkProtection.FormattingEnabled = true;
            this.cbNetworkProtection.Location = new System.Drawing.Point(11, 23);
            this.cbNetworkProtection.Name = "cbNetworkProtection";
            this.cbNetworkProtection.Size = new System.Drawing.Size(325, 24);
            this.cbNetworkProtection.TabIndex = 0;
            this.cbNetworkProtection.SelectedIndexChanged += new System.EventHandler(this.cbNetworkProtection_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbManSSID);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox6.Location = new System.Drawing.Point(11, 7);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(344, 55);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Enter SSID";
            // 
            // tbManSSID
            // 
            this.tbManSSID.Location = new System.Drawing.Point(8, 22);
            this.tbManSSID.Name = "tbManSSID";
            this.tbManSSID.Size = new System.Drawing.Size(328, 22);
            this.tbManSSID.TabIndex = 0;
            // 
            // btManDone
            // 
            this.btManDone.Location = new System.Drawing.Point(8, 238);
            this.btManDone.Name = "btManDone";
            this.btManDone.Size = new System.Drawing.Size(344, 35);
            this.btManDone.TabIndex = 30;
            this.btManDone.Text = "Done";
            this.btManDone.UseVisualStyleBackColor = true;
            this.btManDone.Click += new System.EventHandler(this.btManDone_Click);
            // 
            // gbEnterPasswordAuto
            // 
            this.gbEnterPasswordAuto.Controls.Add(this.tbManPassword);
            this.gbEnterPasswordAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbEnterPasswordAuto.Location = new System.Drawing.Point(8, 124);
            this.gbEnterPasswordAuto.Margin = new System.Windows.Forms.Padding(4);
            this.gbEnterPasswordAuto.Name = "gbEnterPasswordAuto";
            this.gbEnterPasswordAuto.Padding = new System.Windows.Forms.Padding(4);
            this.gbEnterPasswordAuto.Size = new System.Drawing.Size(344, 55);
            this.gbEnterPasswordAuto.TabIndex = 0;
            this.gbEnterPasswordAuto.TabStop = false;
            this.gbEnterPasswordAuto.Text = "Enter password";
            // 
            // tbManPassword
            // 
            this.tbManPassword.Location = new System.Drawing.Point(8, 22);
            this.tbManPassword.Name = "tbManPassword";
            this.tbManPassword.PasswordChar = '*';
            this.tbManPassword.Size = new System.Drawing.Size(328, 22);
            this.tbManPassword.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbManPassswordConfirm);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox5.Location = new System.Drawing.Point(8, 179);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(344, 55);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Confirm password";
            // 
            // tbManPassswordConfirm
            // 
            this.tbManPassswordConfirm.Location = new System.Drawing.Point(8, 22);
            this.tbManPassswordConfirm.Name = "tbManPassswordConfirm";
            this.tbManPassswordConfirm.PasswordChar = '*';
            this.tbManPassswordConfirm.Size = new System.Drawing.Size(328, 22);
            this.tbManPassswordConfirm.TabIndex = 0;
            // 
            // wlanautomatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 310);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "wlanautomatic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wlanautomatic_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.gbEnterPasswordAuto.ResumeLayout(false);
            this.gbEnterPasswordAuto.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbNetworkNotListed;
        private System.Windows.Forms.ComboBox cbWNetworks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbPasswordConfirm;
        private System.Windows.Forms.Button btDone;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox cbNetworkProtection;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox tbManSSID;
        private System.Windows.Forms.Button btManDone;
        private System.Windows.Forms.GroupBox gbEnterPasswordAuto;
        private System.Windows.Forms.TextBox tbManPassword;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbManPassswordConfirm;

    }
}
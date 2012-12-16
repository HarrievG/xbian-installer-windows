﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Threading;

namespace installer
{
    public partial class main : Form
    {
        // Location of the XML file which holds the mirrors
        private static string mirrorXMLFile = "https://raw.github.com/xbianonpi/wiki/master/mirrors.xml";

        // List with all the  USB devices & versions
        private List<uint> USBDevices;
        private List<version> versions;

        // Window for showing the progress
        private ProgressMeter windowProgressMeter;

        // WebClient for downloading files
        private WebClient webClient;

        private version selectedVersion;
        private uint selectedUSBDevice;
        private bool operationInProgress;

        public main()
        {
            InitializeComponent();

            // Loading devices & versions
            this.listDevices();
            this.loadVersions();

            // Setting up the webClient
            this.webClient = new WebClient();
            webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadProgressChanged);
            webClient.DownloadFileCompleted += webClient_DownloadFileCompleted;
            this.updateUI();
            this.operationInProgress = false; 
        }

        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Until the the download is finished the name of the file is "temp", rename it to selected XBian version
            version ver = this.versions[comboBoxVersions.SelectedIndex];
            File.Move(@"temp", ver.getArchiveName());
            this.windowProgressMeter.changeText( "(2/2) Installing XBian " + this.selectedVersion.getVersionName() + "on your SD card");
            this.initRestore(this.selectedVersion.getArchiveName(), this.USBDevices[this.comboBoxSDcard.SelectedIndex]);
        }

        public void loadVersions()
        {            
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                xmlDoc.Load(mirrorXMLFile);
            }
            catch (WebException)
            {
                MessageBox.Show("Unable to connect to the XBian server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);            
            }

            XmlNodeList XMLverName = xmlDoc.GetElementsByTagName("name");
            XmlNodeList XMLlocations = xmlDoc.GetElementsByTagName("locations");

            this.versions = new List<version>();
            for (int i = 0; i < XMLverName.Count; i++)
            {
                string verName = XMLverName[i].InnerText;
                string[] locations = XMLlocations[i].InnerText.Split(';');
                version ver = new version(verName, locations);
                this.versions.Add(ver);
            }

            comboBoxVersions.Items.Clear();

            bool latest = true;
            foreach (version v in versions)
            {
                if (latest)
                {
                    comboBoxVersions.Items.Add(v.getVersionName() + " (latest)");
                    latest = false;
                }
                else
                    comboBoxVersions.Items.Add(v.getVersionName());
            }
        }

        private void listDevices()
        {
            // TODO ADD drive letter
            this.comboBoxSDcard.Items.Clear();
            this.cbAdvancedSDCards.Items.Clear();
            this.USBDevices = new List<uint>();
            usbit32.ClearDevices();
            usbit32.FindDevices();
            usbit32.FindVolumes();
            uint usbdevice = usbit32.GetFirstDevice(true);          
            System.Text.StringBuilder deviceName = new System.Text.StringBuilder(100);
 
            while ((usbdevice != 0))
            {
                usbit32.GetFriendlyName(usbdevice, deviceName, 100);
                this.comboBoxSDcard.Items.Add(deviceName.ToString());
                this.cbAdvancedSDCards.Items.Add(deviceName.ToString());
                this.USBDevices.Add(usbdevice);
                usbdevice = usbit32.GetNextDevice(true);        
            }
        }

        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        private void comboBoxVersions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxVersions.SelectedItem != null)
            {
                this.selectedVersion = this.versions[comboBoxVersions.SelectedIndex];
                this.updateUI();
            }
        }

        private void updateUI()
        {
            if (this.comboBoxVersions.SelectedItem != null)
            {
                groupBox2.Enabled = true;
                groupBox1.ForeColor = Color.Green;

                // Easy tab
                if (this.comboBoxSDcard.SelectedItem != null)
                {
                    groupBox3.Enabled = true;
                    groupBox2.ForeColor = Color.Green;
                }
                else
                {
                    groupBox2.ForeColor = Color.Black;
                }
            }
            else
            {
                groupBox1.ForeColor = Color.Black;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
            }

            // Advanced tab
            if (this.cbAdvancedSDCards.SelectedItem != null)
            {
                this.gbAdvancedRestore.Enabled = true;
                this.gbAdvancedBackup.Enabled = true;

                // Restore groupbox
                if (this.tbRestoreImageLocation.Text != string.Empty)
                    this.btRestore.Enabled = true;
                else
                    this.btRestore.Enabled = false;
            }
            else
            {
                this.cbAdvancedSDCards.Text = "Select your SD card here";
                this.gbAdvancedRestore.Enabled = false;
                this.gbAdvancedBackup.Enabled = false;
            }
        }

        private void reset()
        {
            this.selectedVersion = null;
            this.updateUI();
            this.comboBoxSDcard.SelectedItem = null;
            this.comboBoxVersions.SelectedItem = null;
        }

        private void downloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.windowProgressMeter.setProgress(e.ProgressPercentage);
        }

        private void InstallBtn_Click(object sender, System.EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to continue? This will remove all data on the selected SD card", "Warning!", MessageBoxButtons.YesNo);
            if (!operationInProgress)
            {
                if (dialog == DialogResult.Yes)
                    // Checking if the file is already downloaded
                    if (System.IO.File.Exists(this.selectedVersion.getArchiveName()))
                    {
                        // Version has already been downloaded
                        this.initRestore(this.selectedVersion.getArchiveName(), this.USBDevices[this.comboBoxSDcard.SelectedIndex]);
                        this.windowProgressMeter = new ProgressMeter("Installing XBian " + this.selectedVersion.getVersionName() + " on your SD card");
                        this.windowProgressMeter.Show();
                        this.operationInProgress = true;
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("The selected XBian version has NOT been downloaded yet, want to download it now?", "XBian installer", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.webClient.DownloadFileAsync(new Uri(this.selectedVersion.getRandomMirror()), "temp");
                            this.windowProgressMeter = new ProgressMeter("(1/2) Downloading XBian " + this.selectedVersion.getVersionName());
                            this.windowProgressMeter.Show();
                            this.operationInProgress = true;
                        }
                    }
            }
            else
            {
                MessageBox.Show("An operation is already in progress, cancelling");
            }
        }

        public void initRestore(string imageLocation, uint usbDevice)
        {
            this.selectedUSBDevice = usbDevice;
            this.progressTimer.Enabled = true;
            Thread t = new Thread(() => restore(imageLocation, usbDevice));
            t.Start();
        }

        private void restore(string imageLocation, uint usbDevice)
        {
            UInt32 RestoreErrorNum = 0;

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            try
            {
                usbit32.RestoreVolume(usbDevice, imageLocation, 0, true, true, true, ref RestoreErrorNum);
                stopwatch.Stop();
                
            }
            catch (AccessViolationException)
            {
                MessageBox.Show("Could not access the SD card (write protected?)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Invoke((MethodInvoker)delegate
            {
                this.progressTimer.Stop();
                this.windowProgressMeter.Close();
            });

            if (stopwatch.ElapsedMilliseconds < 1000)
            {
                MessageBox.Show("Error, could not write to the SD card");
            }
            else
            {
                MessageBox.Show("Operation succesfully completed, plug your SD card into your Raspberry pi now");
            }

            this.operationInProgress = false;
        }

        private void installTimer_Tick(object sender, System.EventArgs e)
        {
            this.windowProgressMeter.setProgress(Convert.ToInt16(usbit32.GetProgress(this.selectedUSBDevice)) * 12);
        }

        private void comboBoxSDcard_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBoxSDcard.SelectedItem != null)
            {
                this.updateUI();
            }
        }

        private void btSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "img files (*.img)|*.img";
            dialog.Title = "Select a img file";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
                this.tbRestoreImageLocation.Text = dialog.FileName;

            this.updateUI();
        }

        private void btRestore_Click(object sender, EventArgs e)
        {
            if (!operationInProgress)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to restore the selected image? This will delete ALL data on your SD card.", "Continue?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.operationInProgress = true;
                    this.windowProgressMeter = new ProgressMeter("Restoring the selected image to your SD card");
                    this.windowProgressMeter.Show();
                    this.initRestore(this.tbRestoreImageLocation.Text, this.USBDevices[this.cbAdvancedSDCards.SelectedIndex]);
                }
            }
            else
            {
                MessageBox.Show("An operation is already in progress");
            }
        }

        private void cbAdvancedSDCards_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.updateUI();
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            if (!operationInProgress)
            {
                this.operationInProgress = true;
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Image file|*.img";
                dialog.Title = "Save SD card backup";
                dialog.ShowDialog();
                this.selectedUSBDevice = this.USBDevices[this.cbAdvancedSDCards.SelectedIndex];

                this.windowProgressMeter = new ProgressMeter("Makeing a backup of your SD card");
                this.restoreTimer.Start();
                this.windowProgressMeter.Show();

                if (dialog.FileName != "")
                {
                    Thread t = new Thread(() => backup(dialog.FileName, this.selectedUSBDevice));
                    t.Start();
                }
            }
            else
            {
                MessageBox.Show("An operation is already in progress");
            }
        }

        private void backup(string saveLocation, uint USBDevice)
        {
            UInt32 RestoreErrorNum = 0;
            usbit32.BackupVolume(USBDevice, saveLocation, "", 1, true, true, true,ref RestoreErrorNum);
            this.progressTimer.Stop();
            this.operationInProgress = false;
        }

        private void restoreTimer_Tick(object sender, EventArgs e)
        {
            this.windowProgressMeter.setProgress(Convert.ToInt16(usbit32.GetProgress(this.selectedUSBDevice)));

        }

        private void btRefreshAdvanced_Click(object sender, EventArgs e)
        {
            this.listDevices();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listDevices();
        }
    }
}

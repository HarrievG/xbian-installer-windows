using System;
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
using System.Management;

namespace installer
{
    public enum restoreType {
        CUSTOM, XBIAN
    }

    public partial class main : Form
    {
        // Location of the XML file which holds the mirrors
        private static string mirrorXMLFile = "http://download.brantje.com/xbian/mirrors.xml";

        // List with all the  USB devices & versions
        private List<uint> USBDevices;
        private List<version> versions;

        // Window for showing the progress
        private string progressStatus;

        // WebClient for downloading files
        private WebClient webClient;

        private version selectedVersion;
        private uint selectedUSBDevice;
        private bool operationInProgress;
        private restoreType restoreType;
        private bool operationCancelled;

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

            this.closeProgressMeter();
        }

        private void webClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (!operationCancelled)
            {
                // Until the the download is finished the name of the file is "temp", rename it to selected XBian version
                version ver = this.versions[comboBoxVersions.SelectedIndex];
                File.Move(@"temp", ver.getArchiveName());
                this.showProgressMeter("(2/2) Installing XBian " + this.selectedVersion.getVersionName() + " on your SD card");
                this.initRestore(this.selectedVersion.getArchiveName(), this.USBDevices[this.comboBoxSDcard.SelectedIndex]);
            }
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
            XmlNodeList XMLMD5 = xmlDoc.GetElementsByTagName("md5");

            this.versions = new List<version>();
            for (int i = 0; i < XMLverName.Count; i++)
            {
                string verName = XMLverName[i].InnerText;
                string[] locations = XMLlocations[i].InnerText.Split(';');
                string md5String = XMLMD5[i].InnerText;
                version ver = new version(verName, locations, md5String);
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
            this.comboBoxSDcard.Items.Clear();
            this.cbAdvancedSDCards.Items.Clear();
            this.USBDevices = new List<uint>();
            usbit32.ClearDevices();
            usbit32.FindDevices();
            usbit32.FindVolumes();
            uint usbdevice = usbit32.GetFirstDevice(true);          
            System.Text.StringBuilder deviceName = new System.Text.StringBuilder(100);
            System.Text.StringBuilder devicePath = new System.Text.StringBuilder(100);

            while ((usbdevice != 0))
            {
                ulong deviceSize = usbit32.GetDeviceSize(usbdevice) / 1000000;
                if (usbit32.GetDeviceSize(usbdevice) > 900000000)
                {
                    String deviceString = "(" + deviceSize + " MB) " + deviceName.ToString();
                    this.comboBoxSDcard.Items.Add(deviceString);
                    this.cbAdvancedSDCards.Items.Add(deviceString);
                    this.USBDevices.Add(usbdevice);
                }
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
            if (operationInProgress)
            {
                this.showProgressMeter("");
                InstallBtn.Enabled = false;
                btBackup.Enabled = false;
                btRestore.Enabled = false;
            }
            else
            {
                this.closeProgressMeter();
                InstallBtn.Enabled = true;
                btBackup.Enabled = true;
                btRestore.Enabled = true;
            }

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
            this.setProgress(Convert.ToInt16(e.ProgressPercentage));
        }

        private void InstallBtn_Click(object sender, System.EventArgs e)
        {
            this.operationCancelled = false;
            this.updateUI();
            DialogResult dialog = MessageBox.Show("This will remove all data on the selected SD card, continue?", "Warning!", MessageBoxButtons.YesNo);
            if (!operationInProgress)
            {
                if (dialog == DialogResult.Yes)
                {
                    this.restoreType = installer.restoreType.XBIAN;
                    // Checking if the file is already downloaded
                    if (System.IO.File.Exists(this.selectedVersion.getArchiveName()))
                    {
                        // Version has already been downloaded
                        this.initRestore(this.selectedVersion.getArchiveName(), this.USBDevices[this.comboBoxSDcard.SelectedIndex]);
                        this.showProgressMeter("Installing XBian " + this.selectedVersion.getVersionName() + " on your SD card");
                        this.operationInProgress = true;
                        this.updateUI();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("XBian " + this.selectedVersion.getVersionName() + " not yet downloaded. Do you want to download it now?", "XBian installer", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.webClient.DownloadFileAsync(new Uri(this.selectedVersion.getRandomMirror()), "temp");
                            this.showProgressMeter("(1/2) Downloading XBian " + this.selectedVersion.getVersionName());
                            this.operationInProgress = true;
                            this.updateUI();
                        }
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
            this.updateUI();
            this.selectedUSBDevice = usbDevice;
            this.progressTimer.Enabled = true;
            Thread t = new Thread(() => restore(imageLocation, usbDevice));
            t.Start();
        }

        private void restore(string imageLocation, uint usbDevice)
        {
            UInt32 RestoreErrorNum = 0;

            // Check MD5
            if (this.restoreType == restoreType.XBIAN)
            {
                FileStream fs = new FileStream(selectedVersion.getArchiveName(), FileMode.Open);
                if (!this.selectedVersion.checkMD5(fs))
                {
                    MessageBox.Show("MD5 Check failed, the downloaded XBian version may be spoofed, cancelling. Please contact us");
                    this.updateUI();
                    return;
                }

            }

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            try
            {
                usbit32.RestoreVolume(usbDevice, imageLocation, 0, true, true, false, ref RestoreErrorNum);
                stopwatch.Stop();
                
            }
            catch (AccessViolationException)
            {
                MessageBox.Show("Could not access the SD card (write protected?)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Invoke((MethodInvoker)delegate
            {
                this.progressTimer.Stop();
                this.closeProgressMeter();
            });

            if (stopwatch.ElapsedMilliseconds < 1000)
            {
                MessageBox.Show("Error, could not write to the SD card");
            }
            else
            {
                if (!operationCancelled)
                {
                    if (this.restoreType == restoreType.XBIAN) {
                        DialogResult result = MessageBox.Show("Do you want to setup a wireless network for XBian now?", "XBian setup", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            this.Invoke((MethodInvoker)delegate {
                                this.Enabled = false;
                                StringBuilder sb = new StringBuilder(200);
                                usbit32.GetVolumePath(this.selectedUSBDevice, sb, 200); 
                                openWLANSetup(sb.ToString());
                            });
                        }
                        else MessageBox.Show("Installation of XBian succesfully completed." + Environment.NewLine + "You may now unplug your SD card and plug it into your Raspberri Pi");
                    }
                    else
                        MessageBox.Show("Image succesfully restored." + Environment.NewLine + "You may now unplug your SD card and plug it into your Raspberri Pi");
                }
            }

            this.operationInProgress = false;

            this.Invoke((MethodInvoker)delegate
            {
                this.updateUI();
            });
 
        }

        private void openWLANSetup(string sdLocation)
        {
            wlanautomatic wa = new wlanautomatic(sdLocation, this);
            wa.Show();
        }

        private void installTimer_Tick(object sender, System.EventArgs e)
        {
            Int16 progress = Convert.ToInt16(usbit32.GetProgress(this.selectedUSBDevice));
            this.setProgress(progress);
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
            dialog.Title = "Select an img file";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
                this.tbRestoreImageLocation.Text = dialog.FileName;

            this.updateUI();
        }

        private void btRestore_Click(object sender, EventArgs e)
        {
            this.operationCancelled = false;
            if (!operationInProgress)
            {
                DialogResult dialogResult = MessageBox.Show("This will remove all data on the selected SD card, continue?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.operationInProgress = true;
                    this.showProgressMeter("Restoring the selected image to your SD card");
                    this.initRestore(this.tbRestoreImageLocation.Text, this.USBDevices[this.cbAdvancedSDCards.SelectedIndex]);
                    this.restoreType = restoreType.CUSTOM;
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
        
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "Image file|*.img";
                dialog.Title = "Save SD card backup";
                dialog.ShowDialog();
                this.selectedUSBDevice = this.USBDevices[this.cbAdvancedSDCards.SelectedIndex];

                this.restoreTimer.Start();
                this.showProgressMeter("Making a backup of your SD card");

                if (dialog.FileName != "")
                {
                    this.operationCancelled = false;
                    this.operationInProgress = true;
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
            this.setProgress(Convert.ToInt16(usbit32.GetProgress(this.selectedUSBDevice)));
        }

        private void btRefreshAdvanced_Click(object sender, EventArgs e)
        {
            this.listDevices();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listDevices();
        }

        private void closeProgressMeter()
        {
            this.Size = new Size(this.Width, this.convertFormHightAccordingDPI(402));
        }

        private int convertFormHightAccordingDPI(int height)
        {
            double multiplier;

            using (Graphics myGraphics = this.CreateGraphics())
            {
                switch (Convert.ToInt32(myGraphics.DpiY))
                {
                    case 120:
                        multiplier = 1.02;
                        break;
                    case 150:
                        multiplier = 1.05;
                        break;
                    default:
                        multiplier = 1;
                        break;
                }
            }

            return Convert.ToInt32(height * multiplier);
        }

        private void showProgressMeter(string text)
        {
            if (text != "")
            {
                this.progressStatus = text;
                this.progressBar.Value = 0;
            }

             this.Size = new Size(this.Width, this.convertFormHightAccordingDPI(489));
        }

        private void setProgress(Int16 percentage)
        {
            this.labelDownloadStatus.Text = this.progressStatus + "  -  " + percentage + "%";
            if (percentage <= 100)
            {
                this.progressBar.Value = percentage;
            }
            else
            {
                this.progressBar.Value = 100;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Info i = new Info();
            i.Show();
        }

        private void buttonCancelOperation_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel the current operation?", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.operationCancelled = true;
                if (this.webClient.IsBusy)
                {
                    this.webClient.CancelAsync();
                }

                this.restoreTimer.Stop();
                this.progressTimer.Stop();

                UInt32 CancelError = 0;
                foreach (uint i in this.USBDevices)
                {
                    usbit32.CancelOperation(i, ref CancelError); 
                }

                this.closeProgressMeter();
                this.operationInProgress = false;
            }

            this.updateUI();
        }


    }
}


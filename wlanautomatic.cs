using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NativeWifi;
using System.IO;

namespace installer
{
    public partial class wlanautomatic : Form
    {
        private enum MODE { AUTO, MANUAL };
        static List<string> supportedNetworks;
        private List<wnetwork> wNetworks;
        private List<string> cbNetworkProtectionSupportedNetworks;
        private bool openNetworkSelectedMan, openNetworkSelectedAuto;
        private string SDCardLocation;
        private main mainform;

        public wlanautomatic(string SDCardLocation, main mainform)
        {
            InitializeComponent();
            this.SDCardLocation = SDCardLocation;
            this.mainform = mainform;

            System.Windows.Forms.ToolTip tt = new ToolTip();
            string text = "Why is my network not listed here?" + Environment.NewLine + "- Wireless network is not in range"
                + Environment.NewLine + "- The wireless network is using an unsupported network protection," + Environment.NewLine +
                " we support Open (no protection, WEP, WPA/WPA2)" + Environment.NewLine + Environment.NewLine +
                "Please advance to the manual tab";
            tt.SetToolTip(this.lbNetworkNotListed, text);

            // Adding supported networks
            supportedNetworks = new List<string>(new string[] { "WEP","WPA","CCMP","NONE" }); 

            cbNetworkProtectionSupportedNetworks = new List<string>(new string[] {"WPA/WPA2", "WEP", "None" });
            foreach (string s in cbNetworkProtectionSupportedNetworks) cbNetworkProtection.Items.Add(s);
            cbNetworkProtection.SelectedIndex = 0;
            this.searchWirelessNetworks();
        }

        private void searchWirelessNetworks() 
        {
            cbWNetworks.Items.Clear();
            int wlanInterfaces = 0;
            wNetworks = new List<wnetwork>();
            WlanClient wclient = new WlanClient();
            foreach (WlanClient.WlanInterface wInterface in wclient.Interfaces)
            {
                wlanInterfaces++;
                Wlan.WlanAvailableNetwork[] networks = wInterface.GetAvailableNetworkList(0);

                foreach (Wlan.WlanAvailableNetwork network in networks)
                {
                    if (supportedNetworks.Contains(network.dot11DefaultCipherAlgorithm.ToString()))
                    {
                        Wlan.Dot11Ssid ssid = network.dot11Ssid;
                        string n = Encoding.ASCII.GetString(ssid.SSID, 0, (int)ssid.SSIDLength);
                        PROTECTION p = (PROTECTION) Enum.Parse(typeof(PROTECTION), network.dot11DefaultCipherAlgorithm.ToString());
                        wnetwork wnetwork = new wnetwork(n,p);
                        wnetwork.SIGNALQUALITY = network.wlanSignalQuality;
                        this.writeNetworkToLog(wnetwork);
                        this.wNetworks.Add(wnetwork);
                    }
                }
            }

            if (wlanInterfaces == 0)
            {
                tabPage1.Text = "Automatic (disabled, no wireless adapter found)";
                Control.ControlCollection ctc = tabPage1.Controls;
                foreach (Control c in ctc) c.Enabled = false;
                tabControl.SelectedIndex = 1;
                return;
            }
            else
            {
                // Sort list on signal quality
                wNetworks.Sort(
                    delegate(wnetwork n1, wnetwork n2)
                    {
                        return n2.SIGNALQUALITY.CompareTo(n1.SIGNALQUALITY);
                    }
                );
            }


            if (wNetworks.Count == 0)
            {
                cbWNetworks.Enabled = false;
                cbWNetworks.Items.Add("No wireless networks found");
                return;
            }

            cbWNetworks.Enabled = true;

            foreach (wnetwork n in this.wNetworks) cbWNetworks.Items.Add(n.SSID);
            cbWNetworks.SelectedIndex = 0;
        }

        private void done(MODE mode)
        {
            wnetwork network = null;
            if (mode == MODE.AUTO) {
                if (this.wNetworks.Count == 0)
                {
                    MessageBox.Show("No wireless network selected");
                    return;
                }
                if (tbPassword.Text != tbPasswordConfirm.Text)
                {
                    MessageBox.Show("Passwords do not match");
                    return;
                }
                wnetwork n = this.wNetworks[cbWNetworks.SelectedIndex];
                network = new wnetwork(n.SSID, tbPassword.Text, n.PROTECTION);
            }
            else if (mode == MODE.MANUAL)
            {
                if (tbManPassword.Text != tbManPassswordConfirm.Text)
                {
                    MessageBox.Show("Passwords do not match");
                    return;
                }
                if (tbManSSID.Text == string.Empty)
                {
                    MessageBox.Show("Please fill in a SSID");
                    return;
                }
                if (cbNetworkProtection.SelectedItem.ToString() != "None" && tbManPassword.Text == string.Empty)
                {
                    MessageBox.Show("Please fill in a password");
                    return;
                }

                PROTECTION p;
                if (cbNetworkProtection.SelectedIndex == 0) p = PROTECTION.WPA;
                else p = (PROTECTION)Enum.Parse(typeof(PROTECTION), cbNetworkProtection.SelectedItem.ToString());
                network = new wnetwork(tbManSSID.Text, tbManPassword.Text, p);
            }

            
            this.writeSettings(network);

            MessageBox.Show("Installation of XBian succesfully completed." + Environment.NewLine + "You may now unplug your SD card and plug it into your Raspberri Pi");
            this.Close();
        }

        private void setPasswordTextboxState(bool enabled, MODE mode)
        {
            if (mode == MODE.AUTO)
            {
                tbPassword.Enabled = enabled;
                tbPasswordConfirm.Enabled = enabled;
                if (enabled == true && openNetworkSelectedAuto == true)
                {
                    openNetworkSelectedAuto = false;
                    tbPassword.PasswordChar = '*';
                    tbPassword.Text = string.Empty;
                }
                else if (enabled == false && openNetworkSelectedAuto == false)
                {
                    openNetworkSelectedAuto = true;
                    tbPassword.PasswordChar = (char)0;
                    tbPassword.Text = "Disabled, open network selected";
                    tbPasswordConfirm.Text = string.Empty;
                }
            }
            else if (mode == MODE.MANUAL)
            {
                tbManPassswordConfirm.Enabled = enabled;
                tbManPassword.Enabled = enabled;
                if (enabled == true && openNetworkSelectedMan == true)
                {
                    openNetworkSelectedMan = false;
                    tbManPassword.PasswordChar = '*';
                    tbManPassword.Text = string.Empty;
                }
                else if (enabled == false && openNetworkSelectedAuto == false)
                {
                    openNetworkSelectedMan = true;
                    tbManPassword.PasswordChar = (char)0;
                    tbManPassword.Text = string.Empty;
                    tbManPassswordConfirm.Text = string.Empty;
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            this.searchWirelessNetworks();
        }

        private void btDone_Click(object sender, EventArgs e)
        {
            this.done(MODE.AUTO);
        }

        private void writeSettings(wnetwork network)
        {
            try
            {
                TextWriter file = new StreamWriter((this.SDCardLocation + "/cmdline.txt"),true);
                file.Write( " " + network.ToString());
                file.Flush();
                file.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("Could not write settings");
            }
        }

        private bool oldSettingsExsist()
        {
            if (File.Exists("Settings.conf")) return true;
            else return false;
        }

        private void writeNetworkToLog(wnetwork network)
        {
            string p;
            if (network.PROTECTION == PROTECTION.CCMP) p = "WPA2";
            else p = network.PROTECTION.ToString();

            string strLogText = "Found network; SSID:" + network.SSID + " Protection:" + p + " Signal quality: " + network.SIGNALQUALITY + "%";

            // Create a writer and open the file:
            StreamWriter log;

            if (!File.Exists("logfile.txt"))
            {
                log = new StreamWriter("logfile.txt");
            }
            else
            {
                log = File.AppendText("logfile.txt");
            }

            // Write to the file:
            log.WriteLine(strLogText);

            // Close the stream:
            log.Close();
        }

        private void btManDone_Click(object sender, EventArgs e)
        {
            this.done(MODE.MANUAL);
        }

        private void cbNetworkProtection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNetworkProtection.SelectedItem.ToString() == "None") this.setPasswordTextboxState(false, MODE.MANUAL);
            else this.setPasswordTextboxState(true, MODE.MANUAL);
        }

        private void cbWNetworks_SelectedIndexChanged(object sender, EventArgs e)
        {
            wnetwork network = wNetworks[cbWNetworks.SelectedIndex];
            if (network.PROTECTION == PROTECTION.None) this.setPasswordTextboxState(false, MODE.AUTO);
            else this.setPasswordTextboxState(true, MODE.AUTO);
        }

        private void wlanautomatic_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.mainform.Enabled = true;
        }
    }
}

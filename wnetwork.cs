﻿using System;
using System.Collections.Generic;
using System.Text;

namespace installer
{
    public enum PROTECTION { WPA, WEP, None, CCMP };

    class wnetwork
    {
        private string _ssid, _pass;
        private PROTECTION _protection;
        private uint _signalQuality;

        public string SSID { get { return this._ssid; } }
        public string PASS { get { return this._pass; } set { this._pass = value; } }
        public PROTECTION PROTECTION { get { return this._protection; } }
        public uint SIGNALQUALITY { get { return this._signalQuality; } set { this._signalQuality = value; } }

        public wnetwork(string ssid, string pass, PROTECTION protection) 
        {
            this._ssid = ssid;
            this._pass = pass;
            this._protection = protection;
        }

        public wnetwork(string ssid, PROTECTION protection)
        {
            this._ssid = ssid;
            this._pass = "";
            this._protection = protection;
        }

        public override string ToString()
        {
            string protection = this._protection.ToString();
            if (this._protection == PROTECTION.CCMP) protection = "WPA";
            else if (this._protection == PROTECTION.None) protection = "Open";

            string text = "network.wlan0.ssid=" + this.convertOctal(this._ssid) + " network.wlan0.security=" + protection;

            if (_protection != PROTECTION.None) text += Environment.NewLine + " network.wlan0.password=" + convertOctal(this._pass);

            return text;
        }

        private string convertOctal(string text)
        {
            text = text.Replace("=", "\\075");
            text = text.Replace(" ", "\\040");
            return text;
        }

    }
}

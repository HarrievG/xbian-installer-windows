using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace installer
{
    class version
    {
        private string versionName;
        private string[] locations;
        private string md5Version;

        public version(string versionName, string[] locations, string md5)
        {
            this.versionName = versionName;
            this.locations = locations;
            this.md5Version = md5;
        }

        public string getVersionName()
        {
            return this.versionName;
        }

        public bool checkMD5(FileStream file)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] retVal = md5.ComputeHash(file);
            file.Close();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < retVal.Length; i++)
            {
                sb.Append(retVal[i].ToString("x2"));
            }

            string MD5Input = sb.ToString();

            if (MD5Input.Equals(this.md5Version))
                return true;
            else
                return false;
        }

        public string getArchiveName()
        {
            string versionNameWithoutSpaces = versionName.Replace(" ", string.Empty);
            return versionNameWithoutSpaces + ".img.gz";
        }

        public string getRandomMirror()
        {
            Random random = new Random();
            int i = random.Next(0, this.locations.Length - 1);
            return this.locations[i];
        }
    }
}

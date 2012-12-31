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
        private string md5Version;
        private Random random;
        private List<String> locations;

        public version(string versionName, string[] locations, string md5)
        {
            this.versionName = versionName;
            this.locations = new List<string>();
            for (int i = 0; i < locations.Length; i++)
            {
                this.locations.Add(locations[i]);
            }
            
            this.md5Version = md5;
            random = new Random();
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
            return versionNameWithoutSpaces + ".tar.gz";
        }

        public string getRandomMirror()
        {
            int i = random.Next(this.locations.Count);
            string mirror = this.locations[i];
            Console.WriteLine(mirror);
            return mirror;
        }
    }
}

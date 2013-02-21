using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace installer
{
    public partial class Info : Form
    {
        private static string version = "BETA 1.1";
        public Info()
        {
            InitializeComponent();
            this.Text = "XBian installer " + version;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.xbian.org");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.alexpage.de/");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.gnu.org/licenses/gpl.html");
        }
    }
}

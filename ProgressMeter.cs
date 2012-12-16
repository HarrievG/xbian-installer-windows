using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace installer
{
    public partial class ProgressMeter : Form
    {

        const int MF_BYPOSITION = 0x400;

        [DllImport("User32")]

        private static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);

        [DllImport("User32")]

        private static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("User32")]

        private static extern int GetMenuItemCount(IntPtr hWnd);

        private string text;

        public ProgressMeter(string text)
        {
            InitializeComponent();
            IntPtr hMenu = GetSystemMenu(this.Handle, false);

            int menuItemCount = GetMenuItemCount(hMenu);

            RemoveMenu(hMenu, menuItemCount - 1, MF_BYPOSITION);
            this.text = text;
            this.label1.Text = text + " - 0%";
        }

        public void changeText(string text)
        {
            this.text = text; 
        }

        public void setProgress(int i)
        {
            this.progressBar1.Value = i;
            this.label1.Text = text + " - " + i + "%";
        }
    }
}

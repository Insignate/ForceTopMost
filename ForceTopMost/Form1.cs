using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ForceTopMost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshWindows()
        {
            cmbWindowsOpened.Items.Clear();
            IDictionary<IntPtr, string> windows =  WindowsOpened.GetOpenWindows();
            foreach (KeyValuePair<IntPtr, string> window in windows)
            {
                cmbWindowsOpened.Items.Add(window);
            }
            cmbWindowsOpened.SelectedIndex = 0;
        }

        private void btnRefreshWindows_Click(object sender, EventArgs e)
        {
            RefreshWindows();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshWindows();
        }

        private void btnForceTopMost_Click(object sender, EventArgs e)
        {
            TopMostHandler tmh = new TopMostHandler();
            KeyValuePair<IntPtr, string> window = (KeyValuePair<IntPtr, string>)cmbWindowsOpened.SelectedItem;
            tmh.SetTopMost(window.Key);
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            TopMostHandler tmh = new TopMostHandler();
            KeyValuePair<IntPtr, string> window = (KeyValuePair<IntPtr, string>)cmbWindowsOpened.SelectedItem;
            tmh.RemoveTopMost(window.Key);
        }
    }
}

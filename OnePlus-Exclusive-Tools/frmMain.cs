using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegawMOD.Android;

namespace OnePlus_Exclusive_Tools
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        AndroidController android;
        Device device;

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Usually, you want to load this at startup, may take up to 5 seconds to initialize/set up resources/start server
            android = AndroidController.Instance;
        }

        private void btnCheckADB_Click(object sender, EventArgs e)
        {
            string serial;

            //Always call UpdateDeviceList() before using AndroidController on devices to get the most updated list
            android.UpdateDeviceList();

            if (android.HasConnectedDevices)
            {
                serial = android.ConnectedDevices[0];
                device = android.GetConnectedDevice(serial);
                this.label1.Text = device.SerialNumber;
                AdbCommand adbCmd = Adb.FormAdbCommand(device, "-s 1b3e1bca shell getprop ro.product.model");
                this.label2.Text = adbCmd.ToString();
            }
            else
            {
                this.label1.Text = "Error - No Devices Connected";
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ALWAYS remember to call this when you're done with AndroidController.  It removes used resources
            android.Dispose();
        }
    }
}

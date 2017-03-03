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
                lblAdb.ForeColor = Color.Green;
                this.lblAdb.Text = "ADB Device Found";
                btnReboot.Enabled = true;
            }
            else
            {
                lblAdb.ForeColor = Color.Red;
                this.lblAdb.Text = "No ADB Device Connected";
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ALWAYS remember to call this when you're done with AndroidController.  It removes used resources
            android.Dispose();
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "CMD.exe";
            startInfo.Arguments = "/c adb reboot-bootloader";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serial;

            //Always call UpdateDeviceList() before using AndroidController on devices to get the most updated list
            android.UpdateDeviceList();

            if (android.HasConnectedDevices)
            {
                serial = android.ConnectedDevices[0];
                device = android.GetConnectedDevice(serial);
                lblFastboot.ForeColor = Color.Green;
                this.lblFastboot.Text = "Fastboot Device Found";
            }
            else
            {
                lblFastboot.ForeColor = Color.Red;
                this.lblFastboot.Text = "No Fastboot Device Connected";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"cmd.exe", @"/k fastboot oem device-info");
        }

    }
}
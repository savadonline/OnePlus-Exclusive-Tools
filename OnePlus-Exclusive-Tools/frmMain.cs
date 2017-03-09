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
using System.Net;

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
                lblStatus.ForeColor = Color.Green;
                this.lblStatus.Text = "ADB Device Found";
                btnReboot.Enabled = true;
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                this.lblStatus.Text = "No ADB Device Connected";
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

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "CMD.exe";
            startInfo.Arguments = "/c fastboot oem unlock";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = "CMD.exe";
            startInfo.Arguments = "/c fastboot oem lock";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }

        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"cmd.exe", @"/k fastboot oem device-info");
        }

        private void btnTWRP_Click(object sender, EventArgs e)
        {
            btnTWRP.Enabled = false;
            string remoteUri = "http://www.oneplusexclusive.com/optools/";
            string fileName = "setup.exe", myStringWebResource = null;
            // Create a new WebClient instance.
            WebClient client = new WebClient();
            // Concatenate the domain with the Web resource filename.
            myStringWebResource = remoteUri + fileName;
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Downloads");
            client.DownloadFileAsync(new Uri(myStringWebResource), Application.StartupPath + "/Downloads/" + "setup.exe");
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            progressBar1.Value = (int)e.BytesReceived / 100;
        }

        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            btnTWRP.Enabled = true;
        }

        private void btnCheckFastboot_Click(object sender, EventArgs e)
        {
            android.Dispose();

            string serial;

            //Always call UpdateDeviceList() before using AndroidController on devices to get the most updated list
            android.UpdateDeviceList();

            if (android.HasConnectedDevices)
            {
                serial = android.ConnectedDevices[0];
                device = android.GetConnectedDevice(serial);
                lblStatus.ForeColor = Color.Green;
                this.lblStatus.Text = "Fastboot Device Found";
            }
            else
            {
                lblStatus.ForeColor = Color.Red;
                this.lblStatus.Text = "No Fastboot Device Connected";
            }
        }
    }
}
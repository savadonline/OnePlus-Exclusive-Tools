namespace OnePlus_Exclusive_Tools
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCheckADB = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnReboot = new System.Windows.Forms.Button();
            this.btnCheckStatus = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDriver = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCheckFastboot = new System.Windows.Forms.Button();
            this.btnReboot1 = new System.Windows.Forms.Button();
            this.btnTWRP = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckADB
            // 
            this.btnCheckADB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckADB.Location = new System.Drawing.Point(12, 90);
            this.btnCheckADB.Name = "btnCheckADB";
            this.btnCheckADB.Size = new System.Drawing.Size(189, 55);
            this.btnCheckADB.TabIndex = 2;
            this.btnCheckADB.Text = "Verify if the ADB Device is Recognized";
            this.btnCheckADB.UseVisualStyleBackColor = true;
            this.btnCheckADB.Click += new System.EventHandler(this.btnCheckADB_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(2, 3);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(148, 14);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "ADB Status : Unknown";
            // 
            // btnReboot
            // 
            this.btnReboot.Enabled = false;
            this.btnReboot.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReboot.Location = new System.Drawing.Point(12, 160);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(189, 55);
            this.btnReboot.TabIndex = 4;
            this.btnReboot.Text = "Reboot to Bootloader";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // btnCheckStatus
            // 
            this.btnCheckStatus.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckStatus.Location = new System.Drawing.Point(12, 19);
            this.btnCheckStatus.Name = "btnCheckStatus";
            this.btnCheckStatus.Size = new System.Drawing.Size(188, 55);
            this.btnCheckStatus.TabIndex = 8;
            this.btnCheckStatus.Text = "Check Bootloader Status";
            this.btnCheckStatus.UseVisualStyleBackColor = true;
            this.btnCheckStatus.Click += new System.EventHandler(this.btnCheckStatus_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Location = new System.Drawing.Point(463, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 23);
            this.panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDriver);
            this.groupBox1.Controls.Add(this.btnCheckADB);
            this.groupBox1.Controls.Add(this.btnReboot);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 230);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Drivers and ADB";
            // 
            // btnDriver
            // 
            this.btnDriver.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDriver.Location = new System.Drawing.Point(12, 19);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(189, 55);
            this.btnDriver.TabIndex = 0;
            this.btnDriver.Text = "Install Driver";
            this.btnDriver.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLock);
            this.groupBox2.Controls.Add(this.btnUnlock);
            this.groupBox2.Controls.Add(this.btnCheckStatus);
            this.groupBox2.Location = new System.Drawing.Point(240, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 229);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bootloader";
            // 
            // btnLock
            // 
            this.btnLock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLock.Location = new System.Drawing.Point(12, 159);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(189, 55);
            this.btnLock.TabIndex = 10;
            this.btnLock.Text = "Lock Fastboot";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // btnUnlock
            // 
            this.btnUnlock.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlock.Location = new System.Drawing.Point(11, 89);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(189, 55);
            this.btnUnlock.TabIndex = 9;
            this.btnUnlock.Text = "Unlock Fastboot";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCheckFastboot);
            this.groupBox3.Controls.Add(this.btnReboot1);
            this.groupBox3.Controls.Add(this.btnTWRP);
            this.groupBox3.Location = new System.Drawing.Point(465, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(213, 229);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Recovery";
            // 
            // btnCheckFastboot
            // 
            this.btnCheckFastboot.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckFastboot.Location = new System.Drawing.Point(11, 89);
            this.btnCheckFastboot.Name = "btnCheckFastboot";
            this.btnCheckFastboot.Size = new System.Drawing.Size(189, 55);
            this.btnCheckFastboot.TabIndex = 9;
            this.btnCheckFastboot.Text = "Verify if the Fastboot Mode is Recognized";
            this.btnCheckFastboot.UseVisualStyleBackColor = true;
            this.btnCheckFastboot.Click += new System.EventHandler(this.btnCheckFastboot_Click);
            // 
            // btnReboot1
            // 
            this.btnReboot1.Enabled = false;
            this.btnReboot1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReboot1.Location = new System.Drawing.Point(11, 19);
            this.btnReboot1.Name = "btnReboot1";
            this.btnReboot1.Size = new System.Drawing.Size(189, 55);
            this.btnReboot1.TabIndex = 8;
            this.btnReboot1.Text = "Reboot to Bootloader";
            this.btnReboot1.UseVisualStyleBackColor = true;
            // 
            // btnTWRP
            // 
            this.btnTWRP.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTWRP.Location = new System.Drawing.Point(11, 159);
            this.btnTWRP.Name = "btnTWRP";
            this.btnTWRP.Size = new System.Drawing.Size(189, 55);
            this.btnTWRP.TabIndex = 6;
            this.btnTWRP.Text = "Flash TWRP";
            this.btnTWRP.UseVisualStyleBackColor = true;
            this.btnTWRP.Click += new System.EventHandler(this.btnTWRP_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 299);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(666, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Location = new System.Drawing.Point(12, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(665, 49);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Device :";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "OnePlus 1",
            "OnePlus 2",
            "OnePlus X",
            "OnePlus 3",
            "OnePlus 3T"});
            this.comboBox1.Location = new System.Drawing.Point(228, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 26);
            this.comboBox1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 334);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnePlus Exclusive Tools";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckADB;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.Button btnCheckStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDriver;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTWRP;
        private System.Windows.Forms.Button btnReboot1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnCheckFastboot;
    }
}
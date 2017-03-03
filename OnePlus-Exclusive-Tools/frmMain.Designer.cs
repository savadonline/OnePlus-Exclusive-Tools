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
            this.lblAdb = new System.Windows.Forms.Label();
            this.lblFastboot = new System.Windows.Forms.Label();
            this.btnReboot = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCheckADB
            // 
            this.btnCheckADB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckADB.Location = new System.Drawing.Point(12, 12);
            this.btnCheckADB.Name = "btnCheckADB";
            this.btnCheckADB.Size = new System.Drawing.Size(189, 55);
            this.btnCheckADB.TabIndex = 0;
            this.btnCheckADB.Text = "1. Check ADB Status";
            this.btnCheckADB.UseVisualStyleBackColor = true;
            this.btnCheckADB.Click += new System.EventHandler(this.btnCheckADB_Click);
            // 
            // lblAdb
            // 
            this.lblAdb.AutoSize = true;
            this.lblAdb.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdb.Location = new System.Drawing.Point(2, 3);
            this.lblAdb.Name = "lblAdb";
            this.lblAdb.Size = new System.Drawing.Size(148, 14);
            this.lblAdb.TabIndex = 1;
            this.lblAdb.Text = "ADB Status : Unknown";
            // 
            // lblFastboot
            // 
            this.lblFastboot.AutoSize = true;
            this.lblFastboot.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFastboot.Location = new System.Drawing.Point(2, 3);
            this.lblFastboot.Name = "lblFastboot";
            this.lblFastboot.Size = new System.Drawing.Size(177, 14);
            this.lblFastboot.TabIndex = 2;
            this.lblFastboot.Text = "Fastboot Status : Unknown";
            // 
            // btnReboot
            // 
            this.btnReboot.Enabled = false;
            this.btnReboot.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReboot.Location = new System.Drawing.Point(12, 111);
            this.btnReboot.Name = "btnReboot";
            this.btnReboot.Size = new System.Drawing.Size(189, 55);
            this.btnReboot.TabIndex = 4;
            this.btnReboot.Text = "2. Reboot to Bootloader";
            this.btnReboot.UseVisualStyleBackColor = true;
            this.btnReboot.Click += new System.EventHandler(this.btnReboot_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "3. Verify Fastboot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(13, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "4. Check Device Status";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblAdb);
            this.panel1.Location = new System.Drawing.Point(13, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 23);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblFastboot);
            this.panel2.Location = new System.Drawing.Point(12, 242);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 23);
            this.panel2.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 352);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReboot);
            this.Controls.Add(this.btnCheckADB);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnePlus Exclusive Tools";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCheckADB;
        private System.Windows.Forms.Label lblAdb;
        private System.Windows.Forms.Label lblFastboot;
        private System.Windows.Forms.Button btnReboot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
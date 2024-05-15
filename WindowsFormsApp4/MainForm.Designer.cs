namespace WindowsFormsApp4
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DonorLBL = new System.Windows.Forms.Label();
            this.PatientLBL = new System.Windows.Forms.Label();
            this.ViewDonorsLBL = new System.Windows.Forms.Label();
            this.ViewPatientsLBL = new System.Windows.Forms.Label();
            this.BloodStockLBL = new System.Windows.Forms.Label();
            this.BloodTransferLBL = new System.Windows.Forms.Label();
            this.DashboardLBL = new System.Windows.Forms.Label();
            this.LogoutLBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DonateLBL = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(273, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 34);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(348, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blood Bank Managment System ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(597, 151);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(472, 358);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DonorLBL
            // 
            this.DonorLBL.AutoSize = true;
            this.DonorLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorLBL.ForeColor = System.Drawing.Color.White;
            this.DonorLBL.Location = new System.Drawing.Point(52, 68);
            this.DonorLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DonorLBL.Name = "DonorLBL";
            this.DonorLBL.Size = new System.Drawing.Size(102, 41);
            this.DonorLBL.TabIndex = 2;
            this.DonorLBL.Text = "Donor";
            this.DonorLBL.Click += new System.EventHandler(this.DonorLBL_Click);
            // 
            // PatientLBL
            // 
            this.PatientLBL.AutoSize = true;
            this.PatientLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientLBL.ForeColor = System.Drawing.Color.White;
            this.PatientLBL.Location = new System.Drawing.Point(44, 283);
            this.PatientLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientLBL.Name = "PatientLBL";
            this.PatientLBL.Size = new System.Drawing.Size(109, 41);
            this.PatientLBL.TabIndex = 4;
            this.PatientLBL.Text = "Patient";
            this.PatientLBL.Click += new System.EventHandler(this.PatientLBL_Click);
            // 
            // ViewDonorsLBL
            // 
            this.ViewDonorsLBL.AutoSize = true;
            this.ViewDonorsLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDonorsLBL.ForeColor = System.Drawing.Color.White;
            this.ViewDonorsLBL.Location = new System.Drawing.Point(35, 192);
            this.ViewDonorsLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewDonorsLBL.Name = "ViewDonorsLBL";
            this.ViewDonorsLBL.Size = new System.Drawing.Size(187, 41);
            this.ViewDonorsLBL.TabIndex = 6;
            this.ViewDonorsLBL.Text = "View Donors";
            this.ViewDonorsLBL.Click += new System.EventHandler(this.ViewDonorsLBL_Click);
            // 
            // ViewPatientsLBL
            // 
            this.ViewPatientsLBL.AutoSize = true;
            this.ViewPatientsLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPatientsLBL.ForeColor = System.Drawing.Color.White;
            this.ViewPatientsLBL.Location = new System.Drawing.Point(35, 359);
            this.ViewPatientsLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewPatientsLBL.Name = "ViewPatientsLBL";
            this.ViewPatientsLBL.Size = new System.Drawing.Size(194, 41);
            this.ViewPatientsLBL.TabIndex = 8;
            this.ViewPatientsLBL.Text = "View Patients";
            this.ViewPatientsLBL.Click += new System.EventHandler(this.ViewPAtientsLBL_Click);
            // 
            // BloodStockLBL
            // 
            this.BloodStockLBL.AutoSize = true;
            this.BloodStockLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodStockLBL.ForeColor = System.Drawing.Color.White;
            this.BloodStockLBL.Location = new System.Drawing.Point(35, 434);
            this.BloodStockLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BloodStockLBL.Name = "BloodStockLBL";
            this.BloodStockLBL.Size = new System.Drawing.Size(176, 41);
            this.BloodStockLBL.TabIndex = 10;
            this.BloodStockLBL.Text = "Blood Stock";
            this.BloodStockLBL.Click += new System.EventHandler(this.BloodStockLBL_Click);
            // 
            // BloodTransferLBL
            // 
            this.BloodTransferLBL.AutoSize = true;
            this.BloodTransferLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodTransferLBL.ForeColor = System.Drawing.Color.White;
            this.BloodTransferLBL.Location = new System.Drawing.Point(35, 511);
            this.BloodTransferLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BloodTransferLBL.Name = "BloodTransferLBL";
            this.BloodTransferLBL.Size = new System.Drawing.Size(207, 41);
            this.BloodTransferLBL.TabIndex = 12;
            this.BloodTransferLBL.Text = "Blood Transfer";
            this.BloodTransferLBL.Click += new System.EventHandler(this.BloodTransferLBL_Click);
            // 
            // DashboardLBL
            // 
            this.DashboardLBL.AutoSize = true;
            this.DashboardLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLBL.ForeColor = System.Drawing.Color.White;
            this.DashboardLBL.Location = new System.Drawing.Point(35, 587);
            this.DashboardLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DashboardLBL.Name = "DashboardLBL";
            this.DashboardLBL.Size = new System.Drawing.Size(162, 41);
            this.DashboardLBL.TabIndex = 14;
            this.DashboardLBL.Text = "DashBoard";
            this.DashboardLBL.Click += new System.EventHandler(this.DashboardLBL_Click);
            // 
            // LogoutLBL
            // 
            this.LogoutLBL.AutoSize = true;
            this.LogoutLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLBL.ForeColor = System.Drawing.Color.White;
            this.LogoutLBL.Location = new System.Drawing.Point(52, 658);
            this.LogoutLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoutLBL.Name = "LogoutLBL";
            this.LogoutLBL.Size = new System.Drawing.Size(113, 41);
            this.LogoutLBL.TabIndex = 15;
            this.LogoutLBL.Text = "Logout";
            this.LogoutLBL.Click += new System.EventHandler(this.LogoutLBL_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.DonateLBL);
            this.panel1.Controls.Add(this.LogoutLBL);
            this.panel1.Controls.Add(this.DashboardLBL);
            this.panel1.Controls.Add(this.BloodTransferLBL);
            this.panel1.Controls.Add(this.BloodStockLBL);
            this.panel1.Controls.Add(this.ViewPatientsLBL);
            this.panel1.Controls.Add(this.ViewDonorsLBL);
            this.panel1.Controls.Add(this.PatientLBL);
            this.panel1.Controls.Add(this.DonorLBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 709);
            this.panel1.TabIndex = 0;
            // 
            // DonateLBL
            // 
            this.DonateLBL.AutoSize = true;
            this.DonateLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonateLBL.ForeColor = System.Drawing.Color.White;
            this.DonateLBL.Location = new System.Drawing.Point(44, 129);
            this.DonateLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DonateLBL.Name = "DonateLBL";
            this.DonateLBL.Size = new System.Drawing.Size(115, 41);
            this.DonateLBL.TabIndex = 17;
            this.DonateLBL.Text = "Donate";
            this.DonateLBL.Click += new System.EventHandler(this.DonateLBL_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1399, 709);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DonorLBL;
        private System.Windows.Forms.Label PatientLBL;
        private System.Windows.Forms.Label ViewDonorsLBL;
        private System.Windows.Forms.Label ViewPatientsLBL;
        private System.Windows.Forms.Label BloodStockLBL;
        private System.Windows.Forms.Label BloodTransferLBL;
        private System.Windows.Forms.Label DashboardLBL;
        private System.Windows.Forms.Label LogoutLBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label DonateLBL;
    }
}
namespace WindowsFormsApp4
{
    partial class DonateBlood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonateBlood));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BloodLogoPic = new System.Windows.Forms.PictureBox();
            this.DonateBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.NameLBL = new System.Windows.Forms.Label();
            this.DNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DonateLBL = new System.Windows.Forms.Label();
            this.LogoutLBL = new System.Windows.Forms.Label();
            this.DashboardLBL = new System.Windows.Forms.Label();
            this.BloodTransferLBL = new System.Windows.Forms.Label();
            this.BloodStockLBL = new System.Windows.Forms.Label();
            this.ViewPatientsLBL = new System.Windows.Forms.Label();
            this.ViewDonorsLBL = new System.Windows.Forms.Label();
            this.PatientLBL = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DonorLBL = new System.Windows.Forms.Label();
            this.BGroupTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BloodGroupLBL = new System.Windows.Forms.Label();
            this.DonorsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.PDonorsListLBL = new System.Windows.Forms.Label();
            this.PBloodStockLBL = new System.Windows.Forms.Label();
            this.BloodStockDGV = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BloodLogoPic)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodStockDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BloodLogoPic
            // 
            this.BloodLogoPic.Image = ((System.Drawing.Image)(resources.GetObject("BloodLogoPic.Image")));
            this.BloodLogoPic.Location = new System.Drawing.Point(896, 38);
            this.BloodLogoPic.Margin = new System.Windows.Forms.Padding(4);
            this.BloodLogoPic.Name = "BloodLogoPic";
            this.BloodLogoPic.Size = new System.Drawing.Size(48, 44);
            this.BloodLogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BloodLogoPic.TabIndex = 35;
            this.BloodLogoPic.TabStop = false;
            // 
            // DonateBTN
            // 
            this.DonateBTN.ActiveBorderThickness = 1;
            this.DonateBTN.ActiveCornerRadius = 20;
            this.DonateBTN.ActiveFillColor = System.Drawing.Color.Crimson;
            this.DonateBTN.ActiveForecolor = System.Drawing.Color.White;
            this.DonateBTN.ActiveLineColor = System.Drawing.Color.Crimson;
            this.DonateBTN.BackColor = System.Drawing.Color.White;
            this.DonateBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DonateBTN.BackgroundImage")));
            this.DonateBTN.ButtonText = "Donate";
            this.DonateBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DonateBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonateBTN.ForeColor = System.Drawing.Color.SeaGreen;
            this.DonateBTN.IdleBorderThickness = 1;
            this.DonateBTN.IdleCornerRadius = 20;
            this.DonateBTN.IdleFillColor = System.Drawing.Color.Red;
            this.DonateBTN.IdleForecolor = System.Drawing.Color.White;
            this.DonateBTN.IdleLineColor = System.Drawing.Color.Red;
            this.DonateBTN.Location = new System.Drawing.Point(671, 639);
            this.DonateBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DonateBTN.Name = "DonateBTN";
            this.DonateBTN.Size = new System.Drawing.Size(221, 52);
            this.DonateBTN.TabIndex = 34;
            this.DonateBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DonateBTN.Click += new System.EventHandler(this.DonateBTN_Click);
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLBL.ForeColor = System.Drawing.Color.Red;
            this.NameLBL.Location = new System.Drawing.Point(503, 559);
            this.NameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(78, 32);
            this.NameLBL.TabIndex = 23;
            this.NameLBL.Text = "Name";
            // 
            // DNameTb
            // 
            this.DNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DNameTb.Enabled = false;
            this.DNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNameTb.ForeColor = System.Drawing.Color.Red;
            this.DNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.DNameTb.HintText = "";
            this.DNameTb.isPassword = false;
            this.DNameTb.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.DNameTb.LineIdleColor = System.Drawing.Color.MediumVioletRed;
            this.DNameTb.LineMouseHoverColor = System.Drawing.Color.DarkMagenta;
            this.DNameTb.LineThickness = 3;
            this.DNameTb.Location = new System.Drawing.Point(509, 578);
            this.DNameTb.Margin = new System.Windows.Forms.Padding(5);
            this.DNameTb.Name = "DNameTb";
            this.DNameTb.Size = new System.Drawing.Size(252, 44);
            this.DNameTb.TabIndex = 22;
            this.DNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(765, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 46);
            this.label10.TabIndex = 21;
            this.label10.Text = "Donate";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(273, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1158, 34);
            this.panel2.TabIndex = 20;
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
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.DonorLBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 753);
            this.panel1.TabIndex = 19;
            // 
            // DonateLBL
            // 
            this.DonateLBL.AutoSize = true;
            this.DonateLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonateLBL.ForeColor = System.Drawing.Color.White;
            this.DonateLBL.Location = new System.Drawing.Point(51, 182);
            this.DonateLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DonateLBL.Name = "DonateLBL";
            this.DonateLBL.Size = new System.Drawing.Size(115, 41);
            this.DonateLBL.TabIndex = 16;
            this.DonateLBL.Text = "Donate";
            // 
            // LogoutLBL
            // 
            this.LogoutLBL.AutoSize = true;
            this.LogoutLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutLBL.ForeColor = System.Drawing.Color.White;
            this.LogoutLBL.Location = new System.Drawing.Point(64, 658);
            this.LogoutLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LogoutLBL.Name = "LogoutLBL";
            this.LogoutLBL.Size = new System.Drawing.Size(113, 41);
            this.LogoutLBL.TabIndex = 15;
            this.LogoutLBL.Text = "Logout";
            this.LogoutLBL.Click += new System.EventHandler(this.LogoutLBL_Click);
            // 
            // DashboardLBL
            // 
            this.DashboardLBL.AutoSize = true;
            this.DashboardLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardLBL.ForeColor = System.Drawing.Color.White;
            this.DashboardLBL.Location = new System.Drawing.Point(47, 576);
            this.DashboardLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DashboardLBL.Name = "DashboardLBL";
            this.DashboardLBL.Size = new System.Drawing.Size(162, 41);
            this.DashboardLBL.TabIndex = 14;
            this.DashboardLBL.Text = "DashBoard";
            this.DashboardLBL.Click += new System.EventHandler(this.DashboardLBL_Click);
            // 
            // BloodTransferLBL
            // 
            this.BloodTransferLBL.AutoSize = true;
            this.BloodTransferLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodTransferLBL.ForeColor = System.Drawing.Color.White;
            this.BloodTransferLBL.Location = new System.Drawing.Point(35, 498);
            this.BloodTransferLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BloodTransferLBL.Name = "BloodTransferLBL";
            this.BloodTransferLBL.Size = new System.Drawing.Size(207, 41);
            this.BloodTransferLBL.TabIndex = 12;
            this.BloodTransferLBL.Text = "Blood Transfer";
            this.BloodTransferLBL.Click += new System.EventHandler(this.BloodTransferLBL_Click);
            // 
            // BloodStockLBL
            // 
            this.BloodStockLBL.AutoSize = true;
            this.BloodStockLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodStockLBL.ForeColor = System.Drawing.Color.White;
            this.BloodStockLBL.Location = new System.Drawing.Point(41, 433);
            this.BloodStockLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BloodStockLBL.Name = "BloodStockLBL";
            this.BloodStockLBL.Size = new System.Drawing.Size(176, 41);
            this.BloodStockLBL.TabIndex = 10;
            this.BloodStockLBL.Text = "Blood Stock";
            this.BloodStockLBL.Click += new System.EventHandler(this.BloodStockLBL_Click);
            // 
            // ViewPatientsLBL
            // 
            this.ViewPatientsLBL.AutoSize = true;
            this.ViewPatientsLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPatientsLBL.ForeColor = System.Drawing.Color.White;
            this.ViewPatientsLBL.Location = new System.Drawing.Point(35, 367);
            this.ViewPatientsLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewPatientsLBL.Name = "ViewPatientsLBL";
            this.ViewPatientsLBL.Size = new System.Drawing.Size(194, 41);
            this.ViewPatientsLBL.TabIndex = 8;
            this.ViewPatientsLBL.Text = "View Patients";
            this.ViewPatientsLBL.Click += new System.EventHandler(this.ViewPatientsLBL_Click);
            // 
            // ViewDonorsLBL
            // 
            this.ViewDonorsLBL.AutoSize = true;
            this.ViewDonorsLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDonorsLBL.ForeColor = System.Drawing.Color.White;
            this.ViewDonorsLBL.Location = new System.Drawing.Point(29, 252);
            this.ViewDonorsLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewDonorsLBL.Name = "ViewDonorsLBL";
            this.ViewDonorsLBL.Size = new System.Drawing.Size(187, 41);
            this.ViewDonorsLBL.TabIndex = 6;
            this.ViewDonorsLBL.Text = "View Donors";
            this.ViewDonorsLBL.Click += new System.EventHandler(this.ViewDonorsLBL_Click);
            // 
            // PatientLBL
            // 
            this.PatientLBL.AutoSize = true;
            this.PatientLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientLBL.ForeColor = System.Drawing.Color.White;
            this.PatientLBL.Location = new System.Drawing.Point(51, 303);
            this.PatientLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatientLBL.Name = "PatientLBL";
            this.PatientLBL.Size = new System.Drawing.Size(109, 41);
            this.PatientLBL.TabIndex = 4;
            this.PatientLBL.Text = "Patient";
            this.PatientLBL.Click += new System.EventHandler(this.PatientLBL_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.Location = new System.Drawing.Point(29, 182);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 55);
            this.panel3.TabIndex = 2;
            // 
            // DonorLBL
            // 
            this.DonorLBL.AutoSize = true;
            this.DonorLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorLBL.ForeColor = System.Drawing.Color.White;
            this.DonorLBL.Location = new System.Drawing.Point(35, 121);
            this.DonorLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DonorLBL.Name = "DonorLBL";
            this.DonorLBL.Size = new System.Drawing.Size(102, 41);
            this.DonorLBL.TabIndex = 2;
            this.DonorLBL.Text = "Donor";
            this.DonorLBL.Click += new System.EventHandler(this.DonorLBL_Click);
            // 
            // BGroupTb
            // 
            this.BGroupTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BGroupTb.Enabled = false;
            this.BGroupTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BGroupTb.ForeColor = System.Drawing.Color.Red;
            this.BGroupTb.HintForeColor = System.Drawing.Color.Empty;
            this.BGroupTb.HintText = "";
            this.BGroupTb.isPassword = false;
            this.BGroupTb.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.BGroupTb.LineIdleColor = System.Drawing.Color.MediumVioletRed;
            this.BGroupTb.LineMouseHoverColor = System.Drawing.Color.DarkMagenta;
            this.BGroupTb.LineThickness = 3;
            this.BGroupTb.Location = new System.Drawing.Point(852, 575);
            this.BGroupTb.Margin = new System.Windows.Forms.Padding(5);
            this.BGroupTb.Name = "BGroupTb";
            this.BGroupTb.Size = new System.Drawing.Size(252, 44);
            this.BGroupTb.TabIndex = 26;
            this.BGroupTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BloodGroupLBL
            // 
            this.BloodGroupLBL.AutoSize = true;
            this.BloodGroupLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroupLBL.ForeColor = System.Drawing.Color.Red;
            this.BloodGroupLBL.Location = new System.Drawing.Point(845, 559);
            this.BloodGroupLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BloodGroupLBL.Name = "BloodGroupLBL";
            this.BloodGroupLBL.Size = new System.Drawing.Size(149, 32);
            this.BloodGroupLBL.TabIndex = 32;
            this.BloodGroupLBL.Text = "Blood Group";
            // 
            // DonorsDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DonorsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DonorsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DonorsDGV.BackgroundColor = System.Drawing.Color.White;
            this.DonorsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DonorsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DonorsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DonorsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DonorsDGV.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DonorsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DonorsDGV.EnableHeadersVisualStyles = false;
            this.DonorsDGV.GridColor = System.Drawing.Color.Red;
            this.DonorsDGV.Location = new System.Drawing.Point(744, 137);
            this.DonorsDGV.Margin = new System.Windows.Forms.Padding(4);
            this.DonorsDGV.Name = "DonorsDGV";
            this.DonorsDGV.RowHeadersVisible = false;
            this.DonorsDGV.RowHeadersWidth = 51;
            this.DonorsDGV.RowTemplate.Height = 25;
            this.DonorsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DonorsDGV.Size = new System.Drawing.Size(647, 303);
            this.DonorsDGV.TabIndex = 36;
            this.DonorsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DonorsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DonorsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DonorsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DonorsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DonorsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DonorsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DonorsDGV.ThemeStyle.GridColor = System.Drawing.Color.Red;
            this.DonorsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red;
            this.DonorsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DonorsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DonorsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DonorsDGV.ThemeStyle.HeaderStyle.Height = 29;
            this.DonorsDGV.ThemeStyle.ReadOnly = false;
            this.DonorsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DonorsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DonorsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DonorsDGV.ThemeStyle.RowsStyle.Height = 25;
            this.DonorsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.DonorsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DonorsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DonorsDGV_CellContentClick);
            // 
            // PDonorsListLBL
            // 
            this.PDonorsListLBL.AutoSize = true;
            this.PDonorsListLBL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDonorsListLBL.ForeColor = System.Drawing.Color.Red;
            this.PDonorsListLBL.Location = new System.Drawing.Point(980, 87);
            this.PDonorsListLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PDonorsListLBL.Name = "PDonorsListLBL";
            this.PDonorsListLBL.Size = new System.Drawing.Size(188, 46);
            this.PDonorsListLBL.TabIndex = 37;
            this.PDonorsListLBL.Text = "Donors List";
            // 
            // PBloodStockLBL
            // 
            this.PBloodStockLBL.AutoSize = true;
            this.PBloodStockLBL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBloodStockLBL.ForeColor = System.Drawing.Color.Red;
            this.PBloodStockLBL.Location = new System.Drawing.Point(385, 87);
            this.PBloodStockLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PBloodStockLBL.Name = "PBloodStockLBL";
            this.PBloodStockLBL.Size = new System.Drawing.Size(198, 46);
            this.PBloodStockLBL.TabIndex = 39;
            this.PBloodStockLBL.Text = "Blood Stock";
            // 
            // BloodStockDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.BloodStockDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BloodStockDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BloodStockDGV.BackgroundColor = System.Drawing.Color.White;
            this.BloodStockDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BloodStockDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BloodStockDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BloodStockDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BloodStockDGV.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BloodStockDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.BloodStockDGV.EnableHeadersVisualStyles = false;
            this.BloodStockDGV.GridColor = System.Drawing.Color.Red;
            this.BloodStockDGV.Location = new System.Drawing.Point(281, 137);
            this.BloodStockDGV.Margin = new System.Windows.Forms.Padding(4);
            this.BloodStockDGV.Name = "BloodStockDGV";
            this.BloodStockDGV.RowHeadersVisible = false;
            this.BloodStockDGV.RowHeadersWidth = 51;
            this.BloodStockDGV.RowTemplate.Height = 25;
            this.BloodStockDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BloodStockDGV.Size = new System.Drawing.Size(343, 324);
            this.BloodStockDGV.TabIndex = 38;
            this.BloodStockDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.BloodStockDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BloodStockDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BloodStockDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BloodStockDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BloodStockDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BloodStockDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.BloodStockDGV.ThemeStyle.GridColor = System.Drawing.Color.Red;
            this.BloodStockDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red;
            this.BloodStockDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BloodStockDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodStockDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BloodStockDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BloodStockDGV.ThemeStyle.HeaderStyle.Height = 29;
            this.BloodStockDGV.ThemeStyle.ReadOnly = false;
            this.BloodStockDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BloodStockDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BloodStockDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodStockDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BloodStockDGV.ThemeStyle.RowsStyle.Height = 25;
            this.BloodStockDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.BloodStockDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.BloodStockDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BloodStockDGV_CellContentClick);
            // 
            // DonateBlood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1431, 753);
            this.Controls.Add(this.PBloodStockLBL);
            this.Controls.Add(this.BloodStockDGV);
            this.Controls.Add(this.PDonorsListLBL);
            this.Controls.Add(this.DonorsDGV);
            this.Controls.Add(this.BloodLogoPic);
            this.Controls.Add(this.DonateBTN);
            this.Controls.Add(this.BloodGroupLBL);
            this.Controls.Add(this.BGroupTb);
            this.Controls.Add(this.NameLBL);
            this.Controls.Add(this.DNameTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DonateBlood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DonateBlood";
            ((System.ComponentModel.ISupportInitialize)(this.BloodLogoPic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodStockDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BloodLogoPic;
        private Bunifu.Framework.UI.BunifuThinButton2 DonateBTN;
        private System.Windows.Forms.Label NameLBL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DNameTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LogoutLBL;
        private System.Windows.Forms.Label DashboardLBL;
        private System.Windows.Forms.Label BloodTransferLBL;
        private System.Windows.Forms.Label BloodStockLBL;
        private System.Windows.Forms.Label ViewPatientsLBL;
        private System.Windows.Forms.Label ViewDonorsLBL;
        private System.Windows.Forms.Label PatientLBL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label DonorLBL;
        private System.Windows.Forms.Label DonateLBL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BGroupTb;
        private System.Windows.Forms.Label BloodGroupLBL;
        private Guna.UI.WinForms.GunaDataGridView DonorsDGV;
        private System.Windows.Forms.Label PDonorsListLBL;
        private System.Windows.Forms.Label PBloodStockLBL;
        private Guna.UI.WinForms.GunaDataGridView BloodStockDGV;
    }
}
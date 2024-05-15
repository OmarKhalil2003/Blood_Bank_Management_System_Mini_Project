namespace WindowsFormsApp4
{
    partial class ViewPatients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewPatients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PGenCb = new System.Windows.Forms.ComboBox();
            this.GenderLBL = new System.Windows.Forms.Label();
            this.AgeLBL = new System.Windows.Forms.Label();
            this.PAgeTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NameLBL = new System.Windows.Forms.Label();
            this.PNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PhoneLBL = new System.Windows.Forms.Label();
            this.PphoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PBGroupCb = new System.Windows.Forms.ComboBox();
            this.BloodGroupLBL = new System.Windows.Forms.Label();
            this.PAddressTb = new System.Windows.Forms.TextBox();
            this.AddressLBL = new System.Windows.Forms.Label();
            this.EditBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PatientsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(273, 709);
            this.panel1.TabIndex = 3;
            // 
            // DonateLBL
            // 
            this.DonateLBL.AutoSize = true;
            this.DonateLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonateLBL.ForeColor = System.Drawing.Color.White;
            this.DonateLBL.Location = new System.Drawing.Point(59, 150);
            this.DonateLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DonateLBL.Name = "DonateLBL";
            this.DonateLBL.Size = new System.Drawing.Size(115, 41);
            this.DonateLBL.TabIndex = 19;
            this.DonateLBL.Text = "Donate";
            this.DonateLBL.Click += new System.EventHandler(this.label17_Click);
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
            this.DashboardLBL.Location = new System.Drawing.Point(47, 534);
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
            this.BloodTransferLBL.Location = new System.Drawing.Point(35, 457);
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
            this.BloodStockLBL.Location = new System.Drawing.Point(41, 391);
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
            this.ViewPatientsLBL.Location = new System.Drawing.Point(35, 325);
            this.ViewPatientsLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewPatientsLBL.Name = "ViewPatientsLBL";
            this.ViewPatientsLBL.Size = new System.Drawing.Size(194, 41);
            this.ViewPatientsLBL.TabIndex = 8;
            this.ViewPatientsLBL.Text = "View Patients";
            // 
            // ViewDonorsLBL
            // 
            this.ViewDonorsLBL.AutoSize = true;
            this.ViewDonorsLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDonorsLBL.ForeColor = System.Drawing.Color.White;
            this.ViewDonorsLBL.Location = new System.Drawing.Point(35, 206);
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
            this.PatientLBL.Location = new System.Drawing.Point(51, 261);
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
            this.panel3.Location = new System.Drawing.Point(21, 319);
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
            this.DonorLBL.Location = new System.Drawing.Point(59, 92);
            this.DonorLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DonorLBL.Name = "DonorLBL";
            this.DonorLBL.Size = new System.Drawing.Size(102, 41);
            this.DonorLBL.TabIndex = 2;
            this.DonorLBL.Text = "Donor";
            this.DonorLBL.Click += new System.EventHandler(this.DonateLBL_Click);
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
            this.panel2.TabIndex = 5;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(713, 46);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 46);
            this.label10.TabIndex = 7;
            this.label10.Text = "Patients List";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // PGenCb
            // 
            this.PGenCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PGenCb.ForeColor = System.Drawing.Color.Red;
            this.PGenCb.FormattingEnabled = true;
            this.PGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PGenCb.Location = new System.Drawing.Point(339, 236);
            this.PGenCb.Margin = new System.Windows.Forms.Padding(4);
            this.PGenCb.Name = "PGenCb";
            this.PGenCb.Size = new System.Drawing.Size(227, 31);
            this.PGenCb.TabIndex = 16;
            // 
            // GenderLBL
            // 
            this.GenderLBL.AutoSize = true;
            this.GenderLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLBL.ForeColor = System.Drawing.Color.Red;
            this.GenderLBL.Location = new System.Drawing.Point(332, 192);
            this.GenderLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLBL.Name = "GenderLBL";
            this.GenderLBL.Size = new System.Drawing.Size(92, 32);
            this.GenderLBL.TabIndex = 15;
            this.GenderLBL.Text = "Gender";
            // 
            // AgeLBL
            // 
            this.AgeLBL.AutoSize = true;
            this.AgeLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLBL.ForeColor = System.Drawing.Color.Red;
            this.AgeLBL.Location = new System.Drawing.Point(655, 92);
            this.AgeLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeLBL.Name = "AgeLBL";
            this.AgeLBL.Size = new System.Drawing.Size(56, 32);
            this.AgeLBL.TabIndex = 14;
            this.AgeLBL.Text = "Age";
            // 
            // PAgeTb
            // 
            this.PAgeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PAgeTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PAgeTb.ForeColor = System.Drawing.Color.Red;
            this.PAgeTb.HintForeColor = System.Drawing.Color.Empty;
            this.PAgeTb.HintText = "";
            this.PAgeTb.isPassword = false;
            this.PAgeTb.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.PAgeTb.LineIdleColor = System.Drawing.Color.MediumVioletRed;
            this.PAgeTb.LineMouseHoverColor = System.Drawing.Color.DarkMagenta;
            this.PAgeTb.LineThickness = 3;
            this.PAgeTb.Location = new System.Drawing.Point(661, 118);
            this.PAgeTb.Margin = new System.Windows.Forms.Padding(5);
            this.PAgeTb.Name = "PAgeTb";
            this.PAgeTb.Size = new System.Drawing.Size(252, 44);
            this.PAgeTb.TabIndex = 13;
            this.PAgeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLBL.ForeColor = System.Drawing.Color.Red;
            this.NameLBL.Location = new System.Drawing.Point(332, 92);
            this.NameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(78, 32);
            this.NameLBL.TabIndex = 12;
            this.NameLBL.Text = "Name";
            // 
            // PNameTb
            // 
            this.PNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNameTb.ForeColor = System.Drawing.Color.Red;
            this.PNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.PNameTb.HintText = "";
            this.PNameTb.isPassword = false;
            this.PNameTb.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.PNameTb.LineIdleColor = System.Drawing.Color.MediumVioletRed;
            this.PNameTb.LineMouseHoverColor = System.Drawing.Color.DarkMagenta;
            this.PNameTb.LineThickness = 3;
            this.PNameTb.Location = new System.Drawing.Point(339, 118);
            this.PNameTb.Margin = new System.Windows.Forms.Padding(5);
            this.PNameTb.Name = "PNameTb";
            this.PNameTb.Size = new System.Drawing.Size(252, 44);
            this.PNameTb.TabIndex = 11;
            this.PNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PhoneLBL
            // 
            this.PhoneLBL.AutoSize = true;
            this.PhoneLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLBL.ForeColor = System.Drawing.Color.Red;
            this.PhoneLBL.Location = new System.Drawing.Point(951, 92);
            this.PhoneLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneLBL.Name = "PhoneLBL";
            this.PhoneLBL.Size = new System.Drawing.Size(82, 32);
            this.PhoneLBL.TabIndex = 27;
            this.PhoneLBL.Text = "Phone";
            // 
            // PphoneTb
            // 
            this.PphoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PphoneTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PphoneTb.ForeColor = System.Drawing.Color.Red;
            this.PphoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.PphoneTb.HintText = "";
            this.PphoneTb.isPassword = false;
            this.PphoneTb.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.PphoneTb.LineIdleColor = System.Drawing.Color.MediumVioletRed;
            this.PphoneTb.LineMouseHoverColor = System.Drawing.Color.DarkMagenta;
            this.PphoneTb.LineThickness = 3;
            this.PphoneTb.Location = new System.Drawing.Point(953, 118);
            this.PphoneTb.Margin = new System.Windows.Forms.Padding(5);
            this.PphoneTb.Name = "PphoneTb";
            this.PphoneTb.Size = new System.Drawing.Size(252, 44);
            this.PphoneTb.TabIndex = 26;
            this.PphoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PBGroupCb
            // 
            this.PBGroupCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PBGroupCb.ForeColor = System.Drawing.Color.Red;
            this.PBGroupCb.FormattingEnabled = true;
            this.PBGroupCb.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.PBGroupCb.Location = new System.Drawing.Point(607, 236);
            this.PBGroupCb.Margin = new System.Windows.Forms.Padding(4);
            this.PBGroupCb.Name = "PBGroupCb";
            this.PBGroupCb.Size = new System.Drawing.Size(235, 31);
            this.PBGroupCb.TabIndex = 31;
            // 
            // BloodGroupLBL
            // 
            this.BloodGroupLBL.AutoSize = true;
            this.BloodGroupLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroupLBL.ForeColor = System.Drawing.Color.Red;
            this.BloodGroupLBL.Location = new System.Drawing.Point(600, 192);
            this.BloodGroupLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BloodGroupLBL.Name = "BloodGroupLBL";
            this.BloodGroupLBL.Size = new System.Drawing.Size(149, 32);
            this.BloodGroupLBL.TabIndex = 30;
            this.BloodGroupLBL.Text = "Blood Group";
            // 
            // PAddressTb
            // 
            this.PAddressTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PAddressTb.ForeColor = System.Drawing.Color.Red;
            this.PAddressTb.Location = new System.Drawing.Point(884, 234);
            this.PAddressTb.Margin = new System.Windows.Forms.Padding(4);
            this.PAddressTb.Multiline = true;
            this.PAddressTb.Name = "PAddressTb";
            this.PAddressTb.Size = new System.Drawing.Size(299, 31);
            this.PAddressTb.TabIndex = 29;
            // 
            // AddressLBL
            // 
            this.AddressLBL.AutoSize = true;
            this.AddressLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLBL.ForeColor = System.Drawing.Color.Red;
            this.AddressLBL.Location = new System.Drawing.Point(891, 192);
            this.AddressLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLBL.Name = "AddressLBL";
            this.AddressLBL.Size = new System.Drawing.Size(123, 40);
            this.AddressLBL.TabIndex = 28;
            this.AddressLBL.Text = "Address";
            this.AddressLBL.Click += new System.EventHandler(this.label15_Click);
            // 
            // EditBTN
            // 
            this.EditBTN.ActiveBorderThickness = 1;
            this.EditBTN.ActiveCornerRadius = 20;
            this.EditBTN.ActiveFillColor = System.Drawing.Color.Crimson;
            this.EditBTN.ActiveForecolor = System.Drawing.Color.White;
            this.EditBTN.ActiveLineColor = System.Drawing.Color.Crimson;
            this.EditBTN.BackColor = System.Drawing.Color.White;
            this.EditBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBTN.BackgroundImage")));
            this.EditBTN.ButtonText = "Edit";
            this.EditBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBTN.ForeColor = System.Drawing.Color.SeaGreen;
            this.EditBTN.IdleBorderThickness = 1;
            this.EditBTN.IdleCornerRadius = 20;
            this.EditBTN.IdleFillColor = System.Drawing.Color.ForestGreen;
            this.EditBTN.IdleForecolor = System.Drawing.Color.White;
            this.EditBTN.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.EditBTN.Location = new System.Drawing.Point(521, 281);
            this.EditBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(221, 52);
            this.EditBTN.TabIndex = 32;
            this.EditBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.ActiveBorderThickness = 1;
            this.DeleteBTN.ActiveCornerRadius = 20;
            this.DeleteBTN.ActiveFillColor = System.Drawing.Color.Crimson;
            this.DeleteBTN.ActiveForecolor = System.Drawing.Color.White;
            this.DeleteBTN.ActiveLineColor = System.Drawing.Color.Crimson;
            this.DeleteBTN.BackColor = System.Drawing.Color.White;
            this.DeleteBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBTN.BackgroundImage")));
            this.DeleteBTN.ButtonText = "Delete";
            this.DeleteBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBTN.ForeColor = System.Drawing.Color.SeaGreen;
            this.DeleteBTN.IdleBorderThickness = 1;
            this.DeleteBTN.IdleCornerRadius = 20;
            this.DeleteBTN.IdleFillColor = System.Drawing.Color.Red;
            this.DeleteBTN.IdleForecolor = System.Drawing.Color.White;
            this.DeleteBTN.IdleLineColor = System.Drawing.Color.Red;
            this.DeleteBTN.Location = new System.Drawing.Point(829, 281);
            this.DeleteBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(221, 52);
            this.DeleteBTN.TabIndex = 33;
            this.DeleteBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // PatientsDGV
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.PatientsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.PatientsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientsDGV.BackgroundColor = System.Drawing.Color.White;
            this.PatientsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.PatientsDGV.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientsDGV.DefaultCellStyle = dataGridViewCellStyle6;
            this.PatientsDGV.EnableHeadersVisualStyles = false;
            this.PatientsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientsDGV.Location = new System.Drawing.Point(281, 378);
            this.PatientsDGV.Margin = new System.Windows.Forms.Padding(4);
            this.PatientsDGV.Name = "PatientsDGV";
            this.PatientsDGV.RowHeadersVisible = false;
            this.PatientsDGV.RowHeadersWidth = 51;
            this.PatientsDGV.RowTemplate.Height = 25;
            this.PatientsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsDGV.Size = new System.Drawing.Size(1101, 316);
            this.PatientsDGV.TabIndex = 34;
            this.PatientsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.PatientsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PatientsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PatientsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PatientsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PatientsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PatientsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red;
            this.PatientsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PatientsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PatientsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PatientsDGV.ThemeStyle.HeaderStyle.Height = 29;
            this.PatientsDGV.ThemeStyle.ReadOnly = false;
            this.PatientsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientsDGV.ThemeStyle.RowsStyle.Height = 25;
            this.PatientsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.PatientsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.PatientsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDGV_CellContentClick);
            // 
            // ViewPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1399, 709);
            this.Controls.Add(this.PatientsDGV);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.EditBTN);
            this.Controls.Add(this.PBGroupCb);
            this.Controls.Add(this.BloodGroupLBL);
            this.Controls.Add(this.PAddressTb);
            this.Controls.Add(this.AddressLBL);
            this.Controls.Add(this.PhoneLBL);
            this.Controls.Add(this.PphoneTb);
            this.Controls.Add(this.PGenCb);
            this.Controls.Add(this.GenderLBL);
            this.Controls.Add(this.AgeLBL);
            this.Controls.Add(this.PAgeTb);
            this.Controls.Add(this.NameLBL);
            this.Controls.Add(this.PNameTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewPatient";
            this.Load += new System.EventHandler(this.ViewPatients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox PGenCb;
        private System.Windows.Forms.Label GenderLBL;
        private System.Windows.Forms.Label AgeLBL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PAgeTb;
        private System.Windows.Forms.Label NameLBL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PNameTb;
        private System.Windows.Forms.Label PhoneLBL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PphoneTb;
        private System.Windows.Forms.ComboBox PBGroupCb;
        private System.Windows.Forms.Label BloodGroupLBL;
        private System.Windows.Forms.TextBox PAddressTb;
        private System.Windows.Forms.Label AddressLBL;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBTN;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBTN;
        private Guna.UI.WinForms.GunaDataGridView PatientsDGV;
        private System.Windows.Forms.Label DonateLBL;
    }
}
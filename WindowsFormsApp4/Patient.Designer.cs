namespace WindowsFormsApp4
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DonateLBL = new System.Windows.Forms.Label();
            this.LogoutLBL = new System.Windows.Forms.Label();
            this.DashboardLBL = new System.Windows.Forms.Label();
            this.BloodTransferLBL = new System.Windows.Forms.Label();
            this.BloodStockLBL = new System.Windows.Forms.Label();
            this.ViewPatientLBL = new System.Windows.Forms.Label();
            this.ViewDonorsLBL = new System.Windows.Forms.Label();
            this.PatientLBL = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DonorLBL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PBGroupCb = new System.Windows.Forms.ComboBox();
            this.BloodGroupLBL = new System.Windows.Forms.Label();
            this.PAdressTb = new System.Windows.Forms.TextBox();
            this.AddressLBL = new System.Windows.Forms.Label();
            this.PhoneLBL = new System.Windows.Forms.Label();
            this.PGenCb = new System.Windows.Forms.ComboBox();
            this.GenderLBL = new System.Windows.Forms.Label();
            this.PPhoneTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.AgeLBL = new System.Windows.Forms.Label();
            this.PAgeTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NameLBL = new System.Windows.Forms.Label();
            this.PNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Controls.Add(this.ViewPatientLBL);
            this.panel1.Controls.Add(this.ViewDonorsLBL);
            this.panel1.Controls.Add(this.PatientLBL);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.DonorLBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 753);
            this.panel1.TabIndex = 3;
            // 
            // DonateLBL
            // 
            this.DonateLBL.AutoSize = true;
            this.DonateLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonateLBL.ForeColor = System.Drawing.Color.White;
            this.DonateLBL.Location = new System.Drawing.Point(47, 139);
            this.DonateLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DonateLBL.Name = "DonateLBL";
            this.DonateLBL.Size = new System.Drawing.Size(115, 41);
            this.DonateLBL.TabIndex = 19;
            this.DonateLBL.Text = "Donate";
            this.DonateLBL.Click += new System.EventHandler(this.DonateLBL_Click);
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
            // ViewPatientLBL
            // 
            this.ViewPatientLBL.AutoSize = true;
            this.ViewPatientLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPatientLBL.ForeColor = System.Drawing.Color.White;
            this.ViewPatientLBL.Location = new System.Drawing.Point(35, 325);
            this.ViewPatientLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewPatientLBL.Name = "ViewPatientLBL";
            this.ViewPatientLBL.Size = new System.Drawing.Size(194, 41);
            this.ViewPatientLBL.TabIndex = 8;
            this.ViewPatientLBL.Text = "View Patients";
            this.ViewPatientLBL.Click += new System.EventHandler(this.ViewPatientLBL_Click);
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
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.Location = new System.Drawing.Point(21, 252);
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
            this.DonorLBL.Location = new System.Drawing.Point(47, 87);
            this.DonorLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DonorLBL.Name = "DonorLBL";
            this.DonorLBL.Size = new System.Drawing.Size(102, 41);
            this.DonorLBL.TabIndex = 2;
            this.DonorLBL.Text = "Donor";
            this.DonorLBL.Click += new System.EventHandler(this.DonorLBL_Click);
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
            this.panel2.TabIndex = 4;
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
            // SaveBTN
            // 
            this.SaveBTN.ActiveBorderThickness = 1;
            this.SaveBTN.ActiveCornerRadius = 20;
            this.SaveBTN.ActiveFillColor = System.Drawing.Color.Crimson;
            this.SaveBTN.ActiveForecolor = System.Drawing.Color.White;
            this.SaveBTN.ActiveLineColor = System.Drawing.Color.Crimson;
            this.SaveBTN.BackColor = System.Drawing.Color.White;
            this.SaveBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBTN.BackgroundImage")));
            this.SaveBTN.ButtonText = "Save";
            this.SaveBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBTN.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveBTN.IdleBorderThickness = 1;
            this.SaveBTN.IdleCornerRadius = 20;
            this.SaveBTN.IdleFillColor = System.Drawing.Color.Red;
            this.SaveBTN.IdleForecolor = System.Drawing.Color.White;
            this.SaveBTN.IdleLineColor = System.Drawing.Color.Red;
            this.SaveBTN.Location = new System.Drawing.Point(689, 650);
            this.SaveBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(221, 52);
            this.SaveBTN.TabIndex = 30;
            this.SaveBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
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
            this.PBGroupCb.Location = new System.Drawing.Point(851, 357);
            this.PBGroupCb.Margin = new System.Windows.Forms.Padding(4);
            this.PBGroupCb.Name = "PBGroupCb";
            this.PBGroupCb.Size = new System.Drawing.Size(227, 31);
            this.PBGroupCb.TabIndex = 29;
            // 
            // BloodGroupLBL
            // 
            this.BloodGroupLBL.AutoSize = true;
            this.BloodGroupLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroupLBL.ForeColor = System.Drawing.Color.Red;
            this.BloodGroupLBL.Location = new System.Drawing.Point(844, 313);
            this.BloodGroupLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BloodGroupLBL.Name = "BloodGroupLBL";
            this.BloodGroupLBL.Size = new System.Drawing.Size(149, 32);
            this.BloodGroupLBL.TabIndex = 28;
            this.BloodGroupLBL.Text = "Blood Group";
            // 
            // PAdressTb
            // 
            this.PAdressTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PAdressTb.ForeColor = System.Drawing.Color.Red;
            this.PAdressTb.Location = new System.Drawing.Point(757, 460);
            this.PAdressTb.Margin = new System.Windows.Forms.Padding(4);
            this.PAdressTb.Multiline = true;
            this.PAdressTb.Name = "PAdressTb";
            this.PAdressTb.Size = new System.Drawing.Size(236, 110);
            this.PAdressTb.TabIndex = 27;
            // 
            // AddressLBL
            // 
            this.AddressLBL.AutoSize = true;
            this.AddressLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressLBL.ForeColor = System.Drawing.Color.Red;
            this.AddressLBL.Location = new System.Drawing.Point(751, 417);
            this.AddressLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLBL.Name = "AddressLBL";
            this.AddressLBL.Size = new System.Drawing.Size(84, 32);
            this.AddressLBL.TabIndex = 26;
            this.AddressLBL.Text = "Adress";
            // 
            // PhoneLBL
            // 
            this.PhoneLBL.AutoSize = true;
            this.PhoneLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLBL.ForeColor = System.Drawing.Color.Red;
            this.PhoneLBL.Location = new System.Drawing.Point(1063, 192);
            this.PhoneLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneLBL.Name = "PhoneLBL";
            this.PhoneLBL.Size = new System.Drawing.Size(82, 32);
            this.PhoneLBL.TabIndex = 25;
            this.PhoneLBL.Text = "Phone";
            // 
            // PGenCb
            // 
            this.PGenCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.PGenCb.ForeColor = System.Drawing.Color.Red;
            this.PGenCb.FormattingEnabled = true;
            this.PGenCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PGenCb.Location = new System.Drawing.Point(420, 357);
            this.PGenCb.Margin = new System.Windows.Forms.Padding(4);
            this.PGenCb.Name = "PGenCb";
            this.PGenCb.Size = new System.Drawing.Size(227, 31);
            this.PGenCb.TabIndex = 24;
            // 
            // GenderLBL
            // 
            this.GenderLBL.AutoSize = true;
            this.GenderLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderLBL.ForeColor = System.Drawing.Color.Red;
            this.GenderLBL.Location = new System.Drawing.Point(413, 313);
            this.GenderLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GenderLBL.Name = "GenderLBL";
            this.GenderLBL.Size = new System.Drawing.Size(92, 32);
            this.GenderLBL.TabIndex = 23;
            this.GenderLBL.Text = "Gender";
            // 
            // PPhoneTb
            // 
            this.PPhoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PPhoneTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PPhoneTb.ForeColor = System.Drawing.Color.Red;
            this.PPhoneTb.HintForeColor = System.Drawing.Color.Empty;
            this.PPhoneTb.HintText = "";
            this.PPhoneTb.isPassword = false;
            this.PPhoneTb.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.PPhoneTb.LineIdleColor = System.Drawing.Color.MediumVioletRed;
            this.PPhoneTb.LineMouseHoverColor = System.Drawing.Color.DarkMagenta;
            this.PPhoneTb.LineThickness = 3;
            this.PPhoneTb.Location = new System.Drawing.Point(1057, 215);
            this.PPhoneTb.Margin = new System.Windows.Forms.Padding(5);
            this.PPhoneTb.Name = "PPhoneTb";
            this.PPhoneTb.Size = new System.Drawing.Size(252, 44);
            this.PPhoneTb.TabIndex = 22;
            this.PPhoneTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AgeLBL
            // 
            this.AgeLBL.AutoSize = true;
            this.AgeLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgeLBL.ForeColor = System.Drawing.Color.Red;
            this.AgeLBL.Location = new System.Drawing.Point(720, 191);
            this.AgeLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AgeLBL.Name = "AgeLBL";
            this.AgeLBL.Size = new System.Drawing.Size(56, 32);
            this.AgeLBL.TabIndex = 21;
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
            this.PAgeTb.Location = new System.Drawing.Point(727, 217);
            this.PAgeTb.Margin = new System.Windows.Forms.Padding(5);
            this.PAgeTb.Name = "PAgeTb";
            this.PAgeTb.Size = new System.Drawing.Size(252, 44);
            this.PAgeTb.TabIndex = 20;
            this.PAgeTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLBL.ForeColor = System.Drawing.Color.Red;
            this.NameLBL.Location = new System.Drawing.Point(397, 191);
            this.NameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(78, 32);
            this.NameLBL.TabIndex = 19;
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
            this.PNameTb.Location = new System.Drawing.Point(404, 217);
            this.PNameTb.Margin = new System.Windows.Forms.Padding(5);
            this.PNameTb.Name = "PNameTb";
            this.PNameTb.Size = new System.Drawing.Size(252, 44);
            this.PNameTb.TabIndex = 18;
            this.PNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(771, 87);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(748, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 46);
            this.label10.TabIndex = 32;
            this.label10.Text = "Patients";
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1431, 753);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.PBGroupCb);
            this.Controls.Add(this.BloodGroupLBL);
            this.Controls.Add(this.PAdressTb);
            this.Controls.Add(this.AddressLBL);
            this.Controls.Add(this.PhoneLBL);
            this.Controls.Add(this.PGenCb);
            this.Controls.Add(this.GenderLBL);
            this.Controls.Add(this.PPhoneTb);
            this.Controls.Add(this.AgeLBL);
            this.Controls.Add(this.PAgeTb);
            this.Controls.Add(this.NameLBL);
            this.Controls.Add(this.PNameTb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LogoutLBL;
        private System.Windows.Forms.Label DashboardLBL;
        private System.Windows.Forms.Label BloodTransferLBL;
        private System.Windows.Forms.Label BloodStockLBL;
        private System.Windows.Forms.Label ViewPatientLBL;
        private System.Windows.Forms.Label ViewDonorsLBL;
        private System.Windows.Forms.Label PatientLBL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label DonorLBL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveBTN;
        private System.Windows.Forms.ComboBox PBGroupCb;
        private System.Windows.Forms.Label BloodGroupLBL;
        private System.Windows.Forms.TextBox PAdressTb;
        private System.Windows.Forms.Label AddressLBL;
        private System.Windows.Forms.Label PhoneLBL;
        private System.Windows.Forms.ComboBox PGenCb;
        private System.Windows.Forms.Label GenderLBL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PPhoneTb;
        private System.Windows.Forms.Label AgeLBL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PAgeTb;
        private System.Windows.Forms.Label NameLBL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PNameTb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DonateLBL;
    }
}
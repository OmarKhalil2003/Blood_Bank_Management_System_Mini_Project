namespace WindowsFormsApp4
{
    partial class View_Donors
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Donors));
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
            this.label10 = new System.Windows.Forms.Label();
            this.DonorsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.NameLBL = new System.Windows.Forms.Label();
            this.DonorNameTextBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsDGV)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(273, 709);
            this.panel1.TabIndex = 2;
            // 
            // DonateLBL
            // 
            this.DonateLBL.AutoSize = true;
            this.DonateLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonateLBL.ForeColor = System.Drawing.Color.White;
            this.DonateLBL.Location = new System.Drawing.Point(51, 140);
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
            this.ViewPatientLBL.Click += new System.EventHandler(this.ViewPatientsLBL_Click);
            // 
            // ViewDonorsLBL
            // 
            this.ViewDonorsLBL.AutoSize = true;
            this.ViewDonorsLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDonorsLBL.ForeColor = System.Drawing.Color.White;
            this.ViewDonorsLBL.Location = new System.Drawing.Point(41, 199);
            this.ViewDonorsLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewDonorsLBL.Name = "ViewDonorsLBL";
            this.ViewDonorsLBL.Size = new System.Drawing.Size(187, 41);
            this.ViewDonorsLBL.TabIndex = 6;
            this.ViewDonorsLBL.Text = "View Donors";
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
            this.panel3.Location = new System.Drawing.Point(21, 196);
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
            this.DonorLBL.Location = new System.Drawing.Point(51, 89);
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
            this.panel2.Size = new System.Drawing.Size(1126, 34);
            this.panel2.TabIndex = 3;
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
            this.label10.Location = new System.Drawing.Point(715, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 46);
            this.label10.TabIndex = 4;
            this.label10.Text = "Donors List";
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
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DonorsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DonorsDGV.EnableHeadersVisualStyles = false;
            this.DonorsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DonorsDGV.Location = new System.Drawing.Point(295, 183);
            this.DonorsDGV.Margin = new System.Windows.Forms.Padding(4);
            this.DonorsDGV.Name = "DonorsDGV";
            this.DonorsDGV.RowHeadersVisible = false;
            this.DonorsDGV.RowHeadersWidth = 51;
            this.DonorsDGV.RowTemplate.Height = 25;
            this.DonorsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DonorsDGV.Size = new System.Drawing.Size(1088, 470);
            this.DonorsDGV.TabIndex = 5;
            this.DonorsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DonorsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DonorsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DonorsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DonorsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DonorsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DonorsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DonorsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DonorsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red;
            this.DonorsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DonorsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DonorsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DonorsDGV.ThemeStyle.HeaderStyle.Height = 29;
            this.DonorsDGV.ThemeStyle.ReadOnly = false;
            this.DonorsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Empty;
            this.DonorsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DonorsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DonorsDGV.ThemeStyle.RowsStyle.Height = 25;
            this.DonorsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.DonorsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DonorsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLBL.ForeColor = System.Drawing.Color.Red;
            this.NameLBL.Location = new System.Drawing.Point(307, 121);
            this.NameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(78, 32);
            this.NameLBL.TabIndex = 7;
            this.NameLBL.Text = "Name";
            this.NameLBL.Click += new System.EventHandler(this.label11_Click);
            // 
            // DonorNameTextBox
            // 
            this.DonorNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DonorNameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonorNameTextBox.ForeColor = System.Drawing.Color.Red;
            this.DonorNameTextBox.HintForeColor = System.Drawing.Color.Empty;
            this.DonorNameTextBox.HintText = "";
            this.DonorNameTextBox.isPassword = false;
            this.DonorNameTextBox.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.DonorNameTextBox.LineIdleColor = System.Drawing.Color.MediumVioletRed;
            this.DonorNameTextBox.LineMouseHoverColor = System.Drawing.Color.DarkMagenta;
            this.DonorNameTextBox.LineThickness = 3;
            this.DonorNameTextBox.Location = new System.Drawing.Point(399, 101);
            this.DonorNameTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.DonorNameTextBox.Name = "DonorNameTextBox";
            this.DonorNameTextBox.Size = new System.Drawing.Size(252, 44);
            this.DonorNameTextBox.TabIndex = 6;
            this.DonorNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // View_Donors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1399, 709);
            this.Controls.Add(this.NameLBL);
            this.Controls.Add(this.DonorNameTextBox);
            this.Controls.Add(this.DonorsDGV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View_Donors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Donors";
            this.Load += new System.EventHandler(this.View_Donors_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DonorsDGV)).EndInit();
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
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaDataGridView DonorsDGV;
        private System.Windows.Forms.Label NameLBL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DonorNameTextBox;
        private System.Windows.Forms.Label DonateLBL;
    }
}
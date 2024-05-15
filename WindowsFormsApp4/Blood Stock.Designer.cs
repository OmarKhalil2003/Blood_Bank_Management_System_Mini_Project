namespace WindowsFormsApp4
{
    partial class Blood_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blood_Stock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BloodLBL = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PatientLBL = new System.Windows.Forms.Label();
            this.ViewDonorsLBL = new System.Windows.Forms.Label();
            this.ViewPAtientLBL = new System.Windows.Forms.Label();
            this.BloodStockLBL = new System.Windows.Forms.Label();
            this.BloodTransferLBL = new System.Windows.Forms.Label();
            this.DashboardLBL = new System.Windows.Forms.Label();
            this.LogoutLBL = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DonateLBL = new System.Windows.Forms.Label();
            this.BloodLogoPIC = new System.Windows.Forms.PictureBox();
            this.PBloodStockLBL = new System.Windows.Forms.Label();
            this.NameLBL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BloodStockDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.DBGroupCb = new System.Windows.Forms.ComboBox();
            this.FilterLBL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BloodLogoPIC)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BloodStockDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BloodLBL
            // 
            this.BloodLBL.AutoSize = true;
            this.BloodLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodLBL.ForeColor = System.Drawing.Color.White;
            this.BloodLBL.Location = new System.Drawing.Point(51, 107);
            this.BloodLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BloodLBL.Name = "BloodLBL";
            this.BloodLBL.Size = new System.Drawing.Size(102, 41);
            this.BloodLBL.TabIndex = 2;
            this.BloodLBL.Text = "Donor";
            this.BloodLBL.Click += new System.EventHandler(this.BloodLBL_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.Location = new System.Drawing.Point(21, 383);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 55);
            this.panel3.TabIndex = 2;
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
            // ViewDonorsLBL
            // 
            this.ViewDonorsLBL.AutoSize = true;
            this.ViewDonorsLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewDonorsLBL.ForeColor = System.Drawing.Color.White;
            this.ViewDonorsLBL.Location = new System.Drawing.Point(35, 207);
            this.ViewDonorsLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewDonorsLBL.Name = "ViewDonorsLBL";
            this.ViewDonorsLBL.Size = new System.Drawing.Size(187, 41);
            this.ViewDonorsLBL.TabIndex = 6;
            this.ViewDonorsLBL.Text = "View Donors";
            this.ViewDonorsLBL.Click += new System.EventHandler(this.ViewDonorsLBL_Click);
            // 
            // ViewPAtientLBL
            // 
            this.ViewPAtientLBL.AutoSize = true;
            this.ViewPAtientLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewPAtientLBL.ForeColor = System.Drawing.Color.White;
            this.ViewPAtientLBL.Location = new System.Drawing.Point(35, 325);
            this.ViewPAtientLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ViewPAtientLBL.Name = "ViewPAtientLBL";
            this.ViewPAtientLBL.Size = new System.Drawing.Size(194, 41);
            this.ViewPAtientLBL.TabIndex = 8;
            this.ViewPAtientLBL.Text = "View Patients";
            this.ViewPAtientLBL.Click += new System.EventHandler(this.ViewPAtientLBL_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Crimson;
            this.panel1.Controls.Add(this.DonateLBL);
            this.panel1.Controls.Add(this.LogoutLBL);
            this.panel1.Controls.Add(this.DashboardLBL);
            this.panel1.Controls.Add(this.BloodTransferLBL);
            this.panel1.Controls.Add(this.BloodStockLBL);
            this.panel1.Controls.Add(this.ViewPAtientLBL);
            this.panel1.Controls.Add(this.ViewDonorsLBL);
            this.panel1.Controls.Add(this.PatientLBL);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.BloodLBL);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 709);
            this.panel1.TabIndex = 8;
            // 
            // DonateLBL
            // 
            this.DonateLBL.AutoSize = true;
            this.DonateLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DonateLBL.ForeColor = System.Drawing.Color.White;
            this.DonateLBL.Location = new System.Drawing.Point(51, 153);
            this.DonateLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DonateLBL.Name = "DonateLBL";
            this.DonateLBL.Size = new System.Drawing.Size(115, 41);
            this.DonateLBL.TabIndex = 18;
            this.DonateLBL.Text = "Donate";
            this.DonateLBL.Click += new System.EventHandler(this.DonateLBL_Click);
            // 
            // BloodLogoPIC
            // 
            this.BloodLogoPIC.Image = ((System.Drawing.Image)(resources.GetObject("BloodLogoPIC.Image")));
            this.BloodLogoPIC.Location = new System.Drawing.Point(769, 87);
            this.BloodLogoPIC.Margin = new System.Windows.Forms.Padding(4);
            this.BloodLogoPIC.Name = "BloodLogoPIC";
            this.BloodLogoPIC.Size = new System.Drawing.Size(97, 75);
            this.BloodLogoPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BloodLogoPIC.TabIndex = 19;
            this.BloodLogoPIC.TabStop = false;
            // 
            // PBloodStockLBL
            // 
            this.PBloodStockLBL.AutoSize = true;
            this.PBloodStockLBL.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBloodStockLBL.ForeColor = System.Drawing.Color.Red;
            this.PBloodStockLBL.Location = new System.Drawing.Point(723, 38);
            this.PBloodStockLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PBloodStockLBL.Name = "PBloodStockLBL";
            this.PBloodStockLBL.Size = new System.Drawing.Size(198, 46);
            this.PBloodStockLBL.TabIndex = 13;
            this.PBloodStockLBL.Text = "Blood Stock";
            this.PBloodStockLBL.Click += new System.EventHandler(this.label10_Click);
            // 
            // NameLBL
            // 
            this.NameLBL.AutoSize = true;
            this.NameLBL.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLBL.ForeColor = System.Drawing.Color.White;
            this.NameLBL.Location = new System.Drawing.Point(348, -2);
            this.NameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLBL.Name = "NameLBL";
            this.NameLBL.Size = new System.Drawing.Size(399, 37);
            this.NameLBL.TabIndex = 1;
            this.NameLBL.Text = "Blood Bank Managment System ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel2.Controls.Add(this.NameLBL);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(273, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1126, 34);
            this.panel2.TabIndex = 14;
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
            this.BloodStockDGV.Location = new System.Drawing.Point(439, 261);
            this.BloodStockDGV.Margin = new System.Windows.Forms.Padding(4);
            this.BloodStockDGV.Name = "BloodStockDGV";
            this.BloodStockDGV.RowHeadersVisible = false;
            this.BloodStockDGV.RowHeadersWidth = 51;
            this.BloodStockDGV.RowTemplate.Height = 25;
            this.BloodStockDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BloodStockDGV.Size = new System.Drawing.Size(771, 411);
            this.BloodStockDGV.TabIndex = 39;
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
            // 
            // DBGroupCb
            // 
            this.DBGroupCb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.DBGroupCb.ForeColor = System.Drawing.Color.Red;
            this.DBGroupCb.FormattingEnabled = true;
            this.DBGroupCb.Items.AddRange(new object[] {
            "A+",
            "B+",
            "O+",
            "AB+",
            "A-",
            "B-",
            "O-",
            "AB-"});
            this.DBGroupCb.Location = new System.Drawing.Point(799, 192);
            this.DBGroupCb.Margin = new System.Windows.Forms.Padding(4);
            this.DBGroupCb.Name = "DBGroupCb";
            this.DBGroupCb.Size = new System.Drawing.Size(227, 31);
            this.DBGroupCb.TabIndex = 41;
            this.DBGroupCb.SelectedIndexChanged += new System.EventHandler(this.DBGroupCb_SelectedIndexChanged);
            // 
            // FilterLBL
            // 
            this.FilterLBL.AutoSize = true;
            this.FilterLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterLBL.ForeColor = System.Drawing.Color.Red;
            this.FilterLBL.Location = new System.Drawing.Point(719, 192);
            this.FilterLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FilterLBL.Name = "FilterLBL";
            this.FilterLBL.Size = new System.Drawing.Size(67, 32);
            this.FilterLBL.TabIndex = 40;
            this.FilterLBL.Text = "Filter";
            // 
            // Blood_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1399, 709);
            this.Controls.Add(this.DBGroupCb);
            this.Controls.Add(this.FilterLBL);
            this.Controls.Add(this.BloodStockDGV);
            this.Controls.Add(this.BloodLogoPIC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PBloodStockLBL);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Blood_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood_Stock";
            this.Load += new System.EventHandler(this.Blood_Stock_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BloodLogoPIC)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BloodStockDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BloodLBL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label PatientLBL;
        private System.Windows.Forms.Label ViewDonorsLBL;
        private System.Windows.Forms.Label ViewPAtientLBL;
        private System.Windows.Forms.Label BloodStockLBL;
        private System.Windows.Forms.Label BloodTransferLBL;
        private System.Windows.Forms.Label DashboardLBL;
        private System.Windows.Forms.Label LogoutLBL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BloodLogoPIC;
        private System.Windows.Forms.Label PBloodStockLBL;
        private System.Windows.Forms.Label NameLBL;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaDataGridView BloodStockDGV;
        private System.Windows.Forms.ComboBox DBGroupCb;
        private System.Windows.Forms.Label FilterLBL;
        private System.Windows.Forms.Label DonateLBL;
    }
}
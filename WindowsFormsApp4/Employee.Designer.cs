namespace WindowsFormsApp4
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.EmpDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EditBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.PasswordLBL = new System.Windows.Forms.Label();
            this.EmpPassTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NameLBL = new System.Windows.Forms.Label();
            this.EmpNameTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmployeesLBL = new System.Windows.Forms.Label();
            this.LogoutLBL = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DeleteBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SaveBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmpDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmpDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmpDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmpDGV.BackgroundColor = System.Drawing.Color.White;
            this.EmpDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmpDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmpDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmpDGV.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmpDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmpDGV.EnableHeadersVisualStyles = false;
            this.EmpDGV.GridColor = System.Drawing.Color.Red;
            this.EmpDGV.Location = new System.Drawing.Point(435, 170);
            this.EmpDGV.Margin = new System.Windows.Forms.Padding(4);
            this.EmpDGV.Name = "EmpDGV";
            this.EmpDGV.RowHeadersVisible = false;
            this.EmpDGV.RowHeadersWidth = 51;
            this.EmpDGV.RowTemplate.Height = 25;
            this.EmpDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmpDGV.Size = new System.Drawing.Size(836, 303);
            this.EmpDGV.TabIndex = 49;
            this.EmpDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmpDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.GridColor = System.Drawing.Color.Red;
            this.EmpDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red;
            this.EmpDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmpDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmpDGV.ThemeStyle.HeaderStyle.Height = 29;
            this.EmpDGV.ThemeStyle.ReadOnly = false;
            this.EmpDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmpDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmpDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmpDGV.ThemeStyle.RowsStyle.Height = 25;
            this.EmpDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Crimson;
            this.EmpDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.EmpDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmpDGV_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(844, 84);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
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
            this.EditBTN.Location = new System.Drawing.Point(687, 639);
            this.EditBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EditBTN.Name = "EditBTN";
            this.EditBTN.Size = new System.Drawing.Size(221, 52);
            this.EditBTN.TabIndex = 47;
            this.EditBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBTN.Click += new System.EventHandler(this.EditBTN_Click);
            // 
            // PasswordLBL
            // 
            this.PasswordLBL.AutoSize = true;
            this.PasswordLBL.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLBL.ForeColor = System.Drawing.Color.Red;
            this.PasswordLBL.Location = new System.Drawing.Point(845, 559);
            this.PasswordLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLBL.Name = "PasswordLBL";
            this.PasswordLBL.Size = new System.Drawing.Size(111, 32);
            this.PasswordLBL.TabIndex = 46;
            this.PasswordLBL.Text = "Password";
            // 
            // EmpPassTb
            // 
            this.EmpPassTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpPassTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPassTb.ForeColor = System.Drawing.Color.Red;
            this.EmpPassTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpPassTb.HintText = "";
            this.EmpPassTb.isPassword = false;
            this.EmpPassTb.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.EmpPassTb.LineIdleColor = System.Drawing.Color.MediumVioletRed;
            this.EmpPassTb.LineMouseHoverColor = System.Drawing.Color.DarkMagenta;
            this.EmpPassTb.LineThickness = 3;
            this.EmpPassTb.Location = new System.Drawing.Point(852, 575);
            this.EmpPassTb.Margin = new System.Windows.Forms.Padding(5);
            this.EmpPassTb.Name = "EmpPassTb";
            this.EmpPassTb.Size = new System.Drawing.Size(252, 44);
            this.EmpPassTb.TabIndex = 45;
            this.EmpPassTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.NameLBL.TabIndex = 44;
            this.NameLBL.Text = "Name";
            // 
            // EmpNameTb
            // 
            this.EmpNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmpNameTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpNameTb.ForeColor = System.Drawing.Color.Red;
            this.EmpNameTb.HintForeColor = System.Drawing.Color.Empty;
            this.EmpNameTb.HintText = "";
            this.EmpNameTb.isPassword = false;
            this.EmpNameTb.LineFocusedColor = System.Drawing.Color.DarkMagenta;
            this.EmpNameTb.LineIdleColor = System.Drawing.Color.MediumVioletRed;
            this.EmpNameTb.LineMouseHoverColor = System.Drawing.Color.DarkMagenta;
            this.EmpNameTb.LineThickness = 3;
            this.EmpNameTb.Location = new System.Drawing.Point(509, 578);
            this.EmpNameTb.Margin = new System.Windows.Forms.Padding(5);
            this.EmpNameTb.Name = "EmpNameTb";
            this.EmpNameTb.Size = new System.Drawing.Size(252, 44);
            this.EmpNameTb.TabIndex = 43;
            this.EmpNameTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(765, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 46);
            this.label10.TabIndex = 42;
            this.label10.Text = "Employees";
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
            this.panel2.TabIndex = 41;
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
            this.panel1.Controls.Add(this.EmployeesLBL);
            this.panel1.Controls.Add(this.LogoutLBL);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 709);
            this.panel1.TabIndex = 40;
            // 
            // EmployeesLBL
            // 
            this.EmployeesLBL.AutoSize = true;
            this.EmployeesLBL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesLBL.ForeColor = System.Drawing.Color.White;
            this.EmployeesLBL.Location = new System.Drawing.Point(67, 50);
            this.EmployeesLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmployeesLBL.Name = "EmployeesLBL";
            this.EmployeesLBL.Size = new System.Drawing.Size(162, 41);
            this.EmployeesLBL.TabIndex = 16;
            this.EmployeesLBL.Text = "Employees";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.Location = new System.Drawing.Point(35, 47);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 55);
            this.panel3.TabIndex = 2;
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
            this.DeleteBTN.Location = new System.Drawing.Point(939, 639);
            this.DeleteBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(221, 52);
            this.DeleteBTN.TabIndex = 50;
            this.DeleteBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
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
            this.SaveBTN.IdleFillColor = System.Drawing.Color.MediumVioletRed;
            this.SaveBTN.IdleForecolor = System.Drawing.Color.White;
            this.SaveBTN.IdleLineColor = System.Drawing.Color.MediumVioletRed;
            this.SaveBTN.Location = new System.Drawing.Point(435, 639);
            this.SaveBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(221, 52);
            this.SaveBTN.TabIndex = 51;
            this.SaveBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1399, 709);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.EmpDGV);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.EditBTN);
            this.Controls.Add(this.PasswordLBL);
            this.Controls.Add(this.EmpPassTb);
            this.Controls.Add(this.NameLBL);
            this.Controls.Add(this.EmpNameTb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmpDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView EmpDGV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBTN;
        private System.Windows.Forms.Label PasswordLBL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpPassTb;
        private System.Windows.Forms.Label NameLBL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmpNameTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EmployeesLBL;
        private System.Windows.Forms.Label LogoutLBL;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBTN;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveBTN;
    }
}
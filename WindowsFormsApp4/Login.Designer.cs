namespace WindowsFormsApp4
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserNameLBL = new System.Windows.Forms.Label();
            this.EmpIdTb = new System.Windows.Forms.TextBox();
            this.EmpPassTb = new System.Windows.Forms.TextBox();
            this.PasswordLBL = new System.Windows.Forms.Label();
            this.LoginBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ContAdminLBL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(87, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blood Bank Managment System ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 52);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UserNameLBL
            // 
            this.UserNameLBL.AutoSize = true;
            this.UserNameLBL.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLBL.ForeColor = System.Drawing.Color.Red;
            this.UserNameLBL.Location = new System.Drawing.Point(36, 153);
            this.UserNameLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserNameLBL.Name = "UserNameLBL";
            this.UserNameLBL.Size = new System.Drawing.Size(115, 23);
            this.UserNameLBL.TabIndex = 3;
            this.UserNameLBL.Text = "User Name";
            // 
            // EmpIdTb
            // 
            this.EmpIdTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpIdTb.Location = new System.Drawing.Point(167, 148);
            this.EmpIdTb.Margin = new System.Windows.Forms.Padding(4);
            this.EmpIdTb.Name = "EmpIdTb";
            this.EmpIdTb.Size = new System.Drawing.Size(295, 32);
            this.EmpIdTb.TabIndex = 4;
            // 
            // EmpPassTb
            // 
            this.EmpPassTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpPassTb.Location = new System.Drawing.Point(167, 226);
            this.EmpPassTb.Margin = new System.Windows.Forms.Padding(4);
            this.EmpPassTb.Name = "EmpPassTb";
            this.EmpPassTb.PasswordChar = 'x';
            this.EmpPassTb.Size = new System.Drawing.Size(295, 32);
            this.EmpPassTb.TabIndex = 5;
            // 
            // PasswordLBL
            // 
            this.PasswordLBL.AutoSize = true;
            this.PasswordLBL.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLBL.ForeColor = System.Drawing.Color.Red;
            this.PasswordLBL.Location = new System.Drawing.Point(48, 233);
            this.PasswordLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLBL.Name = "PasswordLBL";
            this.PasswordLBL.Size = new System.Drawing.Size(98, 23);
            this.PasswordLBL.TabIndex = 6;
            this.PasswordLBL.Text = "Password";
            this.PasswordLBL.Click += new System.EventHandler(this.label3_Click);
            // 
            // LoginBTN
            // 
            this.LoginBTN.ActiveBorderThickness = 1;
            this.LoginBTN.ActiveCornerRadius = 20;
            this.LoginBTN.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.LoginBTN.ActiveForecolor = System.Drawing.Color.White;
            this.LoginBTN.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.LoginBTN.BackColor = System.Drawing.Color.White;
            this.LoginBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginBTN.BackgroundImage")));
            this.LoginBTN.ButtonText = "Login";
            this.LoginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBTN.ForeColor = System.Drawing.Color.SeaGreen;
            this.LoginBTN.IdleBorderThickness = 1;
            this.LoginBTN.IdleCornerRadius = 20;
            this.LoginBTN.IdleFillColor = System.Drawing.Color.Red;
            this.LoginBTN.IdleForecolor = System.Drawing.Color.White;
            this.LoginBTN.IdleLineColor = System.Drawing.Color.Red;
            this.LoginBTN.Location = new System.Drawing.Point(180, 283);
            this.LoginBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.LoginBTN.Name = "LoginBTN";
            this.LoginBTN.Size = new System.Drawing.Size(271, 52);
            this.LoginBTN.TabIndex = 7;
            this.LoginBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginBTN.Click += new System.EventHandler(this.LoginBTN_Click);
            // 
            // ContAdminLBL
            // 
            this.ContAdminLBL.AutoSize = true;
            this.ContAdminLBL.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContAdminLBL.ForeColor = System.Drawing.Color.Red;
            this.ContAdminLBL.Location = new System.Drawing.Point(213, 356);
            this.ContAdminLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContAdminLBL.Name = "ContAdminLBL";
            this.ContAdminLBL.Size = new System.Drawing.Size(187, 23);
            this.ContAdminLBL.TabIndex = 8;
            this.ContAdminLBL.Text = "Continue as Admin";
            this.ContAdminLBL.Click += new System.EventHandler(this.ContAdminLBL_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(569, 2);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 420);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ContAdminLBL);
            this.Controls.Add(this.LoginBTN);
            this.Controls.Add(this.PasswordLBL);
            this.Controls.Add(this.EmpPassTb);
            this.Controls.Add(this.EmpIdTb);
            this.Controls.Add(this.UserNameLBL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserNameLBL;
        private System.Windows.Forms.TextBox EmpIdTb;
        private System.Windows.Forms.TextBox EmpPassTb;
        private System.Windows.Forms.Label PasswordLBL;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginBTN;
        private System.Windows.Forms.Label ContAdminLBL;
        private System.Windows.Forms.Label label5;
    }
}
namespace WindowsFormsApp4
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginBTN = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.AdminPassTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(687, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(303, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cancel";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // loginBTN
            // 
            this.loginBTN.ActiveBorderThickness = 1;
            this.loginBTN.ActiveCornerRadius = 20;
            this.loginBTN.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.loginBTN.ActiveForecolor = System.Drawing.Color.White;
            this.loginBTN.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.loginBTN.BackColor = System.Drawing.SystemColors.Control;
            this.loginBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBTN.BackgroundImage")));
            this.loginBTN.ButtonText = "Login";
            this.loginBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBTN.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginBTN.IdleBorderThickness = 1;
            this.loginBTN.IdleCornerRadius = 20;
            this.loginBTN.IdleFillColor = System.Drawing.Color.Red;
            this.loginBTN.IdleForecolor = System.Drawing.Color.White;
            this.loginBTN.IdleLineColor = System.Drawing.Color.Red;
            this.loginBTN.Location = new System.Drawing.Point(225, 208);
            this.loginBTN.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(271, 52);
            this.loginBTN.TabIndex = 13;
            this.loginBTN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(100, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.PassLBL_Click);
            // 
            // AdminPassTb
            // 
            this.AdminPassTb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminPassTb.Location = new System.Drawing.Point(212, 142);
            this.AdminPassTb.Margin = new System.Windows.Forms.Padding(4);
            this.AdminPassTb.Name = "AdminPassTb";
            this.AdminPassTb.PasswordChar = 'x';
            this.AdminPassTb.Size = new System.Drawing.Size(295, 32);
            this.AdminPassTb.TabIndex = 11;
            this.AdminPassTb.TextChanged += new System.EventHandler(this.AdminPassTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(148, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Blood Bank Managment System ";
            this.label1.Click += new System.EventHandler(this.AppNameLBL_Click);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 391);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdminPassTb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 loginBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AdminPassTb;
        private System.Windows.Forms.Label label1;
    }
}
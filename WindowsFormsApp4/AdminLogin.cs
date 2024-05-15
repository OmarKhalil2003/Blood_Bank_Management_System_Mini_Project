using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void AppNameLBL_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            if(AdminPassTb.Text == "")
            {
                MessageBox.Show("Enter The Admin Password");
            }
            else if(AdminPassTb.Text=="Password"){
                Employee Emp = new Employee();
                Emp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password.Contact The Admin");
                AdminPassTb.Text = "";
            }
        }

        private void AdminPassTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassLBL_Click(object sender, EventArgs e)
        {

        }
    }
}

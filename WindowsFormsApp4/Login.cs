using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=OMAR\\SQLEXPRESS;Initial Catalog=BloodBankDb;Integrated Security=True;Pooling=False");
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ContAdminLBL_Click(object sender, EventArgs e)
        {
            AdminLogin Adm = new AdminLogin();
            Adm.Show();
            this.Hide();
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count (*)from EmployeeTb1 where EmpId='"+EmpIdTb.Text+"'and EmpPass='"+EmpPassTb.Text+"'",Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() =="1")
            {
                MainForm main=new MainForm();
                main.Show();
                this.Hide();
                Con.Close();
            }
            else
            {
                MessageBox.Show("Wrong UserName Or Password");
            }
            Con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

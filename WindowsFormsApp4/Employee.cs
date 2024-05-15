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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection("Data Source=OMAR\\SQLEXPRESS;Initial Catalog=BloodBankDb;Integrated Security=True;Pooling=False");
        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void LogoutLBL_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
        private void Reset()
        {
            EmpNameTb.Text = "";
            EmpPassTb.Text = "";
            key = 1;
        }
        private void populate()
        {
            Con.Open();
            string Query = "select* from EmployeeTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EmpDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpPassTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into EmployeeTb1 values('" + EmpNameTb.Text + "','" + EmpPassTb.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully saved ");
                    Con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;
        private void EmpDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           EmpNameTb.Text = EmpDGV.SelectedRows[0].Cells[1].Value.ToString();
            EmpPassTb.Text =EmpDGV.SelectedRows[0].Cells[2].Value.ToString();
            
            if (EmpNameTb.Text == "")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(EmpDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Employee to Delete");
            }
            else
            {
                try
                {
                    string query = "delete from EmployeeTb1 where EmpNum=" + key + ";";
                    Con.Open();
                    key = 1;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee Successfully Deleted ");
                    Con.Close();
                   
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            if (EmpNameTb.Text == "" || EmpPassTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "update EmployeeTb1 set EmpId='" + EmpNameTb.Text + "',EmpPass='" + EmpPassTb.Text + "'where EmpNum=" + key + ";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Emplyee Successfully Updated ");
                    Con.Close();
                    Reset();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }
    }
}

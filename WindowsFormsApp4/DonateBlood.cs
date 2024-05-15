using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class DonateBlood : Form
    {
        public DonateBlood()
        {
            InitializeComponent();
            populate();
            bloodStock();
        }
        SqlConnection Con = new SqlConnection("Data Source=OMAR\\SQLEXPRESS;Initial Catalog=BloodBankDb;Integrated Security=True;Pooling=False");
        private void populate()
        {
            Con.Open();
            string Query = "select* from DonorTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DonorsDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void bloodStock()
        {
            Con.Open();
            string Query = "select* from BloodTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BloodStockDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        
        int oldstock;
        private void GetStock(string Bgroup)
        {
           // helps to get the actual stock of blood based on particular Blood Group

            Con.Open();
            string query ="select * from BloodTb1 where BGroup='"+Bgroup+"'";
            SqlCommand cmd = new SqlCommand(query,Con);
            DataTable dt =new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
             oldstock = Convert.ToInt32(dr["BStock"].ToString());

            } 
            Con.Close();
        }

        private void DonorsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DNameTb.Text =DonorsDGV.SelectedRows[0].Cells[1].Value.ToString();
            BGroupTb.Text = DonorsDGV.SelectedRows[0].Cells[6].Value.ToString();
            GetStock(BGroupTb.Text);
        }
        private void Reset()
        {
            DNameTb.Text = "";
            BGroupTb.Text = " ";
        }
        private void DonateBTN_Click(object sender, EventArgs e)
        {
            if (DNameTb.Text == "")
            {
                MessageBox.Show("Select A Donor");

            }
            else
            {
                try
                {
                    int stock = oldstock+1;
                    string query = "update BloodTb1 set BStock =" + stock+ "where  BGroup='" + BGroupTb.Text + "';";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Donation Successfull  ");
                    Con.Close();
                    Reset();
                    bloodStock();
                
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DonorLBL_Click(object sender, EventArgs e)
        {
            Donor Ob = new Donor();
            Ob.Show();
            this.Hide();
        }

        private void ViewDonorsLBL_Click(object sender, EventArgs e)
        {
            View_Donors Ob = new View_Donors();
            Ob.Show();
            this.Hide();
        }

        private void PatientLBL_Click(object sender, EventArgs e)
        {

            Patient Ob = new Patient();
            Ob.Show();
            this.Hide();
        }

        private void ViewPatientsLBL_Click(object sender, EventArgs e)
        {
            ViewPatients Ob = new ViewPatients();
            Ob.Show();
            this.Hide();
        }

        private void BloodStockLBL_Click(object sender, EventArgs e)
        {
            Blood_Stock Ob = new Blood_Stock();
            Ob.Show();
            this.Hide();
        }

        private void BloodTransferLBL_Click(object sender, EventArgs e)
        {
            Blood_Transfer Ob = new Blood_Transfer();
            Ob.Show();
            this.Hide();
        }

        private void DashboardLBL_Click(object sender, EventArgs e)
        {

            DashBoard Ob = new DashBoard();
            Ob.Show();
            this.Hide();
        }

        private void LogoutLBL_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void BloodStockDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

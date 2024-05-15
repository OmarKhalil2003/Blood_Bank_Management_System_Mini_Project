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
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            GetData();
        }
        SqlConnection Con = new SqlConnection("Data Source=OMAR\\SQLEXPRESS;Initial Catalog=BloodBankDb;Integrated Security=True;Pooling=False");
        private void GetData()
        {
            
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from DonorTb1", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DonorLbl.Text = dt.Rows[0][0].ToString();
                SqlDataAdapter sda1 = new SqlDataAdapter("select count(*) from TransferTb1", Con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                TransferLbl.Text = dt1.Rows[0][0].ToString();
                SqlDataAdapter sda2 = new SqlDataAdapter("select count(*) from EmployeeTb1", Con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                EmployeeLbl.Text = dt2.Rows[0][0].ToString();
                SqlDataAdapter sda3 = new SqlDataAdapter("select sum(BStock) from BloodTb1", Con);
                DataTable dt3 = new DataTable();
                sda3.Fill(dt3);
                int BStock = Convert.ToInt32(dt3.Rows[0][0].ToString());
                PTotalLBL.Text = "" + BStock;
                SqlDataAdapter sda4 = new SqlDataAdapter("select BStock from BloodTb1 where BGroup='" + "O+" + "'", Con);
                DataTable dt4 = new DataTable();
                sda4.Fill(dt4);

                OPlusNumLbl.Text = dt4.Rows[0][0].ToString();
                double OplusPercentage = (Convert.ToDouble(dt4.Rows[0][0].ToString()) / BStock) * 100;
                OPlusProgress.Value = (int)OplusPercentage;
            // MessageBox.Show("" + OplusPercentage);
            SqlDataAdapter sda5 = new SqlDataAdapter("select BStock from BloodTb1 where BGroup='" + "AB+" + "'", Con);
                DataTable dt5 = new DataTable();
                sda5.Fill(dt5);

                ABPlusNumLbl.Text = dt5.Rows[0][0].ToString();
                double ABplusPercentage = (Convert.ToDouble(dt5.Rows[0][0].ToString()) / BStock) * 100;
                ABPlusProgress.Value = (int)ABplusPercentage;
                // MessageBox.Show("" + OplusPercentage);
                SqlDataAdapter sda6 = new SqlDataAdapter("select BStock from BloodTb1 where BGroup='" + "AB-" + "'", Con);
                DataTable dt6 = new DataTable();
                sda6.Fill(dt6);

                ABNegativeNumLbl.Text = dt6.Rows[0][0].ToString();
                double ABNegativePercentage = (Convert.ToDouble(dt6.Rows[0][0].ToString()) / BStock) * 100;
                ABNegativeProgress.Value = (int)ABNegativePercentage;
                // MessageBox.Show("" + OplusPercentage);
                SqlDataAdapter sda7 = new SqlDataAdapter("select BStock from BloodTb1 where BGroup='" + "O-" + "'", Con);
                DataTable dt7 = new DataTable();
                sda7.Fill(dt7);

                ONegativeNumLbl.Text = dt7.Rows[0][0].ToString();
                double ONegativePercentage = (Convert.ToDouble(dt7.Rows[0][0].ToString()) / BStock) * 100;
                ONegativeProgress.Value = (int)ONegativePercentage;

            
           
                Con.Close();
            
           

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }

        private void DonorLbl_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void gunaCircleProgressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void DonorLBL_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void ViewDonorsLBL_Click(object sender, EventArgs e)
        {
            View_Donors Ob = new View_Donors();
            Ob.Show();
            this.Hide();
        }

        private void DonateLBL_Click_2(object sender, EventArgs e)
        {
            DonateBlood Ob = new DonateBlood();
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

        private void label7_Click(object sender, EventArgs e)
        {
            Blood_Transfer Ob = new Blood_Transfer();
            Ob.Show();
            this.Hide();
        }

        private void LogoutLBL_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }
    }
}

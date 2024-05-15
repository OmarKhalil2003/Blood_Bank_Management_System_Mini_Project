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
    public partial class Blood_Stock : Form
    {
        public Blood_Stock()
        {
            InitializeComponent();
            bloodStock();
        }
        SqlConnection Con = new SqlConnection("Data Source=OMAR\\SQLEXPRESS;Initial Catalog=BloodBankDb;Integrated Security=True;Pooling=False");

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
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Blood_Stock_Load(object sender, EventArgs e)
        {

        }

        private void BloodTransferLBL_Click(object sender, EventArgs e)
        {
            Blood_Transfer  Bt = new Blood_Transfer();
            Bt.Show();
            this.Hide();
        }

        private void BloodLBL_Click(object sender, EventArgs e)
        {
            Donor Ob = new Donor();
            Ob.Show();
            this.Hide();
        }

        private void DonateLBL_Click(object sender, EventArgs e)
        {
            DonateBlood Ob = new DonateBlood();
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

        private void ViewPAtientLBL_Click(object sender, EventArgs e)
        {
            ViewPatients Ob = new ViewPatients();
            Ob.Show();
            this.Hide();
        }

        private void DashboardLBL_Click(object sender, EventArgs e)
        {
            DashBoard Ob = new DashBoard();
            Ob.Show();
            this.Hide();
        }

        

        private void DBGroupCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LogoutLBL_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();

        }
    }
}

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
namespace WindowsFormsApp4
{
    public partial class View_Donors : Form
    {
        public View_Donors()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection("Data Source=OMAR\\SQLEXPRESS;Initial Catalog=BloodBankDb;Integrated Security=True;Pooling=False");
        private void populate()
        {
            Con.Open();
            string Query = "select* from DonorTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query,Con); 
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DonorsDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void View_Donors_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void DonorLBL_Click(object sender, EventArgs e)
        {

            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void DonateLBL_Click(object sender, EventArgs e)
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

        
    }
}

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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection("Data Source=OMAR\\SQLEXPRESS;Initial Catalog=BloodBankDb;Integrated Security=True;Pooling=False");
        private void Reset()
        {
            PNameTb.Text = "";
            PAgeTb.Text = "";
            PPhoneTb.Text = "";
            PGenCb.SelectedIndex = -1;
            PBGroupCb.SelectedIndex = -1;
            PAdressTb.Text = "";
        }
        private void SaveBTN_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PPhoneTb.Text == "" || PAgeTb.Text == "" || PGenCb.SelectedIndex == -1 || PBGroupCb.SelectedIndex == -1||PAdressTb.Text=="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into PatientTb1 values('" + PNameTb.Text + "'," + PAgeTb.Text + ",'" + PPhoneTb.Text + "','" + PGenCb.SelectedItem.ToString() + "','" + PBGroupCb.SelectedItem.ToString() + "','" +PAdressTb.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Saved ");
                    Con.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void ViewPatientLBL_Click(object sender, EventArgs e)
        {
            ViewPatients VP = new ViewPatients();
            VP.Show();
            this.Hide();
        }

        private void BloodTransferLBL_Click(object sender, EventArgs e)
        {
            Blood_Transfer Bt = new Blood_Transfer();
            Bt.Show();
            this.Hide();
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

        private void ViewDonorsLBL_Click(object sender, EventArgs e)
        {
            View_Donors Ob = new View_Donors();
            Ob.Show();
            this.Hide();
        }

        private void BloodStockLBL_Click(object sender, EventArgs e)
        {
            Blood_Stock Ob = new Blood_Stock();
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

        private void Patient_Load(object sender, EventArgs e)
        {

        }
    }
}

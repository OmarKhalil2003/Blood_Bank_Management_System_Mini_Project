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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       

        private void LogoutLBL_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }


        private void DonateLBL_Click(object sender, EventArgs e)
        {
            DonateBlood Ob = new DonateBlood();
            Ob.Show();
            this.Hide();
        }


        private void DonorLBL_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide ();
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

        private void ViewPAtientsLBL_Click(object sender, EventArgs e)
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}

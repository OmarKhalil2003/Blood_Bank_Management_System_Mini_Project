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
using Guna.UI.WinForms;

namespace WindowsFormsApp4
{
    public partial class ViewPatients : Form
    {
        public ViewPatients()
        {
            InitializeComponent();
            populate();
        }
        SqlConnection Con = new SqlConnection("Data Source=OMAR\\SQLEXPRESS;Initial Catalog=BloodBankDb;Integrated Security=True;Pooling=False");
        private void populate()
        {
            Con.Open();
            string Query = "select* from PatientTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PatientsDGV.DataSource = ds.Tables[0];

            Con.Close();
        }
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ViewPatients_Load(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        int key = 0;
        private void PatientsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PNameTb.Text= PatientsDGV.SelectedRows[0].Cells[1].Value.ToString();
            PAgeTb.Text = PatientsDGV.SelectedRows[0].Cells[2].Value.ToString();
            PphoneTb.Text = PatientsDGV.SelectedRows[0].Cells[3].Value.ToString();
            PGenCb.SelectedItem = PatientsDGV.SelectedRows[0].Cells[4].Value.ToString();
            PBGroupCb.SelectedItem = PatientsDGV.SelectedRows[0].Cells[5].Value.ToString();
            PAddressTb.Text = PatientsDGV.SelectedRows[0].Cells[6].Value.ToString();
          if (PNameTb.Text=="")
            {
                key = 0;

            }
            else
            {
                key = Convert.ToInt32(PatientsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
        private void Reset()
        {
            PNameTb.Text = "";
            PAgeTb.Text = "";
            PphoneTb.Text = "";
            PGenCb.SelectedIndex = -1;
            PBGroupCb.SelectedIndex = -1;
            PAddressTb.Text = "";
            key = 0;
        }
        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Select Patient to Delete");
            }
            else
            {
                try
                {
                    string query = "Delete from PatientTb1 where PNum="+key+";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Deleted ");
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

        private void PatientLBL_Click(object sender, EventArgs e)
        {
            Patient Pat = new Patient();
            Pat.Show();
            this.Hide();
        }

        private void EditBTN_Click(object sender, EventArgs e)
        {
            if (PNameTb.Text == "" || PphoneTb.Text == "" || PAgeTb.Text == "" || PGenCb.SelectedIndex == -1 || PBGroupCb.SelectedIndex == -1 || PAddressTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "update PatientTb1 set Pname='" + PNameTb.Text + "',Page=" + PAgeTb.Text + ",Pphone='" + PphoneTb.Text + "',PGender='" + PGenCb.SelectedItem.ToString() + "',PBGroup='" + PBGroupCb.SelectedItem.ToString() + "',Padrress='" + PAddressTb.Text + "'where PNum="+key+";";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patient Successfully Updated ");
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

        private void DonateLBL_Click(object sender, EventArgs e)
        {
            Donor donor = new Donor();
            donor.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
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

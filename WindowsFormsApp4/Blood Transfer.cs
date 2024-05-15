using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
    public partial class Blood_Transfer : Form
    {
        public Blood_Transfer()
        {
            InitializeComponent();
            fillPatientCb();
        }
        SqlConnection Con = new SqlConnection("Data Source=OMAR\\SQLEXPRESS;Initial Catalog=BloodBankDb;Integrated Security=True;Pooling=False");
        private void fillPatientCb()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select PNum from PatientTb1", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("PNum", typeof(string));
            dt.Load(rdr);
            PatientIdCb.ValueMember = "PNum";
            PatientIdCb.DataSource = dt;
            Con.Close();
        }
        private void GetData()
        {
            // helps to get the Blood Group and Patient Name

            Con.Open();
            string query = "select * from PatientTb1 where PNum='" + PatientIdCb.SelectedValue.ToString() + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
               PatNameTb.Text = dr["PName"].ToString();
                BloodGroupTB.Text = dr["PBGroup"].ToString();

            }
            Con.Close();
        }
        int stock;
        private void GetStock(string Bgroup)
        {
            // helps to get the actual stock of blood based on particular Blood Group

            Con.Open();
            string query = "select * from BloodTb1 where BGroup='" + Bgroup + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                stock = Convert.ToInt32(dr["BStock"].ToString());

            }
            Con.Close();
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            PatNameTb.Text = "";
            //PatientIdCb.SelectedIndex = -1;
            BloodGroupTB.Text = "";
            AvaliableLbl.Visible = false;
            TransferBtn.Visible = false;    
        }
        private void updateStock()
        {
            int newstock = stock - 1;
            try
            {
                string query = "update BloodTb1 set BStock=" + newstock + "where BGroup='" + BloodGroupTB.Text + "';";
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                //MessageBox.Show("Patient Successfully Updated ");
                Con.Close();
                Reset();
               
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (PatNameTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    string query = "insert into TransferTb1 values('" + PatNameTb.Text + "','" + BloodGroupTB.Text + "')";
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfull Transfer ");
                    Con.Close();
                    GetStock(BloodGroupTB.Text);
                    updateStock();
                    Reset();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void PateintIdCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       /* int oldstock;
        private void GetStock(string Bgroup)
        {
            // helps to get the actual stock of blood based on particular Blood Group

            Con.Open();
            string query = "select * from BloodTb1 where BGroup='" + Bgroup + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                oldstock = Convert.ToInt32(dr["BStock"].ToString());

            }
            Con.Close();
        }*/
        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetData();
            GetStock(BloodGroupTB.Text);
            if(stock>0)
            {
                TransferBtn.Visible = true;
                AvaliableLbl.Text = "Avaliable STock";
                AvaliableLbl.Visible = true;

            }
            else
            {
                AvaliableLbl.Text = "NO STock Avaliable  ";
                AvaliableLbl.Visible = true;

            }
        }

        private void PatientLBL_Click(object sender, EventArgs e)
        {
            Patient Pat = new Patient();
            Pat.Show();
            this.Hide();
        }

        private void BloodStockLBL_Click(object sender, EventArgs e)
        {
            Blood_Stock Bstock = new Blood_Stock();
            Bstock.Show();
            this.Hide();
        }

        private void DonorLBL_Click(object sender, EventArgs e)
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

        private void ViewPatientLBL_Click(object sender, EventArgs e)
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

        private void LogoutLBL_Click(object sender, EventArgs e)
        {

            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void Blood_Transfer_Load(object sender, EventArgs e)
        {

        }
    }
}

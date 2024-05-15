using System;
using System.Windows.Forms;
using WindowsFormsApp4;

namespace BloodBankManagementSystem
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }
        int move = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
            
        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            

        }


        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

       

        private void PanelMovable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            timerLoading.Interval = 20;
            PanelMovable.Width += 5;
            move += 5;

            if (move == 295)
            {
                timerLoading.Stop();
                Login log = new Login();
                log.Show();
                this.Hide();
            }

        }

        private void LoadingScreen_Load_1(object sender, EventArgs e)
        {
            //auto load timer without click
            timerLoading.Start();
        }
    }
}
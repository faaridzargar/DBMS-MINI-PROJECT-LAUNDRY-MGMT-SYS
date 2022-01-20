using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        bool isSlidingPanelExpanded;
        const int MaxSliderWidth = 140;
        const int MinSliderWidth = 70;
        private void button1_Click(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {

            }
            SlidingPanelTimer.Start();

        }

        private void SlidingPanelTimer_Tick(object sender, EventArgs e)
        {
            if (isSlidingPanelExpanded)
            {
                SlidingPanel.Width -= 30;
                if (SlidingPanel.Width <= MinSliderWidth)
                {
                    isSlidingPanelExpanded = false;
                    SlidingPanelTimer.Stop();

                    this.Refresh();
                }
            }
            else
            {
                SlidingPanel.Width += 30;
                if (SlidingPanel.Width >= MaxSliderWidth)
                {
                    isSlidingPanelExpanded = true;
                    SlidingPanelTimer.Stop();

                    this.Refresh();
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            this.Hide();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            this.Hide();
            obj.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form5 obj = new Form5();
            this.Hide();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zarga\source\repos\proj\proj\Database1.mdf;Integrated Security=True";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            MessageBox.Show("Connection Open  !");
            cnn.Close();
        }
    }
}

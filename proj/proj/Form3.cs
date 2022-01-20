using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proj
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }




        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zarga\source\repos\proj\proj\Database1.mdf;Integrated Security=True");


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sQQSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("ADDTRNS_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@NAME", textBox1.Text);
            cmd.Parameters.AddWithValue("@AGE", textBox2.Text);
            cmd.Parameters.AddWithValue("@ADDRESS", textBox3.Text);
            cmd.Parameters.AddWithValue("@NUMBER", textBox5.Text);
            cmd.Parameters.AddWithValue("@GENDER", textBox4.Text);
            cmd.Parameters.AddWithValue("@CUST_ID", textBox6.Text);
            cmd.Parameters.AddWithValue("NO_OF_CLOTHES", textBox7.Text);
            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("   <<<INVALID SQL OPERATION>>>: \n" + ex);
            }

            Form2 obj = new Form2();
            this.Hide();
            obj.Show();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            this.Hide();
            obj.Show();
        }
    }
}

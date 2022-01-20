using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace proj
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\zarga\source\repos\proj\proj\Database1.mdf;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("ADD_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CUST_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@DELIVERY_ID", textBox2.Text);
            cmd.Parameters.AddWithValue("@BILL_AMT", textBox3.Text);
            cmd.Parameters.AddWithValue("@NAME", textBox4.Text);
            cmd.Parameters.AddWithValue("@NUMBER", textBox5.Text);

            MessageBox.Show("ORDER PLACED  !");
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            this.Hide();
            obj.Show();
        }
    }
}

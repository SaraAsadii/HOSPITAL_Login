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

namespace HOSPITAL_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                SqlConnection sc = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\asadi\\source\\repos\\HOSPITAL1\\HOSPITAL1\\Database1.mdf;Integrated Security=True");
                sc.Open();
                SqlCommand comm = new SqlCommand("SELECT password FROM Login WHERE Username='" + username + "'", sc);
                SqlDataReader reader = comm.ExecuteReader();
                reader.Read();
                string pass = reader["Password"].ToString();
                if (password == pass)
                {
                    MessageBox.Show("Login successful");
                    Management me = new Management();
                    me.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("Incorrect");
                sc.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Incorrect");
            }
        }
    }
}

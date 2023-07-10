using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOSPITAL_Login
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }
        Form1 l = new Form1();
        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();
            l.Show();
            l.Close();
        }
    }
}

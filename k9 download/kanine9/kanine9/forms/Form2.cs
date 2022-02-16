using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kanine9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void siticonePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
              if (siticoneTextBox1.Text == "jqw197" && siticoneTextBox2.Text == "k9tester11")
            {
                MessageBox.Show("welcome tester.","K9");
                this.Hide();
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }
        }

        private void siticoneTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

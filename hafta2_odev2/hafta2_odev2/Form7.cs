using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta2_odev2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

            double x1 = (-b+ (Math.Sqrt((b * b) - 4 * a * c)))/ (2* a);
            double x2 = (b + (Math.Sqrt((b * b) - 4 * a * c))) / (2 * a);

            textBox4.Text = Convert.ToString(x1);
            textBox5.Text = Convert.ToString(x2);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                textBox2.Focus();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                textBox3.Focus();
            }

           /*if (e.KeyChar == (char)Keys.Escape)
            {
                textBox1.Focus();
            }

            if (Control.ModifierKeys == Keys.Control)
            {
                ((Control)textBox1).Focus();
                e.Handled = false;
            }

            if (e.KeyChar == (char)Keys.ControlKey)
            {
                textBox1.Focus();
                e.Handled = true; // Bu, tuşa basma olayının işlendiğini işaretler
            }*/

            if (Control.ModifierKeys == Keys.Control)
            {
                textBox1.Focus();
            }

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Yellow;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                textBox1.Focus();
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Yellow;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.White;
        }

        /*private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                textBox1.Focus();
            }
        }*/
    }
}

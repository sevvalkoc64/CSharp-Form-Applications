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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int h = Convert.ToInt32(textBox2.Text);
            int r = Convert.ToInt32(textBox3.Text);
            int pi = Convert.ToInt32(Math.PI);

            int tabanAlani = pi * (r * r);
            int yanalAlan = pi * r * a;
            int toplamYuzeyAlani = tabanAlani+yanalAlan;
            int hacim = ((pi * (r * r) * h) / 3);

            label4.Text ="Taban alanı: " + Convert.ToString(tabanAlani);
            label5.Text = "Yanal alan: " + Convert.ToString(yanalAlan);
            label6.Text = "Toplam yüzey alanı: " + Convert.ToString(toplamYuzeyAlani);
            label7.Text = "hacim: "+ Convert.ToString(hacim);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
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
    }
}

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
    public partial class Form4 : Form
    {
        public Form4()
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
            int r = Convert.ToInt32(textBox1.Text);
            int h = Convert.ToInt32(textBox2.Text);
            int pi = Convert.ToInt32( Math.PI) ;

            int tabanAlani = pi * (r * r);
            int yanalAlan = 2 * pi * r * h;
            int toplamYuzeyAlani = (2 * pi * (r * r)) + (2 * pi * r * h);
            int kesitAlani = 2 * pi * (r * r);
            int hacim = pi * (r * r) * h;

            label3.Text = "Taban alanı: " + Convert.ToInt32(tabanAlani);
            label4.Text = "Yanal alan: " + Convert.ToInt32(yanalAlan);
            label5.Text = "Toplam yüzey alanı: " + Convert.ToInt32(toplamYuzeyAlani);
            label6.Text = "Kesit alanı: " + Convert.ToInt32(kesitAlani);
            label7.Text = "Hacim: " + Convert.ToInt32(hacim);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar)== 13)
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
    }
}

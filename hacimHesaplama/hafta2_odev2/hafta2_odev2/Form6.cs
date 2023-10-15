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
    public partial class Form6 : Form
    {
        public Form6()
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
            int pi = Convert.ToInt32(Math.PI);

            int yuzeyAlani = 4 * pi * (r * r);
            int kesitAlani = pi * (r * r);
            int hacim = (4 * pi * (r * r * r))/3;

            label2.Text = "Yüzey alanı: "+Convert.ToString(yuzeyAlani);
            label3.Text = "Kesit alanı: " + Convert.ToString(kesitAlani);
            label4.Text = "Hacim: " + Convert.ToString(hacim);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }
    }
}

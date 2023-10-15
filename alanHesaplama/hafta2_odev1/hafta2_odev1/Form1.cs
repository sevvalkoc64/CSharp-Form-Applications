using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hafta2_odev1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int sonuc = a + b + c;
            textBox4.Text = Convert.ToString(sonuc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox8.Text);
            int b = Convert.ToInt32(textBox7.Text);
            int CevreSonuc = 2*(a + b) ;
            int AlanSonuc = a * b;
            textBox5.Text = Convert.ToString(CevreSonuc);
            textBox6.Text = Convert.ToString(AlanSonuc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox15.Text);
            int AlanSonuc = a * a;
            int CevreSonuc = a * 4;
            textBox13.Text = Convert.ToString(CevreSonuc);
            textBox14.Text = Convert.ToString(AlanSonuc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(textBox12.Text);
            int pi = Convert.ToInt32(textBox11.Text);
            int CevreSonuc = 2 * pi * r;
            int AlanSonuc = pi * (r * r);
            textBox9.Text = Convert.ToString(CevreSonuc);
            textBox10.Text = Convert.ToString(AlanSonuc);

        }
    }
}

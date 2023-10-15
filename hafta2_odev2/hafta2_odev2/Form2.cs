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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int yuzeyAlani = 6 * (a * a);
            int kesitAlani = a * a;
            int hacim = a * a * a;

            label2.Text = "Yüzey alanı: " + Convert.ToString(yuzeyAlani);
            label3.Text = "Kesit alanı: " + Convert.ToString(kesitAlani);
            label4.Text = "Küp hacmi: " + Convert.ToString(hacim);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }
    }
}
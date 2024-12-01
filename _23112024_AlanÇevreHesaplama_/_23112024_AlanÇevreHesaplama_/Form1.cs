using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23112024_AlanÇevreHesaplama_
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
            panel1.Visible = true;
            label8.Visible = false;
            textBox3.Visible = false;
            textBox4.Text = " ";
            button5.Visible = false;
            button6.Visible = true;
            label13.Text = "Bir Kenar Giriniz";
            label11.Text = " ";
            label9.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, çevre;

            birkenar = Convert.ToInt32(textBox4.Text);

            alan = birkenar * birkenar;
            çevre = 4 * birkenar;

            label11.Text = alan.ToString();
            label9.Text = çevre.ToString();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, çevre;

            birkenar = Convert.ToInt32(textBox4.Text);

            alan = birkenar * birkenar;
            çevre = 4 * birkenar;

            label11.Text = alan.ToString();
            label9.Text = çevre.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label13.Text = "Kısa Kenar";
            panel1.Visible = true;
            button6.Visible = false;
            button5.Visible = true;
            label8.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox4.Text = " ";
            textBox3.Text = " ";
            label11.Text = " ";
            label9.Text = " ";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            int uzunkenar, kısakenar;
            int alan, çevre;
            
            uzunkenar = Convert.ToInt32(textBox3.Text);
            kısakenar = Convert.ToInt32(textBox4.Text);

            alan = uzunkenar * kısakenar;
            çevre = (2 * kısakenar) + (2 * uzunkenar);

            label9.Text = çevre.ToString();
            label11.Text = alan.ToString();
            
        }
    }
}

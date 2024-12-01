using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23112024_OrtalamaHesaplama_
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
           
            double sınav1, sınav2, ortalama;

            sınav1 = Convert.ToDouble(textBox3.Text);
            sınav2 = Convert.ToDouble(textBox2.Text);

            ortalama = (sınav1*2/5 + sınav2*3/5);

            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox3.Text);
            listBox3.Items.Add(textBox2.Text);
            listBox4.Items.Add(ortalama);

            if (ortalama >= 50)
            {
                listBox5.Items.Add("Geçti");
            }
            else
            {
                listBox5.Items.Add("Kaldı");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
        }
    }
}

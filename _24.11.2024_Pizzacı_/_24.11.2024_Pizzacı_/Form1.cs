using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24._11._2024_Pizzacı_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Checked = true;
                label13.Text = checkBox1.Text;
            }
            else
            {
                checkBox1.Checked = false;
                label13.Text = " ";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox3.Checked = true;
                label15.Text = checkBox3.Text;
            }
            else
            {
                checkBox3.Checked = false;
                label15.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text);
            listBox5.Items.Add(comboBox2.Text);
            listBox6.Items.Add(label13.Text + " " + label14.Text + " " + label15.Text + " " + label16.Text + " " + label17.Text + " " + label18.Text + " " + label19.Text + " " + label20.Text);
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox2.Checked = true;
                label14.Text = checkBox2.Text;
            }
            else
            {
                checkBox2.Checked = false;
                label14.Text = " ";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox4.Checked = true;
                label16.Text = checkBox4.Text;
            }
            else
            {
                checkBox4.Checked = false;
                label16.Text = " ";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                checkBox5.Checked = true;
                label17.Text = checkBox5.Text;
            }
            else
            {
                checkBox5.Checked = false;
                label17.Text = " ";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox6.Checked = true;
                label18.Text = checkBox6.Text;
            }
            else
            {
                checkBox6.Checked = false;
                label18.Text = " ";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                checkBox7.Checked = true;
                label19.Text = checkBox7.Text;
            }
            else
            {
                checkBox7.Checked = false;
                label19.Text = " ";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                checkBox8.Checked = true;
                label20.Text = checkBox8.Text;

            }
            else
            {
                checkBox8.Checked = false;
                label20.Text = " ";
            }

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        
        }
        

        

        


    }
}

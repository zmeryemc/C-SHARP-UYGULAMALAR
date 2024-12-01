using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27._11._2024_CSharpRandomLig_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();

        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label5.Text = a.ToString();
            label6.Text = b.ToString();
            label7.Text = c.ToString();
            label8.Text = d.ToString();

            if (Convert.ToInt32(label5.Text) > Convert.ToInt32(label6.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            if (Convert.ToInt32 (label6.Text) > Convert.ToInt32(label5.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32 (label5.Text) == Convert.ToInt32(label6.Text))
            {
                gspuan = gspuan + 1;
                fbpuan = fbpuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(label7.Text) > Convert.ToInt32(label8.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label7.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label7.Text) == Convert.ToInt32(label8.Text))
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                labelbjkpuan.Text = bjkpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            
            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label16.Text = a.ToString();
            label15.Text = b.ToString();
            label14.Text = c.ToString();
            label13.Text = d.ToString();

            if (Convert.ToInt32(label16.Text) > Convert.ToInt32(label15.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(label15.Text) > Convert.ToInt32(label16.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if (Convert.ToInt32(label15.Text) == Convert.ToInt32(label16.Text))
            {
                gspuan = gspuan + 1;
                bjkpuan = bjkpuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if(Convert.ToInt32(label14.Text) > Convert.ToInt32(label13.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(label13.Text) > Convert.ToInt32(label14.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }

            if (Convert.ToInt32(label13.Text) == Convert.ToInt32(label14.Text))
            {
                fbpuan = fbpuan + 1;
                tspuan = tspuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button4.Visible = true;

            int a = rastgele.Next(0, 5);
            int b = rastgele.Next(0, 5);
            int c = rastgele.Next(0, 5);
            int d = rastgele.Next(0, 5);

            label30.Text = a.ToString();
            label29.Text = b.ToString();
            label28.Text = c.ToString();
            label27.Text = d.ToString();

            if (Convert.ToInt32(label30.Text) > Convert.ToInt32(label29.Text))
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }

            if (Convert.ToInt32(label29.Text) > Convert.ToInt32(label30.Text))
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if (Convert.ToInt32(label29.Text) == Convert.ToInt32(label30.Text))
            {
                fbpuan = fbpuan + 1;
                bjkpuan = bjkpuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }

            if(Convert.ToInt32(label28.Text) > Convert.ToInt32(label27.Text))
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }

            if(Convert.ToInt32(label27.Text) > Convert.ToInt32(label28.Text))
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }

            if (Convert.ToInt32(label27.Text) == Convert.ToInt32(label28.Text))
            {
                tspuan = tspuan + 1;
                gspuan = gspuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelgspuan.Text = gspuan.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelgspuan.Text) > Convert.ToInt32(labeltspuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\calis\\OneDrive\\Desktop\\gs.mp3";
                label35.Text = "ŞAMPİYON GALATASARAY";
                pictureBox1.ImageLocation = "C:\\Users\\calis\\OneDrive\\Desktop\\Picture Box\\gs.jpg";
            }

            if (Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labelbjkpuan.Text) && Convert.ToInt32(labelfbpuan.Text) > Convert.ToInt32(labeltspuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\calis\\OneDrive\\Desktop\\fb.mp3";
                label35.Text = "ŞAMPİYON FENERBAHÇE";
                pictureBox1.ImageLocation = "C:\\Users\\calis\\OneDrive\\Desktop\\Picture Box\\fb.jpg";

            }

            if (Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labelbjkpuan.Text) > Convert.ToInt32(labeltspuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\Users\\calis\\OneDrive\\Desktop\\bjk.mp3";
                label35.Text = "ŞAMPİYON BEŞİKTAŞ";
                pictureBox1.ImageLocation = "C:\\Users\\calis\\OneDrive\\Desktop\\Picture Box\\bjk.jpg";
            }

            if (Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelgspuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelfbpuan.Text) && Convert.ToInt32(labeltspuan.Text) > Convert.ToInt32(labelbjkpuan.Text))
            {
                axWindowsMediaPlayer1.URL = "C:\\\\Users\\\\calis\\\\OneDrive\\\\Desktop\\ts.mp3";
                label35.Text = "ŞAMPİYON TRABZONSPOR";
                pictureBox1.ImageLocation = "C:\\Users\\calis\\OneDrive\\Desktop\\Picture Box\\ts.jpg";

            }
        }

    }
}

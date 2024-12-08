using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialPortBağlama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var seriPort in SerialPort.GetPortNames())
            {
                ComboBoxPorts.Items.Add(seriPort);
            }
            ComboBoxPorts.SelectedIndex = 0;
            ButtonDisconnect.Enabled = false;
            ButtonSend.Enabled = false;

        }

        private void ButtonConnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = ComboBoxPorts.Text;
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.Even;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;

           try
            {
                serialPort1.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Seri Port Bağlantısı Yapılamadı\n Hata: {ex.Message}", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (serialPort1.IsOpen)
            {
                ButtonConnect.Enabled = false;
                ButtonDisconnect.Enabled = true;
                ButtonSend.Enabled = true;
            }
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                ButtonConnect.Enabled = true;
                ButtonDisconnect.Enabled = false;
                ButtonSend.Enabled = false;
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(SendMessage.Text);
                SendMessage.Clear();
            }
        }
        public delegate void veriGöster(String s);

        
        public void textboxyaz(string s)
        {
            ReceivedData.Text += s;
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string gelenveri = serialPort1.ReadExisting();
            ReceivedData.Invoke(new veriGöster(textboxyaz), gelenveri);
        }
    }
}

namespace SerialPortBağlama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ComboBoxPorts = new System.Windows.Forms.ComboBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.ButtonDisconnect = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ReceivedData = new System.Windows.Forms.TextBox();
            this.SendMessage = new System.Windows.Forms.TextBox();
            this.ButtonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxPorts
            // 
            this.ComboBoxPorts.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ComboBoxPorts.FormattingEnabled = true;
            this.ComboBoxPorts.Location = new System.Drawing.Point(96, 54);
            this.ComboBoxPorts.Name = "ComboBoxPorts";
            this.ComboBoxPorts.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxPorts.TabIndex = 0;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonConnect.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConnect.Location = new System.Drawing.Point(238, 38);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(128, 47);
            this.ButtonConnect.TabIndex = 1;
            this.ButtonConnect.Text = "BAĞLAN";
            this.ButtonConnect.UseVisualStyleBackColor = false;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // ButtonDisconnect
            // 
            this.ButtonDisconnect.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonDisconnect.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDisconnect.Location = new System.Drawing.Point(372, 38);
            this.ButtonDisconnect.Name = "ButtonDisconnect";
            this.ButtonDisconnect.Size = new System.Drawing.Size(128, 47);
            this.ButtonDisconnect.TabIndex = 2;
            this.ButtonDisconnect.Text = "KES";
            this.ButtonDisconnect.UseVisualStyleBackColor = false;
            this.ButtonDisconnect.Click += new System.EventHandler(this.ButtonDisconnect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ReceivedData
            // 
            this.ReceivedData.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReceivedData.Location = new System.Drawing.Point(37, 113);
            this.ReceivedData.Multiline = true;
            this.ReceivedData.Name = "ReceivedData";
            this.ReceivedData.Size = new System.Drawing.Size(528, 296);
            this.ReceivedData.TabIndex = 3;
            // 
            // SendMessage
            // 
            this.SendMessage.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SendMessage.Location = new System.Drawing.Point(37, 441);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(321, 20);
            this.SendMessage.TabIndex = 4;
            // 
            // ButtonSend
            // 
            this.ButtonSend.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ButtonSend.Font = new System.Drawing.Font("Maiandra GD", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSend.Location = new System.Drawing.Point(396, 428);
            this.ButtonSend.Name = "ButtonSend";
            this.ButtonSend.Size = new System.Drawing.Size(169, 45);
            this.ButtonSend.TabIndex = 5;
            this.ButtonSend.Text = "GÖNDER";
            this.ButtonSend.UseVisualStyleBackColor = false;
            this.ButtonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 756);
            this.Controls.Add(this.ButtonSend);
            this.Controls.Add(this.SendMessage);
            this.Controls.Add(this.ReceivedData);
            this.Controls.Add(this.ButtonDisconnect);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.ComboBoxPorts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxPorts;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.Button ButtonDisconnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox ReceivedData;
        private System.Windows.Forms.TextBox SendMessage;
        private System.Windows.Forms.Button ButtonSend;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace Exemplo_serial_port
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public string COM_port;
        public Int32 BaudRate;
        int dataBitsBARI = 8;
        Handshake handshakeBARI = Handshake.None;
        Parity parityBARI = Parity.None;
        StopBits stopBitsBARI = StopBits.One;

        private void button1_Click(object sender, EventArgs e)
        {
            COM_port = Convert.ToString(comboBox_port.SelectedItem);
            BaudRate = Convert.ToInt32(comboBox_baude_rate.SelectedItem);

           
            serialPort1.DataBits = dataBitsBARI;
            serialPort1.Handshake = handshakeBARI;
            serialPort1.Parity = parityBARI;
            serialPort1.StopBits = stopBitsBARI;
          
            serialPort1.ReadTimeout = 100;
            serialPort1.WriteTimeout = 100;

            serialPort1.PortName = COM_port;
            serialPort1.BaudRate = BaudRate;
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                
                serialPort1.Write(textBox_input + "\n");
                System.Threading.Thread.Sleep(100);

                textBox_output.Text += serialPort1.ReadExisting(); // ler o output do log 
                textBox_output.Refresh();
                serialPort1.Close();
            }
        }
    }
}

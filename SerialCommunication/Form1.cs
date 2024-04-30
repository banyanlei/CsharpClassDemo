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

namespace SerialCommunication
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.DataReceived += SerialPort_DataReceived;
        }
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // 从串口接收数据
            string receivedData = serialPort.ReadLine();

            // 在接收文本框中显示接收到的数据
            AppendTextToReceivedBox(receivedData);
        }
        private void AppendTextToReceivedBox(string text)
        {
            if (txtReceived.InvokeRequired)
            {
                txtReceived.Invoke(new Action<string>(AppendTextToReceivedBox), text);
            }
            else
            {
                txtReceived.AppendText(text + Environment.NewLine);
            }
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            serialPort.PortName = ComInput.Text; // 串口号
            serialPort.BaudRate = 9600;   // 波特率
            serialPort.Parity = Parity.None; // 校验位
            serialPort.DataBits = 8;       // 数据位
            serialPort.StopBits = StopBits.One; // 停止位
            try
            {
                // 打开串口
                serialPort.Open();
                Connect.Enabled = false;
                Close.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            // 发送数据到串口
            string data = txtSend.Text;
            serialPort.WriteLine(data);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void Close_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                Connect.Enabled = true;
                Close.Enabled = false;
            }
        }
    }
}

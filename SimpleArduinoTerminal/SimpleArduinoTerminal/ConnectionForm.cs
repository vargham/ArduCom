using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleArduinoTerminal
{
    public partial class ConnectionForm : Form
    {
        private SerialPort port;
        private TerminalForm terminalForm;

        public ConnectionForm()
        {
            InitializeComponent();
            FormClosing += ConnectionForm_FormClosing;
            this.terminalForm = new TerminalForm(this);
            this.terminalForm.Show();
            createAndOpenPort("COM27", 9600, false);
        }

        public void SendToPort(string data)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(data);
            this.port.Write(asciiBytes, 0, asciiBytes.Length);
        }

        private void createAndOpenPort(string portName, int baud, bool dtrState)
        {
            if (this.port != null && this.port.IsOpen) this.port.Close();
            this.port = new SerialPort(portName);
            port.DtrEnable = dtrState;
            port.BaudRate = baud;
            port.DataReceived += Port_DataReceived;
            this.port.Open();
        }

        private void ConnectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.port.IsOpen) this.port.Close();
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.terminalForm.ReceiveSerialData(this.port.ReadExisting());
        }
        
    }
}

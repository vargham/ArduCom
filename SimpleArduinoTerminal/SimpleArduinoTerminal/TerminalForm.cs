using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleArduinoTerminal
{
    public partial class TerminalForm : Form
    {
        #region Disable form's close button
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        #endregion

        private ConnectionForm connectionForm;

        public TerminalForm()
        {
            InitializeComponent();
        }

        public TerminalForm(ConnectionForm connectionForm)
        {
            this.connectionForm = connectionForm;
            InitializeComponent();
        }

        public void ReceiveSerialData(string data)
        {
            Invoke(new Action(() => updateIncomingTextBox(data)));
        }

        public void updateIncomingTextBox(string data)
        {
            this.textBoxInput.AppendText(data);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (this.textBoxMessage.Text != "")
            {
                this.connectionForm.SendToPort(this.textBoxMessage.Text);
                this.textBoxOutput.AppendText(this.textBoxMessage.Text);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            this.textBoxInput.Clear();
            this.textBoxOutput.Clear();
        }
    }
}

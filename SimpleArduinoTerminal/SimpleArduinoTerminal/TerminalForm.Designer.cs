namespace SimpleArduinoTerminal
{
    partial class TerminalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelTerminal = new System.Windows.Forms.TableLayoutPanel();
            this.labelIn = new System.Windows.Forms.Label();
            this.flowLayoutPanelSend = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.labelOut = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tableLayoutPanelTerminal.SuspendLayout();
            this.flowLayoutPanelSend.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTerminal
            // 
            this.tableLayoutPanelTerminal.ColumnCount = 2;
            this.tableLayoutPanelTerminal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTerminal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelTerminal.Controls.Add(this.textBoxMessage, 0, 2);
            this.tableLayoutPanelTerminal.Controls.Add(this.labelIn, 1, 0);
            this.tableLayoutPanelTerminal.Controls.Add(this.textBoxOutput, 0, 1);
            this.tableLayoutPanelTerminal.Controls.Add(this.textBoxInput, 1, 1);
            this.tableLayoutPanelTerminal.Controls.Add(this.labelOut, 0, 0);
            this.tableLayoutPanelTerminal.Controls.Add(this.flowLayoutPanelSend, 1, 2);
            this.tableLayoutPanelTerminal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTerminal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTerminal.Name = "tableLayoutPanelTerminal";
            this.tableLayoutPanelTerminal.RowCount = 3;
            this.tableLayoutPanelTerminal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelTerminal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanelTerminal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelTerminal.Size = new System.Drawing.Size(624, 441);
            this.tableLayoutPanelTerminal.TabIndex = 0;
            // 
            // labelIn
            // 
            this.labelIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelIn.AutoSize = true;
            this.labelIn.Location = new System.Drawing.Point(459, 11);
            this.labelIn.Name = "labelIn";
            this.labelIn.Size = new System.Drawing.Size(18, 13);
            this.labelIn.TabIndex = 4;
            this.labelIn.Text = "IN";
            // 
            // flowLayoutPanelSend
            // 
            this.flowLayoutPanelSend.Controls.Add(this.buttonSend);
            this.flowLayoutPanelSend.Controls.Add(this.buttonClear);
            this.flowLayoutPanelSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSend.Location = new System.Drawing.Point(312, 405);
            this.flowLayoutPanelSend.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelSend.Name = "flowLayoutPanelSend";
            this.flowLayoutPanelSend.Size = new System.Drawing.Size(312, 36);
            this.flowLayoutPanelSend.TabIndex = 0;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxMessage.Location = new System.Drawing.Point(3, 408);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(306, 20);
            this.textBoxMessage.TabIndex = 0;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(3, 3);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(60, 20);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOutput.Location = new System.Drawing.Point(3, 38);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(306, 364);
            this.textBoxOutput.TabIndex = 1;
            this.textBoxOutput.WordWrap = false;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInput.Location = new System.Drawing.Point(315, 38);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ReadOnly = true;
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxInput.Size = new System.Drawing.Size(306, 364);
            this.textBoxInput.TabIndex = 2;
            this.textBoxInput.WordWrap = false;
            // 
            // labelOut
            // 
            this.labelOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOut.AutoSize = true;
            this.labelOut.Location = new System.Drawing.Point(141, 11);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(30, 13);
            this.labelOut.TabIndex = 3;
            this.labelOut.Text = "OUT";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(69, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 20);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // TerminalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.tableLayoutPanelTerminal);
            this.Name = "TerminalForm";
            this.Text = "Terminal window";
            this.tableLayoutPanelTerminal.ResumeLayout(false);
            this.tableLayoutPanelTerminal.PerformLayout();
            this.flowLayoutPanelSend.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTerminal;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSend;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label labelIn;
        private System.Windows.Forms.Label labelOut;
        private System.Windows.Forms.Button buttonClear;
    }
}
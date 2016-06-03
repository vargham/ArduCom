namespace SimpleArduinoTerminal
{
    partial class ConnectionForm
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
            this.flowLayoutPanelConnectionOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanelConnectionOptions
            // 
            this.flowLayoutPanelConnectionOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelConnectionOptions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelConnectionOptions.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelConnectionOptions.Name = "flowLayoutPanelConnectionOptions";
            this.flowLayoutPanelConnectionOptions.Size = new System.Drawing.Size(284, 441);
            this.flowLayoutPanelConnectionOptions.TabIndex = 0;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 441);
            this.Controls.Add(this.flowLayoutPanelConnectionOptions);
            this.Name = "ConnectionForm";
            this.Text = "Simple terminal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelConnectionOptions;
    }
}


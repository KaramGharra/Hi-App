namespace TCPStreamer
{
    partial class eeeForm1
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
            this.tcpsControl1 = new TCPStreamer.TCPSControl();
            this.SuspendLayout();
            // 
            // tcpsControl1
            // 
            this.tcpsControl1.Location = new System.Drawing.Point(12, -1);
            this.tcpsControl1.Name = "tcpsControl1";
            this.tcpsControl1.Size = new System.Drawing.Size(400, 561);
            this.tcpsControl1.TabIndex = 0;
            this.tcpsControl1.Load += new System.EventHandler(this.tcpsControl1_Load);
            // 
            // eeeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 572);
            this.Controls.Add(this.tcpsControl1);
            this.Name = "eeeForm1";
            this.Text = "eeeForm1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.eeeForm1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.eeeForm1_FormClosed);
            this.Load += new System.EventHandler(this.eeeForm1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public TCPSControl tcpsControl1;
    }
}
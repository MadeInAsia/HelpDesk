namespace HelpDesk
{
    partial class WinUserTicketMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinUserTicketMenu));
            this.menuPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbDetails = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbWorker = new System.Windows.Forms.Label();
            this.lbDevice = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbTopic = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(50)))));
            this.menuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuPanel.BackgroundImage")));
            this.menuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuPanel.BorderColor = System.Drawing.Color.Transparent;
            this.menuPanel.BorderRadius = 30;
            this.menuPanel.BorderThickness = 1;
            this.menuPanel.Controls.Add(this.label5);
            this.menuPanel.Controls.Add(this.textBox4);
            this.menuPanel.Controls.Add(this.tbDetails);
            this.menuPanel.Controls.Add(this.lbDate);
            this.menuPanel.Controls.Add(this.lbWorker);
            this.menuPanel.Controls.Add(this.lbDevice);
            this.menuPanel.Controls.Add(this.lbType);
            this.menuPanel.Controls.Add(this.lbTopic);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.ShowBorders = true;
            this.menuPanel.Size = new System.Drawing.Size(620, 427);
            this.menuPanel.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(28, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Support Comment:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(31, 105);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(558, 134);
            this.textBox4.TabIndex = 12;
            // 
            // tbDetails
            // 
            this.tbDetails.Location = new System.Drawing.Point(31, 262);
            this.tbDetails.Multiline = true;
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.Size = new System.Drawing.Size(558, 141);
            this.tbDetails.TabIndex = 11;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbDate.Location = new System.Drawing.Point(441, 56);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(85, 17);
            this.lbDate.TabIndex = 10;
            this.lbDate.Text = "Open Date: ";
            // 
            // lbWorker
            // 
            this.lbWorker.AutoSize = true;
            this.lbWorker.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWorker.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbWorker.Location = new System.Drawing.Point(28, 73);
            this.lbWorker.Name = "lbWorker";
            this.lbWorker.Size = new System.Drawing.Size(156, 17);
            this.lbWorker.TabIndex = 9;
            this.lbWorker.Text = "Assigned Worker: none";
            // 
            // lbDevice
            // 
            this.lbDevice.AutoSize = true;
            this.lbDevice.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbDevice.Location = new System.Drawing.Point(28, 56);
            this.lbDevice.Name = "lbDevice";
            this.lbDevice.Size = new System.Drawing.Size(60, 17);
            this.lbDevice.TabIndex = 8;
            this.lbDevice.Text = "Device: ";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbType.Location = new System.Drawing.Point(28, 39);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(39, 17);
            this.lbType.TabIndex = 6;
            this.lbType.Text = "Type";
            // 
            // lbTopic
            // 
            this.lbTopic.AutoSize = true;
            this.lbTopic.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopic.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTopic.Location = new System.Drawing.Point(28, 22);
            this.lbTopic.Name = "lbTopic";
            this.lbTopic.Size = new System.Drawing.Size(43, 17);
            this.lbTopic.TabIndex = 4;
            this.lbTopic.Text = "Topic";
            // 
            // WinUserTicketMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(620, 427);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WinUserTicketMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserTicketMenu";
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel menuPanel;
        private System.Windows.Forms.Label lbDevice;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.Label lbWorker;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbDetails;
        private System.Windows.Forms.Label label5;
    }
}
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
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ticketInfo = new System.Windows.Forms.TextBox();
            this.tbDetails = new System.Windows.Forms.TextBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbWorker = new System.Windows.Forms.Label();
            this.lbDevice = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lbTopic = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
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
            this.menuPanel.Controls.Add(this.backBtn);
            this.menuPanel.Controls.Add(this.label5);
            this.menuPanel.Controls.Add(this.ticketInfo);
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
            // backBtn
            // 
            this.backBtn.Image = global::HelpDesk.Properties.Resources.icons8_zurück_48;
            this.backBtn.Location = new System.Drawing.Point(555, 15);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(40, 42);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBtn.TabIndex = 14;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(24, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Support Comment:";
            // 
            // ticketInfo
            // 
            this.ticketInfo.Location = new System.Drawing.Point(27, 106);
            this.ticketInfo.Multiline = true;
            this.ticketInfo.Name = "ticketInfo";
            this.ticketInfo.Size = new System.Drawing.Size(558, 134);
            this.ticketInfo.TabIndex = 12;
            // 
            // tbDetails
            // 
            this.tbDetails.Location = new System.Drawing.Point(27, 263);
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
            this.lbDate.Location = new System.Drawing.Point(437, 57);
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
            this.lbWorker.Location = new System.Drawing.Point(24, 74);
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
            this.lbDevice.Location = new System.Drawing.Point(24, 57);
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
            this.lbType.Location = new System.Drawing.Point(24, 40);
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
            this.lbTopic.Location = new System.Drawing.Point(24, 23);
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
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel menuPanel;
        private System.Windows.Forms.Label lbDevice;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.Label lbWorker;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox ticketInfo;
        private System.Windows.Forms.TextBox tbDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox backBtn;
    }
}
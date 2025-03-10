namespace HelpDesk
{
    partial class WinAdminComments
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
            this.flpComments = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpComments
            // 
            this.flpComments.AutoScroll = true;
            this.flpComments.AutoSize = true;
            this.flpComments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(245)))), ((int)(((byte)(253)))));
            this.flpComments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpComments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpComments.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpComments.Location = new System.Drawing.Point(0, 0);
            this.flpComments.Name = "flpComments";
            this.flpComments.Size = new System.Drawing.Size(477, 499);
            this.flpComments.TabIndex = 0;
            this.flpComments.WrapContents = false;
            // 
            // WinAdminComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 499);
            this.Controls.Add(this.flpComments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(215, 66);
            this.Name = "WinAdminComments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TICKET UPDATES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpComments;
    }
}
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
            this.lbComments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbComments
            // 
            this.lbComments.FormattingEnabled = true;
            this.lbComments.Location = new System.Drawing.Point(352, 124);
            this.lbComments.Name = "lbComments";
            this.lbComments.Size = new System.Drawing.Size(431, 316);
            this.lbComments.TabIndex = 0;
            // 
            // WinAdminComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 648);
            this.Controls.Add(this.lbComments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(215, 66);
            this.Name = "WinAdminComments";
            this.Text = "WinAdminMessages";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbComments;
    }
}
namespace HelpDesk
{
    partial class WinAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinAdmin));
            this.labelAdmin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuRadialGauge1 = new Bunifu.UI.WinForms.BunifuRadialGauge();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuRating1 = new Bunifu.UI.WinForms.BunifuRating();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Montserrat Medium", 12F);
            this.labelAdmin.Location = new System.Drawing.Point(47, 147);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(65, 22);
            this.labelAdmin.TabIndex = 0;
            this.labelAdmin.Text = "Admin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 60);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.bunifuRadialGauge1);
            this.panel2.Location = new System.Drawing.Point(156, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 494);
            this.panel2.TabIndex = 2;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = false;
            this.bunifuPictureBox1.BorderRadius = 34;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = false;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(40, 69);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(79, 79);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 3;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuRadialGauge1
            // 
            this.bunifuRadialGauge1.AutoGenerateProgressColorWhenHigh = true;
            this.bunifuRadialGauge1.AutoGenerateProgressColorWhenLow = false;
            this.bunifuRadialGauge1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRadialGauge1.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.bunifuRadialGauge1.LighteningFactor = 70;
            this.bunifuRadialGauge1.Location = new System.Drawing.Point(361, 8);
            this.bunifuRadialGauge1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.bunifuRadialGauge1.Maximum = 100;
            this.bunifuRadialGauge1.Minimum = 0;
            this.bunifuRadialGauge1.Name = "bunifuRadialGauge1";
            this.bunifuRadialGauge1.Prefix = "";
            this.bunifuRadialGauge1.ProgressBackColor = System.Drawing.Color.LightBlue;
            this.bunifuRadialGauge1.ProgressBgColor = System.Drawing.Color.LightBlue;
            this.bunifuRadialGauge1.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Flat;
            this.bunifuRadialGauge1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge1.ProgressColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge1.ProgressColor2 = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge1.ProgressColorHigh = System.Drawing.Color.Crimson;
            this.bunifuRadialGauge1.ProgressColorLow = System.Drawing.Color.DodgerBlue;
            this.bunifuRadialGauge1.ProgressHighValueMark = 70;
            this.bunifuRadialGauge1.RangeEnd = 100;
            this.bunifuRadialGauge1.RangeLabelsColor = System.Drawing.SystemColors.ControlText;
            this.bunifuRadialGauge1.RangeLabelsFont = new System.Drawing.Font("Segoe UI", 8F);
            this.bunifuRadialGauge1.RangeStart = 0;
            this.bunifuRadialGauge1.ShowRangeLabels = true;
            this.bunifuRadialGauge1.ShowValueLabel = true;
            this.bunifuRadialGauge1.Size = new System.Drawing.Size(189, 126);
            this.bunifuRadialGauge1.Suffix = "%";
            this.bunifuRadialGauge1.TabIndex = 0;
            this.bunifuRadialGauge1.Thickness = 30;
            this.bunifuRadialGauge1.Value = 40;
            this.bunifuRadialGauge1.ValueByTransition = 40;
            this.bunifuRadialGauge1.ValueLabelColor = System.Drawing.SystemColors.ControlText;
            this.bunifuRadialGauge1.WarningMark = 70;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(245)))), ((int)(((byte)(242)))));
            this.panel3.Location = new System.Drawing.Point(741, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(293, 494);
            this.panel3.TabIndex = 3;
            // 
            // bunifuRating1
            // 
            this.bunifuRating1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuRating1.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bunifuRating1.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.bunifuRating1.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bunifuRating1.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.bunifuRating1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bunifuRating1.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bunifuRating1.InnerRadius = 2F;
            this.bunifuRating1.Location = new System.Drawing.Point(40, 172);
            this.bunifuRating1.Name = "bunifuRating1";
            this.bunifuRating1.OuterRadius = 7F;
            this.bunifuRating1.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bunifuRating1.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.bunifuRating1.ReadOnly = false;
            this.bunifuRating1.RightClickToClear = true;
            this.bunifuRating1.Size = new System.Drawing.Size(91, 16);
            this.bunifuRating1.TabIndex = 1;
            this.bunifuRating1.Text = "bunifuRating1";
            this.bunifuRating1.Value = 3;
            // 
            // WinAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(134)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1043, 572);
            this.Controls.Add(this.bunifuRating1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WinAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuRadialGauge bunifuRadialGauge1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuRating bunifuRating1;
    }
}
namespace HelpDesk
{
    partial class WinAdminStats
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinAdminStats));
            this.bunifuDoughnutChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuDoughnutChart(this.components);
            this.bunifuProgressBar1 = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuDoughnutChart1
            // 
            this.bunifuDoughnutChart1.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuDoughnutChart1.BackgroundColor")));
            this.bunifuDoughnutChart1.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuDoughnutChart1.BorderColor")));
            this.bunifuDoughnutChart1.BorderWidth = 0;
            this.bunifuDoughnutChart1.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("bunifuDoughnutChart1.Data")));
            this.bunifuDoughnutChart1.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuDoughnutChart1.HoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuDoughnutChart1.HoverBorderWidth = 0;
            this.bunifuDoughnutChart1.Label = "label here";
            this.bunifuDoughnutChart1.TargetCanvas = null;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.AllowAnimations = false;
            this.bunifuProgressBar1.Animation = 0;
            this.bunifuProgressBar1.AnimationSpeed = 220;
            this.bunifuProgressBar1.AnimationStep = 10;
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuProgressBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuProgressBar1.BackgroundImage")));
            this.bunifuProgressBar1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuProgressBar1.BorderRadius = 9;
            this.bunifuProgressBar1.BorderThickness = 1;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(352, 279);
            this.bunifuProgressBar1.Maximum = 100;
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Minimum = 0;
            this.bunifuProgressBar1.MinimumValue = 0;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.bunifuProgressBar1.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.bunifuProgressBar1.ProgressColorLeft = System.Drawing.Color.DodgerBlue;
            this.bunifuProgressBar1.ProgressColorRight = System.Drawing.Color.DodgerBlue;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(285, 13);
            this.bunifuProgressBar1.TabIndex = 0;
            this.bunifuProgressBar1.Value = 50;
            this.bunifuProgressBar1.ValueByTransition = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOADING . . .";
            // 
            // WinAdminStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 648);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(215, 66);
            this.Name = "WinAdminStats";
            this.Text = "WinAdminStats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Charts.WinForms.ChartTypes.BunifuDoughnutChart bunifuDoughnutChart1;
        private Bunifu.UI.WinForms.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Label label1;
    }
}
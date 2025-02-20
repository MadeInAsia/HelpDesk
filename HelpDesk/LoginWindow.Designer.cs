namespace HelpDesk
{
    partial class LoginWindow
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.UsernameText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.clearAll = new System.Windows.Forms.Label();
            this.PwdText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(78, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOG IN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 234);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 3);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // UsernameText
            // 
            this.UsernameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.UsernameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameText.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.UsernameText.Location = new System.Drawing.Point(59, 197);
            this.UsernameText.Multiline = true;
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(246, 31);
            this.UsernameText.TabIndex = 5;
            this.UsernameText.Text = "Username";
            this.UsernameText.TextChanged += new System.EventHandler(this.UsernameText_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(22, 319);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(300, 3);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HelpDesk.Properties.Resources.icons8_anmelden_abgerundet_rechts_50;
            this.pictureBox1.Location = new System.Drawing.Point(143, 375);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HelpDesk.Properties.Resources.icons8_sperren_50__2_;
            this.pictureBox3.Location = new System.Drawing.Point(22, 282);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HelpDesk.Properties.Resources.icons8_benutzer_50__1_;
            this.pictureBox2.Location = new System.Drawing.Point(22, 197);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // clearAll
            // 
            this.clearAll.AutoSize = true;
            this.clearAll.Font = new System.Drawing.Font("Impact", 9.75F);
            this.clearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.clearAll.Location = new System.Drawing.Point(19, 330);
            this.clearAll.Name = "clearAll";
            this.clearAll.Size = new System.Drawing.Size(55, 17);
            this.clearAll.TabIndex = 10;
            this.clearAll.Text = "Clear All";
            this.clearAll.Click += new System.EventHandler(this.label2_Click);
            // 
            // PwdText
            // 
            this.PwdText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PwdText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PwdText.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PwdText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(134)))), ((int)(((byte)(199)))));
            this.PwdText.Location = new System.Drawing.Point(59, 282);
            this.PwdText.Multiline = true;
            this.PwdText.Name = "PwdText";
            this.PwdText.Size = new System.Drawing.Size(246, 31);
            this.PwdText.TabIndex = 11;
            this.PwdText.Text = "Password";
            this.PwdText.TextChanged += new System.EventHandler(this.PwdText_TextChanged);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.PwdText);
            this.Controls.Add(this.clearAll);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.UsernameText);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "LoginWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox UsernameText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label clearAll;
        private System.Windows.Forms.TextBox PwdText;
    }
}


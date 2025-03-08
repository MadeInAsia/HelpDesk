namespace HelpDesk
{
    partial class WinUserTicketOpen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinUserTicketOpen));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbDetails = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.lbPriority = new System.Windows.Forms.Label();
            this.openTicketBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReference = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTopic = new System.Windows.Forms.Label();
            this.cbtopicList = new System.Windows.Forms.ComboBox();
            this.tbDetails = new System.Windows.Forms.TextBox();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(50)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lbDetails);
            this.bunifuPanel1.Controls.Add(this.lbType);
            this.bunifuPanel1.Controls.Add(this.cbType);
            this.bunifuPanel1.Controls.Add(this.tbEmail);
            this.bunifuPanel1.Controls.Add(this.lbEmail);
            this.bunifuPanel1.Controls.Add(this.lbSurname);
            this.bunifuPanel1.Controls.Add(this.tbSurname);
            this.bunifuPanel1.Controls.Add(this.cbPriority);
            this.bunifuPanel1.Controls.Add(this.lbPriority);
            this.bunifuPanel1.Controls.Add(this.openTicketBtn);
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.tbReference);
            this.bunifuPanel1.Controls.Add(this.tbName);
            this.bunifuPanel1.Controls.Add(this.lbName);
            this.bunifuPanel1.Controls.Add(this.lbTopic);
            this.bunifuPanel1.Controls.Add(this.cbtopicList);
            this.bunifuPanel1.Controls.Add(this.tbDetails);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(604, 388);
            this.bunifuPanel1.TabIndex = 0;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetails.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbDetails.Location = new System.Drawing.Point(272, 158);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(54, 17);
            this.lbDetails.TabIndex = 18;
            this.lbDetails.Text = "Details";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbType.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbType.Location = new System.Drawing.Point(414, 62);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(39, 17);
            this.lbType.TabIndex = 17;
            this.lbType.Text = "Type";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(417, 82);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(143, 21);
            this.cbType.TabIndex = 16;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(332, 33);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(229, 20);
            this.tbEmail.TabIndex = 15;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbEmail.Location = new System.Drawing.Point(328, 13);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(44, 17);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "Email";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSurname.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbSurname.Location = new System.Drawing.Point(191, 13);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(66, 17);
            this.lbSurname.TabIndex = 13;
            this.lbSurname.Text = "Surname";
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(194, 34);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(121, 20);
            this.tbSurname.TabIndex = 12;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(255, 82);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(143, 21);
            this.cbPriority.TabIndex = 11;
            // 
            // lbPriority
            // 
            this.lbPriority.AutoSize = true;
            this.lbPriority.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriority.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPriority.Location = new System.Drawing.Point(252, 62);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(55, 17);
            this.lbPriority.TabIndex = 10;
            this.lbPriority.Text = "Priority";
            // 
            // openTicketBtn
            // 
            this.openTicketBtn.AllowAnimations = true;
            this.openTicketBtn.AllowMouseEffects = true;
            this.openTicketBtn.AllowToggling = false;
            this.openTicketBtn.AnimationSpeed = 200;
            this.openTicketBtn.AutoGenerateColors = false;
            this.openTicketBtn.AutoRoundBorders = false;
            this.openTicketBtn.AutoSizeLeftIcon = true;
            this.openTicketBtn.AutoSizeRightIcon = true;
            this.openTicketBtn.BackColor = System.Drawing.Color.Transparent;
            this.openTicketBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.openTicketBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("openTicketBtn.BackgroundImage")));
            this.openTicketBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openTicketBtn.ButtonText = "Create Ticket";
            this.openTicketBtn.ButtonTextMarginLeft = 0;
            this.openTicketBtn.ColorContrastOnClick = 45;
            this.openTicketBtn.ColorContrastOnHover = 45;
            this.openTicketBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.openTicketBtn.CustomizableEdges = borderEdges1;
            this.openTicketBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.openTicketBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.openTicketBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.openTicketBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.openTicketBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.openTicketBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openTicketBtn.ForeColor = System.Drawing.Color.White;
            this.openTicketBtn.IconLeft = null;
            this.openTicketBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.openTicketBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.openTicketBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.openTicketBtn.IconMarginLeft = 11;
            this.openTicketBtn.IconPadding = 10;
            this.openTicketBtn.IconRight = null;
            this.openTicketBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.openTicketBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.openTicketBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.openTicketBtn.IconSize = 25;
            this.openTicketBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.openTicketBtn.IdleBorderRadius = 0;
            this.openTicketBtn.IdleBorderThickness = 0;
            this.openTicketBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.openTicketBtn.IdleIconLeftImage = null;
            this.openTicketBtn.IdleIconRightImage = null;
            this.openTicketBtn.IndicateFocus = false;
            this.openTicketBtn.Location = new System.Drawing.Point(170, 318);
            this.openTicketBtn.Name = "openTicketBtn";
            this.openTicketBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.openTicketBtn.OnDisabledState.BorderRadius = 1;
            this.openTicketBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openTicketBtn.OnDisabledState.BorderThickness = 1;
            this.openTicketBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.openTicketBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.openTicketBtn.OnDisabledState.IconLeftImage = null;
            this.openTicketBtn.OnDisabledState.IconRightImage = null;
            this.openTicketBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.openTicketBtn.onHoverState.BorderRadius = 1;
            this.openTicketBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openTicketBtn.onHoverState.BorderThickness = 1;
            this.openTicketBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.openTicketBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.openTicketBtn.onHoverState.IconLeftImage = null;
            this.openTicketBtn.onHoverState.IconRightImage = null;
            this.openTicketBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(83)))), ((int)(((byte)(242)))));
            this.openTicketBtn.OnIdleState.BorderRadius = 1;
            this.openTicketBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openTicketBtn.OnIdleState.BorderThickness = 1;
            this.openTicketBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(83)))), ((int)(((byte)(242)))));
            this.openTicketBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.openTicketBtn.OnIdleState.IconLeftImage = null;
            this.openTicketBtn.OnIdleState.IconRightImage = null;
            this.openTicketBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.openTicketBtn.OnPressedState.BorderRadius = 1;
            this.openTicketBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.openTicketBtn.OnPressedState.BorderThickness = 1;
            this.openTicketBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.openTicketBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.openTicketBtn.OnPressedState.IconLeftImage = null;
            this.openTicketBtn.OnPressedState.IconRightImage = null;
            this.openTicketBtn.Size = new System.Drawing.Size(278, 44);
            this.openTicketBtn.TabIndex = 8;
            this.openTicketBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.openTicketBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.openTicketBtn.TextMarginLeft = 0;
            this.openTicketBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.openTicketBtn.UseDefaultRadiusAndThickness = true;
            this.openTicketBtn.Click += new System.EventHandler(this.openTicketBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(52, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reference";
            // 
            // tbReference
            // 
            this.tbReference.Location = new System.Drawing.Point(132, 132);
            this.tbReference.Name = "tbReference";
            this.tbReference.Size = new System.Drawing.Size(429, 20);
            this.tbReference.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(54, 34);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(123, 20);
            this.tbName.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbName.Location = new System.Drawing.Point(53, 13);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(46, 17);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "Name";
            // 
            // lbTopic
            // 
            this.lbTopic.AutoSize = true;
            this.lbTopic.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopic.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTopic.Location = new System.Drawing.Point(53, 62);
            this.lbTopic.Name = "lbTopic";
            this.lbTopic.Size = new System.Drawing.Size(43, 17);
            this.lbTopic.TabIndex = 3;
            this.lbTopic.Text = "Topic";
            // 
            // cbtopicList
            // 
            this.cbtopicList.FormattingEnabled = true;
            this.cbtopicList.Location = new System.Drawing.Point(55, 82);
            this.cbtopicList.Name = "cbtopicList";
            this.cbtopicList.Size = new System.Drawing.Size(181, 21);
            this.cbtopicList.TabIndex = 2;
            this.cbtopicList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbDetails
            // 
            this.tbDetails.Location = new System.Drawing.Point(54, 181);
            this.tbDetails.Multiline = true;
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.Size = new System.Drawing.Size(507, 106);
            this.tbDetails.TabIndex = 1;
            // 
            // WinUserTicketOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(604, 388);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(219, 85);
            this.Name = "WinUserTicketOpen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinUserTicketOpen";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.TextBox tbDetails;
        private System.Windows.Forms.ComboBox cbtopicList;
        private System.Windows.Forms.Label lbTopic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReference;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton openTicketBtn;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lbDetails;
    }
}
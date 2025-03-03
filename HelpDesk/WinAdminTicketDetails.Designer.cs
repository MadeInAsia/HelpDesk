namespace HelpDesk
{
    partial class WinAdminTicketDetails
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
            this.lbTicketID = new System.Windows.Forms.Label();
            this.lbPriority = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbReference = new System.Windows.Forms.Label();
            this.tbContact = new System.Windows.Forms.TextBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.tbTopic = new System.Windows.Forms.TextBox();
            this.tbReference = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDetails = new System.Windows.Forms.ListBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.lbOpenDate = new System.Windows.Forms.Label();
            this.lbCloseDate = new System.Windows.Forms.Label();
            this.tbAssignedWorker = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTicketID
            // 
            this.lbTicketID.AutoSize = true;
            this.lbTicketID.Font = new System.Drawing.Font("Heebo", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTicketID.Location = new System.Drawing.Point(32, 32);
            this.lbTicketID.Name = "lbTicketID";
            this.lbTicketID.Size = new System.Drawing.Size(56, 17);
            this.lbTicketID.TabIndex = 0;
            this.lbTicketID.Text = "Ticket ID:";
            // 
            // lbPriority
            // 
            this.lbPriority.AutoSize = true;
            this.lbPriority.Location = new System.Drawing.Point(32, 110);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(41, 13);
            this.lbPriority.TabIndex = 2;
            this.lbPriority.Text = "Priority:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(191, 110);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(40, 13);
            this.lbStatus.TabIndex = 3;
            this.lbStatus.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Topic:";
            // 
            // lbReference
            // 
            this.lbReference.AutoSize = true;
            this.lbReference.Location = new System.Drawing.Point(32, 162);
            this.lbReference.Name = "lbReference";
            this.lbReference.Size = new System.Drawing.Size(60, 13);
            this.lbReference.TabIndex = 5;
            this.lbReference.Text = "Reference:";
            // 
            // tbContact
            // 
            this.tbContact.Location = new System.Drawing.Point(79, 55);
            this.tbContact.Name = "tbContact";
            this.tbContact.ReadOnly = true;
            this.tbContact.Size = new System.Drawing.Size(268, 20);
            this.tbContact.TabIndex = 6;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(79, 106);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(106, 21);
            this.cbPriority.TabIndex = 7;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(237, 107);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(124, 21);
            this.cbStatus.TabIndex = 8;
            // 
            // tbTopic
            // 
            this.tbTopic.Location = new System.Drawing.Point(237, 132);
            this.tbTopic.Name = "tbTopic";
            this.tbTopic.ReadOnly = true;
            this.tbTopic.Size = new System.Drawing.Size(110, 20);
            this.tbTopic.TabIndex = 9;
            // 
            // tbReference
            // 
            this.tbReference.Location = new System.Drawing.Point(98, 159);
            this.tbReference.Name = "tbReference";
            this.tbReference.ReadOnly = true;
            this.tbReference.Size = new System.Drawing.Size(249, 20);
            this.tbReference.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ticket Details:";
            // 
            // lbDetails
            // 
            this.lbDetails.FormattingEnabled = true;
            this.lbDetails.Location = new System.Drawing.Point(35, 294);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.ScrollAlwaysVisible = true;
            this.lbDetails.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbDetails.Size = new System.Drawing.Size(326, 69);
            this.lbDetails.TabIndex = 12;
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(35, 385);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(141, 35);
            this.btnAssign.TabIndex = 13;
            this.btnAssign.Text = "Assign Ticket";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(220, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 35);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(79, 81);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.ReadOnly = true;
            this.tbEmail.Size = new System.Drawing.Size(268, 20);
            this.tbEmail.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Type:";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(79, 133);
            this.tbType.Name = "tbType";
            this.tbType.ReadOnly = true;
            this.tbType.Size = new System.Drawing.Size(106, 20);
            this.tbType.TabIndex = 17;
            // 
            // lbOpenDate
            // 
            this.lbOpenDate.AutoSize = true;
            this.lbOpenDate.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpenDate.Location = new System.Drawing.Point(32, 188);
            this.lbOpenDate.Name = "lbOpenDate";
            this.lbOpenDate.Size = new System.Drawing.Size(60, 16);
            this.lbOpenDate.TabIndex = 18;
            this.lbOpenDate.Text = "opendate";
            // 
            // lbCloseDate
            // 
            this.lbCloseDate.AutoSize = true;
            this.lbCloseDate.Font = new System.Drawing.Font("Gadugi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCloseDate.Location = new System.Drawing.Point(32, 217);
            this.lbCloseDate.Name = "lbCloseDate";
            this.lbCloseDate.Size = new System.Drawing.Size(60, 16);
            this.lbCloseDate.TabIndex = 19;
            this.lbCloseDate.Text = "closedate";
            // 
            // tbAssignedWorker
            // 
            this.tbAssignedWorker.Location = new System.Drawing.Point(129, 243);
            this.tbAssignedWorker.Name = "tbAssignedWorker";
            this.tbAssignedWorker.ReadOnly = true;
            this.tbAssignedWorker.Size = new System.Drawing.Size(232, 20);
            this.tbAssignedWorker.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Assigned Worker:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(32, 84);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 22;
            this.lbEmail.Text = "Email:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(32, 58);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 23;
            this.lbName.Text = "Name:";
            // 
            // WinAdminTicketDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 457);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAssignedWorker);
            this.Controls.Add(this.lbCloseDate);
            this.Controls.Add(this.lbOpenDate);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.lbDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbReference);
            this.Controls.Add(this.tbTopic);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbPriority);
            this.Controls.Add(this.tbContact);
            this.Controls.Add(this.lbReference);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbPriority);
            this.Controls.Add(this.lbTicketID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1200, 400);
            this.Name = "WinAdminTicketDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "WinAdminTicketDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTicketID;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbReference;
        private System.Windows.Forms.TextBox tbContact;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.TextBox tbTopic;
        private System.Windows.Forms.TextBox tbReference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDetails;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label lbOpenDate;
        private System.Windows.Forms.Label lbCloseDate;
        private System.Windows.Forms.TextBox tbAssignedWorker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbName;
    }
}
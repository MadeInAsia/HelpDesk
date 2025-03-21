﻿using System;
using System.Linq;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace HelpDesk
{
    public partial class WinUserTicketMenu : Form
    {
        private Ticket selectedTicket;
        private WinUserHome parentForm; // Reference to parent form

        public WinUserTicketMenu(Ticket ticket, WinUserHome parentForm)
        {
            InitializeComponent();
            this.selectedTicket = ticket;
            this.parentForm = parentForm; 
            LoadTicketDetails();
        }


        private void LoadTicketDetails()
        {
            if (selectedTicket != null)
            {
                lbTopic.Text = $"Topic: {selectedTicket.Topic}";
                lbType.Text = $"Type: {selectedTicket.Type}";
                lbDevice.Text = $"Device: {selectedTicket.Reference}";


                if (selectedTicket.AssignedWorker != null)
                {
                    lbWorker.Text = $"Worker: {selectedTicket.AssignedWorker.Name} {selectedTicket.AssignedWorker.Nachname}";
                }
                else
                {
                    lbWorker.Text = "Worker: Not Assigned";
                }

                lbDate.Text = $"Opening Date: {selectedTicket.OpenDate:MM/dd/yyyy}";

                textBox4.Text = selectedTicket.Details;
                textBox4.Enabled = false;

                tbDetails.Text = string.Join(Environment.NewLine,
                    selectedTicket.Comments
                        .Where(c => !c.Contains("Ticket created by")) // Filter out auto-created logs
                        .Where(c => !c.StartsWith("Assigned to"))     // Optional: also filter "assigned" logs
                );
                tbDetails.Enabled = false;



            }
            else
            {
                MessageBox.Show("No ticket data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}

using System;
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
                lbWorker.Text = $"Worker: {lbWorker.Text}";
                lbDate.Text = $"Opening Date: {selectedTicket.OpenDate.ToString("MM/dd/yyyy")}";


                textBox4.Text = selectedTicket.Details;

                textBox4.Enabled = false;
                tbDetails.Enabled = false;
            }
            else
            {
                MessageBox.Show("No ticket data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}

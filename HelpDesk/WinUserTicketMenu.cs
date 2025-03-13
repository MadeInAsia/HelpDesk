using System;
using System.Windows.Forms;

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
                lbDate.Text = selectedTicket.OpenDate.ToString("MM/dd/yyyy");


                ticketInfo.Text = selectedTicket.Details;

                ticketInfo.Enabled = false;
                tbDetails.Enabled = false;
            }
            else
            {
                MessageBox.Show("No ticket data found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void backBtn_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("Click");

            // Show the parent form again
            if (parentForm != null)
            {
                parentForm.Show();
            }

            // Close this menu
            this.Close();
        }

    }
}

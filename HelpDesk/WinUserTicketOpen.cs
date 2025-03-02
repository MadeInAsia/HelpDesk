using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HelpDesk.Ticket;
using System.Xml.Linq;
using System.Web.UI.WebControls.WebParts;

namespace HelpDesk
{
    public partial class WinUserTicketOpen : Form
    {
        private TicketController ticketController;

        public WinUserTicketOpen()
        {
            InitializeComponent();

            cbtopicList.Items.Add("Select");
            cbtopicList.Items.Add("was soll hier rein");
            cbPriority.DataSource = Enum.GetValues(typeof(Ticket.TicketPriority));
            cbType.DataSource = Enum.GetValues(typeof(Ticket.TicketType));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text.Trim();
            string surname = tbSurname.Text.Trim();
            string email = tbEmail.Text.Trim();
            string topic = cbtopicList.Text.Trim();
            string reference = tbReference.Text.Trim();
            string details = tbDetails.Text.Trim();

            // Validate inputs
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(topic))
            {
                MessageBox.Show("Please fill in all required fields (Name, Surname, Email, Topic)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Get from ComboBox
            Ticket.TicketPriority priority = (Ticket.TicketPriority)cbPriority.SelectedItem;
            Ticket.TicketType type = (Ticket.TicketType)cbType.SelectedItem;

            // Create Contact object
            Contact person = new Contact(name, surname, email);

            // Create Ticket object (default status: Open)
            Ticket newTicket = new Ticket(person, priority, type, Ticket.TicketStatus.Open, topic, reference, details);

            // Add ticket to the system
            Program.ticketController.AddTicket(newTicket); // add to list
            Program.ticketController.SaveTicketsFile(); // Save to XML

            // Show success message
            MessageBox.Show("Ticket created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}

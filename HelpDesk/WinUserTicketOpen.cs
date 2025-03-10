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

        private void openTicketBtn_Click(object sender, EventArgs e)
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

            Ticket.TicketPriority priority = (Ticket.TicketPriority)cbPriority.SelectedItem;
            Ticket.TicketType type = (Ticket.TicketType)cbType.SelectedItem;

            Contact person = new Contact(name, surname, email);
            Ticket newTicket = new Ticket(person, priority, type, Ticket.TicketStatus.Open, topic, reference, details);

            // ✅ Debug message to confirm ticket creation
            MessageBox.Show($"New Ticket Created:\nID: {newTicket.TicketID}\nName: {newTicket.Person.Name}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Add ticket to the system
            Program.ticketController.AddTicket(newTicket); // add to list
            Program.ticketController.SaveTicketsFile(); // Save to XML

            MessageBox.Show($"Tickets saved. Current ticket count: {Program.ticketController.GetTickets().Count}", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("Ticket created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

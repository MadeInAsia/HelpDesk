using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpDesk
{
    public partial class WinAdminTickets: Form
    {
        public WinAdminTickets()
        {
            InitializeComponent();
            SetupListView();
        }


   
        private void WinAdminTickets_Load(object sender, EventArgs e)
        {
            LoadTicketsToListView();
        }

        private void LoadTicketsToListView()
        {
            List<Ticket> tickets = Program.ticketController.GetTickets();

            listView1.Items.Clear();

            foreach (Ticket ticket in tickets)
            {
                ListViewItem item = new ListViewItem(ticket.TicketID);
                item.SubItems.Add(ticket.Person.Name + " " + ticket.Person.Nachname); // Requester Name
                item.SubItems.Add(ticket.Priority.ToString());
                item.SubItems.Add(ticket.Status.ToString());
                item.SubItems.Add(ticket.Topic);

                listView1.Items.Add(item);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SetupListView()
        {
            // CHANGE THIS TO TICKETS not people 
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("Ticket ID", 100);
            listView1.Columns.Add("Requester Name", 150);
            listView1.Columns.Add("Priority", 100);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add("Topic", 100);
        }
    }
}

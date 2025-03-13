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
    public partial class WinAdminTickets : Form
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
        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("Ticket ID", 100);
            listView1.Columns.Add("Requester Name", 150);
            listView1.Columns.Add("Priority", 100);
            listView1.Columns.Add("Status", 100);
            listView1.Columns.Add("Topic", 100);
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
        private Ticket GetSelectedTicket()
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a ticket first.", "No Ticket Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            string selectedTicketID = listView1.SelectedItems[0].Text;
            return Program.ticketController.GetTickets().FirstOrDefault(t => t.TicketID == selectedTicketID);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Ticket selectedTicket = GetSelectedTicket();
            if (selectedTicket != null)
            {
                LoadTicketDetailsPanel(selectedTicket);
            }
        }

        private void LoadTicketDetailsPanel(Ticket selectedTicket)
        {
            pnlTicketDetails.Controls.Clear();

            WinAdminTicketDetails ticketDetailsForm = new WinAdminTicketDetails(selectedTicket);

            ticketDetailsForm.TopLevel = false;
            ticketDetailsForm.FormBorderStyle = FormBorderStyle.None;
            ticketDetailsForm.Dock = DockStyle.Fill;

            pnlTicketDetails.Controls.Add(ticketDetailsForm);
            ticketDetailsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ticket selectedTicket = GetSelectedTicket();
            if (selectedTicket != null)
            {
                WinAdminComments commentsForm = new WinAdminComments(selectedTicket);
                commentsForm.ShowDialog();
            }
        }

        private void btnPostComment_Click(object sender, EventArgs e)
        {
            Ticket selectedTicket = GetSelectedTicket();
            if (selectedTicket != null)
            {
                string adminComment = textBox1.Text.Trim();
                if (!string.IsNullOrEmpty(adminComment))
                {
                    selectedTicket.AddComment("Admin", adminComment);
                    Program.ticketController.SaveTicketsFile();

                    MessageBox.Show("Comment posted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                }
            }
        }
            }
}

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
    public partial class WinAdminTicketDetails : Form
    {
        private Ticket currentTicket;
        public WinAdminTicketDetails(Ticket ticket)
        {
            InitializeComponent();
            currentTicket = ticket;
            FillTicketDetails();


        }
        private void FillTicketDetails()
        {
            lbTicketID.Text = "Ticket ID:     " + currentTicket.TicketID;
            tbContact.Text = currentTicket.Person.Name + " " + currentTicket.Person.Nachname;
            tbEmail.Text = currentTicket.Person.Email;
            cbPriority.DataSource = Enum.GetValues(typeof(Ticket.TicketPriority));
            cbPriority.SelectedItem = currentTicket.Priority;
            cbStatus.DataSource = Enum.GetValues(typeof(Ticket.TicketStatus));
            cbStatus.SelectedItem = currentTicket.Status;
            tbTopic.Text = currentTicket.Topic;
            tbType.Text = currentTicket.Type.ToString();
            tbReference.Text = currentTicket.Reference;
            lbOpenDate.Text = "Open Date:     " + currentTicket.OpenDate.ToString();

            if (currentTicket.AssignedWorker != null)
            {
                tbAssignedWorker.Text = currentTicket.AssignedWorker.Name + " " + currentTicket.AssignedWorker.Nachname;
            }
            else
            {
                tbAssignedWorker.Text = "Not Assigned";
            }

            if (currentTicket.CloseDate != null)
            {
                lbCloseDate.Text = "Close Date:     " + currentTicket.CloseDate.ToString();
            }
            else
            {
                lbCloseDate.Text = "Close Date:     Not closed yet";
            }


            lbDetails.Items.Clear();
            string[] details = currentTicket.Details.Split('\n');
            foreach (string detail in details)
            {
                lbDetails.Items.Add(detail);
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Ticket.TicketStatus newStatus = (Ticket.TicketStatus)cbStatus.SelectedItem;
            Ticket.TicketPriority newPriority = (Ticket.TicketPriority)cbPriority.SelectedItem;

            //  Log status change
            if (currentTicket.Status != newStatus)
            {
                currentTicket.UpdateStatus(newStatus);
            }
            if (currentTicket.Priority != newPriority)
            {
                currentTicket.UpdatePriority(newPriority);
            }
            // Assign someone only if not already assigned
            if (currentTicket.AssignedWorker == null)
            {
                Employee adminWorker = new Employee(1, "Admin", "User", "IT Department");
                currentTicket.AssignWorker(adminWorker);
            }

            //  Refresh comments form to show new updates
            WinAdminComments commentsForm = new WinAdminComments(currentTicket);
            commentsForm.Show();
        }

        private void btnAssign_Click_1(object sender, EventArgs e)
        {
            currentTicket.AssignedWorker = new Employee(1, "Admin", "", "IT Department");
            tbAssignedWorker.Text = currentTicket.AssignedWorker.Name + " " + currentTicket.AssignedWorker.Nachname + "in  " + currentTicket.AssignedWorker.Department;
            MessageBox.Show("You have been assigned to this ticket!", "Assignment", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

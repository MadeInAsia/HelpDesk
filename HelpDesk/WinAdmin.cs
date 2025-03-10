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
    public partial class WinAdmin : Form
    {
        private Form WinAdminTickets = null;
        private Form WinAdminMessages = null;
        private Form WinAdminStats = null;
        private TicketController ticketController;

        public WinAdmin()
        {
            InitializeComponent();
            ticketController = new TicketController();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            List<Ticket> tickets = Program.ticketController.GetTickets();

            int totalTickets = tickets.Count;
            int completedTickets = tickets.Count(t => t.Status == Ticket.TicketStatus.Closed);
            int openTickets = tickets.Count(t => t.Status == Ticket.TicketStatus.Open);
            int inProgressTickets = tickets.Count(t => t.Status == Ticket.TicketStatus.InProgress);
            int highPriorityTickets = tickets.Count(t => t.Priority == Ticket.TicketPriority.High || t.Priority == Ticket.TicketPriority.Critical);

            double completionRate;
            if (totalTickets > 0)
            {
                completionRate = (double)completedTickets / totalTickets * 100;
            }
            else
            {
                completionRate = 0;
            }


            lblTotalTickets.Text = totalTickets.ToString();
            lblOpenTickets.Text = openTickets.ToString();
            lblInProgressTickets.Text = inProgressTickets.ToString();
            lblHighPriorityTickets.Text = highPriorityTickets.ToString();

            // Radial Gauge
            if (totalTickets > 0)
            {
                radialGauge.Value = completedTickets * 100 / totalTickets;
                lblRadialSubtitle.Text = $"{completedTickets} / {totalTickets} Tickets Closed";
            }

            // Circle Progress
            if (completionRate > 0)
            {
                circleProgress.Value = (int)completionRate;
            }
            else
            {
                circleProgress.Value = 0;
            }
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPanel8_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void WinAdmin_Load(object sender, EventArgs e)
        {

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            this.BringToFront();
            this.Show();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            WinAdminTickets = new WinAdminTickets();
            WinAdminTickets.FormBorderStyle = FormBorderStyle.None;
            WinAdminTickets.TopLevel = false;
            WinAdminTickets.Dock = DockStyle.None;
            this.Controls.Add(WinAdminTickets);
            this.Tag = WinAdminTickets;
            WinAdminTickets.BringToFront();
            WinAdminTickets.Show();
        }

        private void btnComments_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            //WinAdminMessages.FormBorderStyle = FormBorderStyle.None;
            //WinAdminMessages.TopLevel = false;
            //WinAdminMessages.Dock = DockStyle.None;
            //this.Controls.Add(WinAdminMessages);
            //this.Tag = WinAdminMessages;
            //WinAdminMessages.BringToFront();
            //WinAdminMessages.Show();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            CloseAllForms();
            WinAdminStats = new WinAdminStats();
            WinAdminStats.FormBorderStyle = FormBorderStyle.None;
            WinAdminStats.TopLevel = false;
            WinAdminStats.Dock = DockStyle.None;
            this.Controls.Add(WinAdminStats);
            this.Tag = WinAdminStats;
            WinAdminStats.BringToFront();
            WinAdminStats.Show();
        }
        private void CloseAllForms()
        {
            if (WinAdminTickets != null)
            {
                WinAdminTickets.Close();
                WinAdminTickets = null;
            }
            if (WinAdminMessages != null)
            {
                WinAdminMessages.Close();
                WinAdminMessages = null;
            }
            if (WinAdminStats != null)
            {
                WinAdminStats.Close();
                WinAdminStats = null;
            }
        }

        private void CloseAllUser()
        {

        }

        private void circleProgress_ProgressChanged(object sender, Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs e)
        {

        }

        private void TotalTickets_Click(object sender, EventArgs e)
        {

        }
    }
}


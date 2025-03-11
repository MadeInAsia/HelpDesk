using Bunifu.Charts.WinForms;
using Bunifu.Charts.WinForms.ChartTypes;
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
            LoadPriorityChart();
        }

        private void LoadDashboard()
        {
            List<Ticket> tickets = Program.ticketController.GetTickets();

            int totalTickets = tickets.Count;
            int completedTickets = tickets.Count(t => t.Status == Ticket.TicketStatus.Closed);
            int openTickets = tickets.Count(t => t.Status == Ticket.TicketStatus.Open);
            int inProgressTickets = tickets.Count(t => t.Status == Ticket.TicketStatus.InProgress);
            lblTotalTickets.Text = totalTickets.ToString();

            ProgressBars(completedTickets, openTickets, inProgressTickets);

            //int highPriorityTickets = tickets.Count(t => t.Priority == Ticket.TicketPriority.High || t.Priority == Ticket.TicketPriority.Critical);

            double completionRate;
            if (totalTickets > 0)
            {
                completionRate = (double)completedTickets / totalTickets * 100;
            }
            else
            {
                completionRate = 0;
            }

            // Radial Gauge
            if (totalTickets > 0)
            {
                radialGauge.Value = completedTickets;
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

        private void ProgressBars(int completedTickets, int openTickets, int inProgressTickets)
        {
            progressOpenTickets.ValueByTransition = openTickets;
            progressInProgressTickets.ValueByTransition = inProgressTickets;
            progressClosedTickets.ValueByTransition = completedTickets;
            lblOpenTickets.Text = $"Open Tickets: {openTickets}";
            lblInProgressTickets.Text = $"In Progress:    {inProgressTickets}";
            lblClosedTickets.Text = $"Closed:           {completedTickets}";
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
            if (WinAdminStats != null)
            {
                WinAdminStats.Close();
                WinAdminStats = null;
            }
        }

        //private void LoadPriorityChart()   JUSTINS VERSION of chart
        //{
        //    List<double> priorityChartlow = new List<double>();
        //    List<double> priorityChartMed = new List<double>();
        //    List<double> priorityChartHigh = new List<double>();
        //    List<double> priorityChartCrit = new List<double>();

        //    List<Ticket> tickets = Program.ticketController.GetTickets();

        //    foreach (Ticket ticket in tickets) 
        //    {
        //        priorityChartlow.Add((double)Ticket.TicketPriority.Low);
        //        priorityChartMed.Add((double)Ticket.TicketPriority.Medium);
        //        priorityChartHigh.Add((double)Ticket.TicketPriority.High);
        //        priorityChartCrit.Add((double)Ticket.TicketPriority.Critical);
        //    }

        //    bunifuLineChart1.Data = priorityChartlow;
        //    bunifuLineChart2.Data = priorityChartMed;
        //    bunifuLineChart3.Data = priorityChartlow;
        //    bunifuLineChart4.Data = priorityChartCrit;
        //}

        // CHATGPT DID THIS WHOLE METHOD because i seriously need more time and this shit hard asf
        private void LoadPriorityChart()
        {
            List<Ticket> tickets = Program.ticketController.GetTickets();

            // ✅ Create lists for each priority level
            List<double> priorityChartLow = new List<double>();
            List<double> priorityChartMed = new List<double>();
            List<double> priorityChartHigh = new List<double>();
            List<double> priorityChartCrit = new List<double>();

            List<string> dayLabels = new List<string>(); // X-Axis Labels

            // ✅ Get the last 7 days dynamically
            for (int i = 6; i >= 0; i--)
            {
                DateTime day = DateTime.Now.Date.AddDays(-i);
                string dayLabel = day.ToString("MMM dd"); // e.g., "Mar 04"
                dayLabels.Add(dayLabel);

                // ✅ Count tickets per priority for this day
                priorityChartLow.Add((double)tickets.Count(t => t.Priority == Ticket.TicketPriority.Low && t.OpenDate.Date == day));
                priorityChartMed.Add((double)tickets.Count(t => t.Priority == Ticket.TicketPriority.Medium && t.OpenDate.Date == day));
                priorityChartHigh.Add((double)tickets.Count(t => t.Priority == Ticket.TicketPriority.High && t.OpenDate.Date == day));
                priorityChartCrit.Add((double)tickets.Count(t => t.Priority == Ticket.TicketPriority.Critical && t.OpenDate.Date == day));
            }

            // ✅ Assign data to Bunifu line charts
            bunifuLineChart1.Data = priorityChartLow;
            bunifuLineChart2.Data = priorityChartMed;
            bunifuLineChart3.Data = priorityChartHigh;
            bunifuLineChart4.Data = priorityChartCrit;

            // ✅ Set X-Axis Labels to show days
            chartCanvasPriorityTrends.Labels = dayLabels.ToArray();
            chartCanvasPriorityTrends.Update(); // Refresh the chart
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void WinAdmin_Load(object sender, EventArgs e)
        {

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


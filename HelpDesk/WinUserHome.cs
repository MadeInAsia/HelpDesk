using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bunifu.UI.WinForms;

namespace HelpDesk
{
    public partial class WinUserHome : Form
    {
        private BindingList<Ticket> tickets;
        private ListSortDirection sortDirection = ListSortDirection.Ascending; // Track sorting direction

        public WinUserHome()
        {
            InitializeComponent();
            InitializeDataGridView();
            UpdateDataGridView();
        }

        private void InitializeDataGridView()
        {
            tickets = new BindingList<Ticket>(Program.ticketController.GetTickets());
            openTicketsGridView.DataSource = tickets;

            CustomizeDataGridView();
            openTicketsGridView.ColumnHeaderMouseClick += OpenTicketsGridView_ColumnHeaderMouseClick;
            openTicketsGridView.CellClick += OpenTicketsGridView_CellClick;
        }

        private void UpdateDataGridView()
        {
            var latestTickets = Program.ticketController.GetTickets();
            tickets = new BindingList<Ticket>(latestTickets);
            openTicketsGridView.DataSource = tickets;
        }

        private void CustomizeDataGridView()
        {
            openTicketsGridView.AutoGenerateColumns = false;
            openTicketsGridView.Columns.Clear();
            openTicketsGridView.EnableHeadersVisualStyles = false;
            openTicketsGridView.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#5853F2");
            openTicketsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            openTicketsGridView.RowsDefaultCellStyle.BackColor = Color.White;
            openTicketsGridView.RowsDefaultCellStyle.ForeColor = Color.Black;
            openTicketsGridView.ReadOnly = true;

            openTicketsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Topic",
                HeaderText = "Topic",
                Name = "Topic",
                Resizable = DataGridViewTriState.False
            });

            openTicketsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Priority",
                HeaderText = "Priority",
                Name = "Priority",
                Resizable = DataGridViewTriState.False
            });

            openTicketsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Type",
                HeaderText = "Type",
                Name = "Type",
                Resizable = DataGridViewTriState.False
            });

            openTicketsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status",
                Name = "Status",
                Resizable = DataGridViewTriState.False
            });

            openTicketsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OpenDate",
                HeaderText = "Opened Date",
                Name = "OpenDate",
                Resizable = DataGridViewTriState.False
            });

            openTicketsGridView.CellFormatting += OpenTicketsGridView_CellFormatting;
        }

        private void OpenTicketsGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string columnName = openTicketsGridView.Columns[e.ColumnIndex].Name;
            SortData(columnName);
            sortDirection = sortDirection == ListSortDirection.Ascending ? ListSortDirection.Descending : ListSortDirection.Ascending;
        }

        private void SortData(string columnName)
        {
            var sortedList = tickets.ToList();

            switch (columnName)
            {
                case "Topic":
                    sortedList = sortDirection == ListSortDirection.Ascending ? sortedList.OrderBy(t => t.Topic).ToList() : sortedList.OrderByDescending(t => t.Topic).ToList();
                    break;
                case "Priority":
                    sortedList = sortDirection == ListSortDirection.Ascending ? sortedList.OrderBy(t => t.Priority).ToList() : sortedList.OrderByDescending(t => t.Priority).ToList();
                    break;
                case "Type":
                    sortedList = sortDirection == ListSortDirection.Ascending ? sortedList.OrderBy(t => t.Type).ToList() : sortedList.OrderByDescending(t => t.Type).ToList();
                    break;
                case "Status":
                    sortedList = sortDirection == ListSortDirection.Ascending ? sortedList.OrderBy(t => t.Status).ToList() : sortedList.OrderByDescending(t => t.Status).ToList();
                    break;
                case "OpenDate":
                    sortedList = sortDirection == ListSortDirection.Ascending ? sortedList.OrderBy(t => t.OpenDate).ToList() : sortedList.OrderByDescending(t => t.OpenDate).ToList();
                    break;
            }

            tickets = new BindingList<Ticket>(sortedList);
            openTicketsGridView.DataSource = tickets;
        }

        private void OpenTicketsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (openTicketsGridView.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                switch (e.Value.ToString())
                {
                    case "Open":
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case "Closed":
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                        break;
                    case "InProgress":
                        e.CellStyle.BackColor = Color.Yellow;
                        e.CellStyle.ForeColor = Color.Black;
                        break;
                }
            }
        }

        private void OpenTicketsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedTicket = tickets[e.RowIndex];
                OpenTicketMenu(selectedTicket);
            }
        }

        private void OpenTicketMenu(Ticket selectedTicket)
        {

            bunifuPanel1.Controls.Clear();

            WinUserTicketMenu ticketMenuForm = new WinUserTicketMenu(selectedTicket, this);

            ticketMenuForm.TopLevel = false;  // Make it behave as a user control
            ticketMenuForm.FormBorderStyle = FormBorderStyle.None; // Remove border
            ticketMenuForm.Dock = DockStyle.Fill;  // Make it fill the panel

    
            bunifuPanel1.Controls.Add(ticketMenuForm);

            ticketMenuForm.Show();
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
        }

        private void InitializeDataGridView()
        {
            tickets = new BindingList<Ticket>(Program.ticketController.GetTickets());
            openTicketsGridView.DataSource = tickets;

            CustomizeDataGridView();
            openTicketsGridView.ColumnHeaderMouseClick += OpenTicketsGridView_ColumnHeaderMouseClick;
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


            var topicColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Topic", 
                HeaderText = "Topic",
                Name = "Topic", 
                Resizable = DataGridViewTriState.False
            };
            openTicketsGridView.Columns.Add(topicColumn);

            var priorityColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Priority", 
                HeaderText = "Priority",
                Name = "Priority", 
                Resizable = DataGridViewTriState.False
            };
            openTicketsGridView.Columns.Add(priorityColumn);

            var typeColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Type", 
                HeaderText = "Type",
                Name = "Type", 
                Resizable = DataGridViewTriState.False 
            };
            openTicketsGridView.Columns.Add(typeColumn);

            var statusColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status", 
                HeaderText = "Status",
                Name = "Status", 
                Resizable = DataGridViewTriState.False 
            };
            openTicketsGridView.Columns.Add(statusColumn);

            var openDateColumn = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OpenDate", // Bind to the "OpenDate" property in the Ticket class
                HeaderText = "Opened Date",
                Name = "OpenDate", // Set the Name property for reference
                Resizable = DataGridViewTriState.False // Make the column non-resizable
            };
            openTicketsGridView.Columns.Add(openDateColumn);

            // Attach the CellFormatting event handler
            openTicketsGridView.CellFormatting += OpenTicketsGridView_CellFormatting;
        }

        private void OpenTicketsGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Get the column name that was clicked
            string columnName = openTicketsGridView.Columns[e.ColumnIndex].Name;


            switch (columnName)
            {
                case "Topic":
                    SortData("Topic");
                    break;
                case "Priority":
                    SortData("Priority");
                    break;
                case "Type":
                    SortData("Type");
                    break;
                case "Status":
                    SortData("Status");
                    break;
                case "OpenDate":
                    SortData("OpenDate");
                    break;
            }

            // Toggle the sorting direction
            sortDirection = sortDirection == ListSortDirection.Ascending ? ListSortDirection.Descending : ListSortDirection.Ascending;
        }

        private void SortData(string columnName)
        {

            var sortedList = tickets.ToList();

            switch (columnName)
            {
                case "Topic":
                    sortedList = sortDirection == ListSortDirection.Ascending
                        ? sortedList.OrderBy(t => t.Topic).ToList()
                        : sortedList.OrderByDescending(t => t.Topic).ToList();
                    break;
                case "Priority":
                    sortedList = sortDirection == ListSortDirection.Ascending
                        ? sortedList.OrderBy(t => t.Priority).ToList()
                        : sortedList.OrderByDescending(t => t.Priority).ToList();
                    break;
                case "Type":
                    sortedList = sortDirection == ListSortDirection.Ascending
                        ? sortedList.OrderBy(t => t.Type).ToList()
                        : sortedList.OrderByDescending(t => t.Type).ToList();
                    break;
                case "Status":
                    sortedList = sortDirection == ListSortDirection.Ascending
                        ? sortedList.OrderBy(t => t.Status).ToList()
                        : sortedList.OrderByDescending(t => t.Status).ToList();
                    break;
                case "OpenDate":
                    sortedList = sortDirection == ListSortDirection.Ascending
                        ? sortedList.OrderBy(t => t.OpenDate).ToList()
                        : sortedList.OrderByDescending(t => t.OpenDate).ToList();
                    break;
            }

            tickets = new BindingList<Ticket>(sortedList);
            openTicketsGridView.DataSource = tickets;
        }

        private void OpenTicketsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (openTicketsGridView.Columns[e.ColumnIndex].Name == "Status")
            {
                if (e.Value != null)
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

            // Format the "Priority" column
            if (openTicketsGridView.Columns[e.ColumnIndex].Name == "Priority")
            {
                if (e.Value != null)
                {
                    switch (e.Value.ToString())
                    {
                        case "Low":
                            e.CellStyle.BackColor = Color.LightGreen;
                            break;
                        case "Medium":
                            e.CellStyle.BackColor = Color.Yellow;
                            break;
                        case "High":
                            e.CellStyle.BackColor = Color.Orange;
                            break;
                        case "Critical":
                            e.CellStyle.BackColor = Color.Red;
                            break;
                    }
                }
            }
        }


    }
}
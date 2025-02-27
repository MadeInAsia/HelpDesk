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

            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Nachname", 50);
            listView1.Columns.Add("Email", 200);
            listView1.Columns.Add("Abteilung", 150);

            listView1.Items.Add(new ListViewItem(new[] { "1", "Alice", "Akermann", "Alice1@hotmail.com", "HR"}));
            listView1.Items.Add(new ListViewItem(new[] { "2", "Bob", "Butter", "Butterboy@gmail.com", "IT"}));
            listView1.Items.Add(new ListViewItem(new[] { "3", "Charlie", "Dorf", "CharliesFaktory@yahoo.com", "Office"}));
        }
    }
}

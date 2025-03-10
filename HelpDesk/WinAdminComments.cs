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
    public partial class WinAdminComments: Form
    {
        public WinAdminComments()
        {
            InitializeComponent();
            LoadComments();
        }

        private void LoadComments()
        {
            lbComments.Items.Clear();

            foreach (string comment in Program.ticketController.GetComments())
            {
                lbComments.Items.Add(comment);
            }
        }
    }
}

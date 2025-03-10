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
        private Ticket currentTicket;
        public WinAdminComments(Ticket ticket)
        {
            InitializeComponent();
            currentTicket = ticket;
            LoadComments();
        }

        private void LoadComments()
        {
            flpComments.Controls.Clear();
            flpComments.Padding = new Padding(0, 20, 0, 20);

            if (currentTicket.Comments.Count == 0)
            {
                Label noUpdates = new Label
                {
                    Text = "No updates yet.",
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Font = new Font("Gadugi", 10, FontStyle.Italic),
                    Size = new Size(flpComments.Width - 40, 40),
                    Padding = new Padding(5)
                };
                flpComments.Controls.Add(noUpdates);
                return;
            }

            foreach (string comment in currentTicket.Comments)
            {
                Panel commentPanel = new Panel
                {
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.FixedSingle,
                    Width = flpComments.Width - 40,
                    Height = 50,
                    Padding = new Padding(10),
                    Margin = new Padding(5),
                    AutoSize = true
                };

                Label lblComment = new Label
                {
                    Text = comment,
                    AutoSize = true,
                    ForeColor = Color.Black,
                    Font = new Font("Gadugi", 10, FontStyle.Regular),
                    Dock = DockStyle.Fill
                };

                commentPanel.Controls.Add(lblComment);
                flpComments.Controls.Add(commentPanel);
            }
        }

    }
}

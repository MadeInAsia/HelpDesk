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
    public partial class WinUser : Form
    {
        public WinUser()
        {
            InitializeComponent();
            bunifuButton1_Click(null, EventArgs.Empty);
        }


        private void WinUser_Load(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPanel2.Controls.Clear();

            WinUserHome userHome = new WinUserHome();

            userHome.TopLevel = false;
            userHome.FormBorderStyle = FormBorderStyle.None; 
            userHome.Dock = DockStyle.Fill; 

            bunifuPanel2.Controls.Add(userHome);

            userHome.Show();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPanel2.Controls.Clear();

            WinUserTicketOpen ticketOpen = new WinUserTicketOpen();

            ticketOpen.TopLevel = false;
            ticketOpen.FormBorderStyle = FormBorderStyle.None;
            ticketOpen.Dock = DockStyle.Fill;


            bunifuPanel2.Controls.Add(ticketOpen);
            ticketOpen.Show();
        }

    }
}

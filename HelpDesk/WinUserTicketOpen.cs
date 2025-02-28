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
    public partial class WinUserTicketOpen : Form
    {
        public WinUserTicketOpen()
        {
            InitializeComponent();

            topicList.Items.Add("Select");
            topicList.Items.Add("Bug");
            topicList.Items.Add("Feature Request");
            topicList.Items.Add("Improvement");
            topicList.Items.Add("Task");
            topicList.Items.Add("Question");

            topicList.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}

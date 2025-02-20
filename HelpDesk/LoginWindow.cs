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
    public partial class LoginWindow : Form
    {
   
        private bool isUsernameCleared = false;
        private bool isPasswordCleared = false;

        public LoginWindow()
        {
            InitializeComponent();

            // Assign event handlers dynamically
            UsernameText.Enter += UsernameText_Enter;
            PwdText.Enter += PwdText_Enter;
        }

        private void LoginWindow_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            string username = UsernameText.Text.Trim().ToLower(); // Normalize input

            if (username == "user")
            {
                WinUser userForm = new WinUser();
                userForm.Show(); // Open WinUser
                this.Hide();     // Hide the login form
            }
            else if (username == "admin")
            {
                WinAdmin adminForm = new WinAdmin();
                adminForm.Show(); // Open WinAdmin
                this.Hide();      // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username! Please enter 'User' or 'Admin'.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UsernameText.Text = string.Empty;
            PwdText.Text = string.Empty;
        }

        private void UsernameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PwdText_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameText_Enter(object sender, EventArgs e)
        {
            if (!isUsernameCleared)
            {
                UsernameText.Text = string.Empty;
                isUsernameCleared = true;
            }
        }


        private void PwdText_Enter(object sender, EventArgs e)
        {
            if (!isPasswordCleared)
            {
                PwdText.Text = string.Empty;
                isPasswordCleared = true;
            }
        }
    }
}

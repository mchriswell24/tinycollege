using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tinycollege
{
    public partial class logins : Form
    {
        public logins()
        {
            InitializeComponent();
        }

        private void logins_Load(object sender, EventArgs e)
        {

        }
        private void PasswordBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameBtn_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string correctUsername = "username";
            string correctPassword = "password";

            string enteredUsername = UsernameBtn.Text;
            string enteredPassword = PasswordBtn.Text;

            if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {


                // Open AdminForm and close the current Login form
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

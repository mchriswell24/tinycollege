using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            string username = UsernameBtn.Text;
            string password = PasswordBtn.Text;

            if (username == "admin" && password == "password")
            {
                // Open the Prof form if login is successful
                Profes profesForm = new Profes();
                profesForm.Show();


            }
            else
            {
                MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}



    



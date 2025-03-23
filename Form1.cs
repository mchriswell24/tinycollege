namespace tinycollege
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
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
              
                Prof profForm = new Prof(); 
                profForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}


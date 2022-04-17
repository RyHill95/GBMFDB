namespace GBMFDB
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

        //Login Button, Username is Admin Password is Password. Displays error if incorrect login info provided. If successful, takes to Menu form -Ryan
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Admin" && txtPassword.Text == "Password")
            {
                new Menu().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The Username or Password entered is incorrect, please try again.");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        //Clear fields button. Empties entered text and returns to username field -Ryan
        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        //Exit applicaiton button. Closes Application -Ryan
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
namespace UserManager
{
    public partial class CreateForms : Form
    {
        public CreateForms()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            bool isInvalidInput = string.IsNullOrWhiteSpace(email)
                    || string.IsNullOrWhiteSpace(username)
                    || string.IsNullOrWhiteSpace(password);
            if (isInvalidInput)    
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UserRepository userRepository = new UserRepository();
                bool userAdded = userRepository.Add(username, password, email);
                if (userAdded)
                {
                    MessageBox.Show("User created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to create user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            
        }
    }
}

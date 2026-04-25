using System.Data.SqlClient;
namespace LOGON_APP
{
    public partial class RegisterForm : Form
    {
        private LoginForm LoginForm;
        public RegisterForm(LoginForm form)
        {
            InitializeComponent();
            LoginForm = form;
        }

        #region Backend events
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = UserNameTxt.Text;
            string password = PasswordText.Text;
            string confirmPassword = ConfirmPasswordText.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string hashedPassword = EncryptClass.HashPassword(password); // Ekriptovanje passworda

            using (SqlConnection conn = new SqlConnection(Connection.connectionString))
            {
                conn.Open();
                SqlCommand checkcmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @username", conn);
                checkcmd.Parameters.AddWithValue("@username", username);

                int existingUserCount = (int)checkcmd.ExecuteScalar();

                if (existingUserCount > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.");
                    return;
                }
                // Insert new user into the database    
                SqlCommand cmd = new SqlCommand("INSERT INTO Users (Username, PasswordHash) VALUES (@username, @password)", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashedPassword); // Store hashed password
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration successful! You can now log in.");

                LoginForm.SetUserName(username);
                // Goto login form
                LoginForm.Show();
                this.Close();
            }
        }
        #endregion
        #region Frontend events
        // Frontend events
        private void loginBtn_MouseEnter(object sender, EventArgs e) => loginBtn.FlatStyle = FlatStyle.Flat;

        private void loginBtn_MouseLeave(object sender, EventArgs e) => loginBtn.FlatStyle = FlatStyle.Standard;
        private void loginFormBtn_Click(object sender, EventArgs e)
        {
            LoginForm.Show();
            this.Close();
        }
        #endregion

    }
}

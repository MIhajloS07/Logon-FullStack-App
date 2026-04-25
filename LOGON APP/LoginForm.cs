using System.Data.SqlClient;

namespace LOGON_APP
{
    public partial class LoginForm : Form
    {
        public LoginForm() => InitializeComponent();

        public void SetUserName(string username) => UserNameTxt.Text = username;    

        private void registerFormBtn_Click(object sender, EventArgs e)
        {
            // Goto register form
            this.Hide();
            RegisterForm registerForm = new RegisterForm(this);
            registerForm.Show();
        }
        #region Backend events
        private void loginBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Connection.connectionString))
            {
                conn.Open();
                string username = UserNameTxt.Text;
                string password = PasswordText.Text;
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }
                SqlCommand cmd = new SqlCommand("SELECT Id, Username,PasswordHash FROM Users WHERE Username = @username", conn);
                cmd.Parameters.AddWithValue("@username", username);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (!reader.Read()) // nema reda u bazi
                    {
                        MessageBox.Show("Invalid username or password.");
                        return;
                    }

                    int userId = Convert.ToInt32(reader["Id"]);
                    string storedUsername = reader["Username"].ToString();
                    string storedHash = reader["PasswordHash"].ToString();

                    // Case-sensitive check
                    if (storedUsername != username)
                    {
                        MessageBox.Show("Invalid username or password.");
                        return;
                    }

                    string enteredHash = EncryptClass.HashPassword(password);
                    if (storedHash == enteredHash)
                    {
                        MessageBox.Show("Login successful!");
                        ApplicationForm appForm = new ApplicationForm();
                        appForm.SetUser(userId, username);
                        this.Hide();
                        appForm.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
        }
        #endregion
        #region Frontend events
        // Frontend events
        private void loginBtn_MouseEnter(object sender, EventArgs e) => loginBtn.FlatStyle = FlatStyle.Flat;

        private void loginBtn_MouseLeave(object sender, EventArgs e) => loginBtn.FlatStyle = FlatStyle.Standard;
        #endregion
    }
}

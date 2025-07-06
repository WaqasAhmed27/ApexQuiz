using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.Text.RegularExpressions;

namespace Apex_Quiz
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            createAccountButton.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string email = emailTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            // Validate if all fields are filled
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            // Email format validation
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }
            if (!IsValidPassword(password))
            {
                MessageBox.Show("Pass must be between 5-15 characters and contain atleast one letter.");
                return;
            }

            // Hash the password
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            // Proceed with inserting data into the database
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO users (username, email, password_hash) VALUES (@username, @email, @password)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Signup Successful!");

                        // Navigate to the next form
                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
        private bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[a-zA-Z])[a-zA-Z\d]{5,15}$";
            return Regex.IsMatch(password, pattern);
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}

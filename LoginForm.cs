//Waqas bhai idhar sql ke directory include karo
using Apex_Quiz;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace Apex_Quiz
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Linker jo login se sign p ke taraf le kar jai ga 
        }


        private void txtuser_TextChanged(object sender, EventArgs e)
        {
            //text box kuch mat likho isme
        }
        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            //text box kuch mat likho isme
        }
        private void txtpass_TextChanged(object sender, EventArgs e)
        {
            //textbox for password
        }

        //Check Box
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtpass.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text.Trim();
            string password = txtpass.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password!");
                return;
            }

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT user_id, password_hash FROM users WHERE username = @username";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["password_hash"].ToString();
                            if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                            {
                                // Store the user_id in UserSession
                                UserSession.CurrentUserId = Convert.ToInt32(reader["user_id"]);

                                // Open the menu form and hide login form
                                Menu menu = new Menu();
                                menu.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Password!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found!");
                        }
                    }
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //Cancel Button
            //ye isliye rakh raho ke ek user story ban jain, jo kah ke ek home page hona chahey aur ye cancel button home page per le jai
            this.Close();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
            this.Show();
        }
    }
}

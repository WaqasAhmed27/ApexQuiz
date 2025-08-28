using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Apex_Quiz
{
    public partial class DailyChallengeForm : Form
    {
        private string correctAnswer;
        private int dailyStreak = 0;
        private static string cooldownPath = "daily_cooldown.txt";

        public DailyChallengeForm()
        {
            if (IsCooldownActive())
            {
                MessageBox.Show("Please wait! Daily Challenge will be available after 24 hours.");
                return;
            }

            InitializeComponent();
            LoadDailyChallengeQuestion();
        }

        private void LoadDailyChallengeQuestion()
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT question_text, option_a, option_b, option_c, option_d, correct_option, q.quiz_id, t.category 
                    FROM questions q
                    JOIN quizzes t ON q.quiz_id = t.quiz_id
                    ORDER BY RAND()
                    LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        label1.Text = reader["question_text"].ToString();
                        textBox1.Text = "Category: " + reader["category"].ToString();

                        button1.Text = reader["option_a"].ToString();
                        button2.Text = reader["option_b"].ToString();
                        button3.Text = reader["option_c"].ToString();
                        button4.Text = reader["option_d"].ToString();

                        correctAnswer = reader["correct_option"].ToString();
                    }
                }
            }
        }

        private void OptionButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.Text == correctAnswer)
            {
                dailyStreak++;
                MessageBox.Show($"Correct! Streak: {dailyStreak}");
            }
            else
            {
                dailyStreak = 0;
                MessageBox.Show("Incorrect! Streak reset.");
            }

            SaveCooldown();
            this.Close();
        }

        private void SaveCooldown()
        {
            File.WriteAllText(cooldownPath, DateTime.Now.ToString());
        }

        private bool IsCooldownActive()
        {
            if (!File.Exists(cooldownPath))
                return false;

            DateTime lastPlayed = DateTime.Parse(File.ReadAllText(cooldownPath));
            return (DateTime.Now - lastPlayed).TotalHours < 24;
        }

        // Empty handlers to avoid compiler error
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void Form1_Load(object sender, EventArgs e) { }
    }
}

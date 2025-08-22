using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Apex_Quiz
{
    public partial class AddQuestionForm : Form
    {
        private int quizId; // Store the quiz ID for associating the question

        public AddQuestionForm(int quizId)
        {
            InitializeComponent();
            this.quizId = quizId; // Store the quiz ID
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
        {
            string questionText = txtQuestion.Text.Trim();
            string optionA = txtOptionA.Text.Trim();
            string optionB = txtOptionB.Text.Trim();
            string optionC = txtOptionC.Text.Trim();
            string optionD = txtOptionD.Text.Trim();
            string correctAnswer = cmbCorrectAnswer.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(questionText) || string.IsNullOrEmpty(optionA) ||
                string.IsNullOrEmpty(optionB) || string.IsNullOrEmpty(optionC) ||
                string.IsNullOrEmpty(optionD) || string.IsNullOrEmpty(correctAnswer))
            {
                MessageBox.Show("All fields are required!");
                return;
            }

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO questions (quiz_id, question_text, option_a, option_b, option_c, option_d, correct_option) " +
                               "VALUES (@quizId, @question, @optionA, @optionB, @optionC, @optionD, @correctOption)";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@quizId", quizId);
                    cmd.Parameters.AddWithValue("@question", questionText);
                    cmd.Parameters.AddWithValue("@optionA", optionA);
                    cmd.Parameters.AddWithValue("@optionB", optionB);
                    cmd.Parameters.AddWithValue("@optionC", optionC);
                    cmd.Parameters.AddWithValue("@optionD", optionD);
                    cmd.Parameters.AddWithValue("@correctOption", correctAnswer);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Question added successfully!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void AddQuestionForm_Load(object sender, EventArgs e)
        {
            // Populate the correct answer dropdown
            cmbCorrectAnswer.Items.Add("A");
            cmbCorrectAnswer.Items.Add("B");
            cmbCorrectAnswer.Items.Add("C");
            cmbCorrectAnswer.Items.Add("D");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Apex_Quiz
{
    public partial class FlashcardsForm : Form
    {
        private List<Flashcard> flashcards;
        private int currentFlashcardIndex;

        public FlashcardsForm()
        {
            InitializeComponent();
            LoadFlashcards();
            currentFlashcardIndex = 0;
        }

        private void FlashcardsForm_Load(object sender, EventArgs e)
        {
            DisplayFlashcard();
        }

        private void LoadFlashcards()
        {
            flashcards = new List<Flashcard>();

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT FlashcardID, UserID, Topic, Question, Answer, CreatedAt FROM Flashcards";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        flashcards.Add(new Flashcard
                        {
                            FlashcardId = Convert.ToInt32(reader["FlashcardID"]),
                            UserId = Convert.ToInt32(reader["UserID"]),
                            Topic = reader["Topic"].ToString(),
                            QuestionText = reader["Question"].ToString(),
                            AnswerText = reader["Answer"].ToString(),
                            CreatedAt = Convert.ToDateTime(reader["CreatedAt"])
                        });
                    }
                }
            }
        }


        private void DisplayFlashcard()
        {
            if (flashcards.Count > 0 && currentFlashcardIndex < flashcards.Count)
            {
                var flashcard = flashcards[currentFlashcardIndex];

                // Check if the question is empty or null and show a default text if needed
                lblQuestion.Text = string.IsNullOrEmpty(flashcard.QuestionText) ? "No question available" : flashcard.QuestionText;

                // Display the topic if available
                lblCategory.Text = string.IsNullOrEmpty(flashcard.Topic) ? "Topic: Not assigned" : $"Topic: {flashcard.Topic}";

                // Set a default value for Hint (optional, depending on your design)
                lblHint.Text = "Hint: Hidden";

                // Display a default text for answer (if needed)
                lblAnswer.Text = "Answer: Not yet revealed";
            }
            else
            {
                MessageBox.Show("No flashcards available.");
            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentFlashcardIndex < flashcards.Count - 1)
            {
                currentFlashcardIndex++;
                DisplayFlashcard();
            }
            else
            {
                MessageBox.Show("End of flashcards.");
            }
        }

        private void btnShowAnswer_Click(object sender, EventArgs e)
        {
            var flashcard = flashcards[currentFlashcardIndex];
            lblAnswer.Text = $"Answer: {flashcard.AnswerText}";
        }

        private void btnShowHint_Click(object sender, EventArgs e)
        {
            var flashcard = flashcards[currentFlashcardIndex];
            MessageBox.Show(flashcard.HintText, "Hint");
        }
    }

    public class Flashcard
    {
        public int FlashcardId { get; set; }
        public string QuestionText { get; set; }
        public string AnswerText { get; set; }
        public string Category { get; set; }
        public string HintText { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UserId { get; set; }
        public string Topic { get; set; }

    }
}

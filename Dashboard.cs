using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Apex_Quiz
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.Load += Dashboard_Load;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

            LoadStats();
            LoadQuizzes();
        }

        private void LoadStats()
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Get total quizzes
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM quizzes", conn))
                {
                    lblTotalQuizzes.Text = $"Total Quizzes: {cmd.ExecuteScalar()}";
                }

                // Get total questions
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM questions", conn))
                {
                    lblTotalQuestions.Text = $"Total Questions: {cmd.ExecuteScalar()}";
                }

                // Get total players
                using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM users", conn))
                {
                    lblTotalPlayers.Text = $"Total Players: {cmd.ExecuteScalar()}";
                }
            }
        }

        private void LoadQuizzes()
        {
            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT quiz_id, title, category, difficulty, created_at FROM quizzes";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvQuizzes.DataSource = dt;
                }
            }
        }

        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            CreateQuizForm createQuizForm = new CreateQuizForm();
            createQuizForm.ShowDialog();
            LoadQuizzes(); // Refresh list after quiz creation
            LoadStats();
        }


        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            if (dgvQuizzes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a quiz to start.");
                return;
            }

            // Get the quizId of the selected quiz
            int quizId = Convert.ToInt32(dgvQuizzes.SelectedRows[0].Cells["quiz_id"].Value);

            // Open the StartSpecificQuizForm and pass the quizId
            StartSpecificQuizForm startSpecificQuizForm = new StartSpecificQuizForm(quizId);
            startSpecificQuizForm.ShowDialog();  // Show it as a modal dialog
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}

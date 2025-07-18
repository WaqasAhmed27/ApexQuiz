using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Linq;
namespace ApexQuizDesktop
{
    public partial class QuestionBank : Form
    {
        private string connectionString = "server=localhost;database=apex_quiz;uid=root;pwd=changing2;";

        public QuestionBank()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void btnLoadQuestions_Click(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem != null)
            {
                LoadQuestions(cmbCategory.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Please select a category first.");
            }
        }

        private void LoadCategories()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, name FROM categories";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            Dictionary<int, string> categoryMap = new Dictionary<int, string>();
                            while (reader.Read())
                            {
                                int id = reader.GetInt32("id");
                                string name = reader.GetString("name");
                                categoryMap[id] = name;
                                cmbCategory.Items.Add(name);
                            }
                            cmbCategory.Tag = categoryMap; // Store category mapping
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message);
            }
        }

        private void LoadQuestions(string categoryName)
        {
            try
            {
                Dictionary<int, string> categoryMap = cmbCategory.Tag as Dictionary<int, string>;
                int categoryId = categoryMap.FirstOrDefault(x => x.Value == categoryName).Key;

                if (categoryId == 0)
                {
                    MessageBox.Show("Invalid category selection.");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT question_text FROM questions WHERE category_id = @categoryId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@categoryId", categoryId);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvQuestions.DataSource = dt;
                            dgvQuestions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading questions: " + ex.Message);
            }
        }

    }
}

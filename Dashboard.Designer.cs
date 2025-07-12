using System;
using System.Drawing;
using System.Windows.Forms;

namespace Apex_Quiz
{
    partial class Dashboard : Form
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTotalQuizzes;
        private Label lblTotalQuestions;
        private Label lblTotalPlayers;
        private Button btnCreateQuiz;
        private Button btnStartQuiz;
        private DataGridView dgvQuizzes;
        private Panel panelQuizzes;
        private Button btnClose;
        private PictureBox pictureBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTotalQuizzes = new System.Windows.Forms.Label();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.lblTotalPlayers = new System.Windows.Forms.Label();
            this.btnCreateQuiz = new System.Windows.Forms.Button();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.dgvQuizzes = new System.Windows.Forms.DataGridView();
            this.panelQuizzes = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuizzes)).BeginInit();
            this.panelQuizzes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalQuizzes
            // 
            this.lblTotalQuizzes.AutoSize = true;
            this.lblTotalQuizzes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalQuizzes.ForeColor = System.Drawing.Color.White;
            this.lblTotalQuizzes.Location = new System.Drawing.Point(31, 50);
            this.lblTotalQuizzes.Name = "lblTotalQuizzes";
            this.lblTotalQuizzes.Size = new System.Drawing.Size(193, 32);
            this.lblTotalQuizzes.TabIndex = 2;
            this.lblTotalQuizzes.Text = "Total Quizzes: 0";
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.AutoSize = true;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalQuestions.ForeColor = System.Drawing.Color.White;
            this.lblTotalQuestions.Location = new System.Drawing.Point(230, 50);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(219, 32);
            this.lblTotalQuestions.TabIndex = 3;
            this.lblTotalQuestions.Text = "Total Questions: 0";
            // 
            // lblTotalPlayers
            // 
            this.lblTotalPlayers.AutoSize = true;
            this.lblTotalPlayers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalPlayers.ForeColor = System.Drawing.Color.White;
            this.lblTotalPlayers.Location = new System.Drawing.Point(465, 50);
            this.lblTotalPlayers.Name = "lblTotalPlayers";
            this.lblTotalPlayers.Size = new System.Drawing.Size(187, 32);
            this.lblTotalPlayers.TabIndex = 4;
            this.lblTotalPlayers.Text = "Total Players: 0";
            // 
            // btnCreateQuiz
            // 
            this.btnCreateQuiz.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnCreateQuiz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateQuiz.ForeColor = System.Drawing.Color.White;
            this.btnCreateQuiz.Location = new System.Drawing.Point(47, 397);
            this.btnCreateQuiz.Name = "btnCreateQuiz";
            this.btnCreateQuiz.Size = new System.Drawing.Size(160, 45);
            this.btnCreateQuiz.TabIndex = 5;
            this.btnCreateQuiz.Text = "Create Quiz";
            this.btnCreateQuiz.UseVisualStyleBackColor = false;
            this.btnCreateQuiz.Click += new System.EventHandler(this.btnCreateQuiz_Click);
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.BackColor = System.Drawing.Color.DarkOrange;
            this.btnStartQuiz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnStartQuiz.ForeColor = System.Drawing.Color.White;
            this.btnStartQuiz.Location = new System.Drawing.Point(230, 397);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(160, 45);
            this.btnStartQuiz.TabIndex = 6;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = false;
            this.btnStartQuiz.Click += new System.EventHandler(this.btnStartQuiz_Click);
            // 
            // dgvQuizzes
            // 
            this.dgvQuizzes.AllowUserToAddRows = false;
            this.dgvQuizzes.AllowUserToDeleteRows = false;
            this.dgvQuizzes.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuizzes.ColumnHeadersHeight = 29;
            this.dgvQuizzes.Location = new System.Drawing.Point(5, 5);
            this.dgvQuizzes.MultiSelect = false;
            this.dgvQuizzes.Name = "dgvQuizzes";
            this.dgvQuizzes.RowHeadersVisible = false;
            this.dgvQuizzes.RowHeadersWidth = 51;
            this.dgvQuizzes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuizzes.Size = new System.Drawing.Size(600, 250);
            this.dgvQuizzes.TabIndex = 0;
            // 
            // panelQuizzes
            // 
            this.panelQuizzes.BackColor = System.Drawing.Color.White;
            this.panelQuizzes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuizzes.Controls.Add(this.dgvQuizzes);
            this.panelQuizzes.Location = new System.Drawing.Point(42, 104);
            this.panelQuizzes.Name = "panelQuizzes";
            this.panelQuizzes.Size = new System.Drawing.Size(610, 260);
            this.panelQuizzes.TabIndex = 7;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(652, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(36, 39);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Apex_Quiz.Properties.Resources.ApexQuizLogo_png;
            this.pictureBox1.Location = new System.Drawing.Point(500, 396);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::Apex_Quiz.Properties.Resources.turn_back;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(36, 35);
            this.btnBack.TabIndex = 8;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTotalQuizzes);
            this.Controls.Add(this.lblTotalQuestions);
            this.Controls.Add(this.lblTotalPlayers);
            this.Controls.Add(this.btnCreateQuiz);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.panelQuizzes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuizzes)).EndInit();
            this.panelQuizzes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnBack;
    }
}

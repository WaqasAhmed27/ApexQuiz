namespace Apex_Quiz
{
    partial class AddQuestionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.TextBox txtOptionD;
        private System.Windows.Forms.ComboBox cmbCorrectAnswer;
        private System.Windows.Forms.Button btnSaveQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.Label lblCorrectAnswer;

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
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.txtOptionD = new System.Windows.Forms.TextBox();
            this.cmbCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.btnSaveQuestion = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.lblCorrectAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(30, 50);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Size = new System.Drawing.Size(400, 60);
            this.txtQuestion.Name = "txtQuestion";

            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(30, 30);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Text = "Enter Question:";

            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Location = new System.Drawing.Point(30, 120);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Text = "Enter Options:";

            // 
            // txtOptionA
            // 
            this.txtOptionA.Location = new System.Drawing.Point(30, 150);
            this.txtOptionA.Size = new System.Drawing.Size(190, 22);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.Text = "Option A";

            // 
            // txtOptionB
            // 
            this.txtOptionB.Location = new System.Drawing.Point(240, 150);
            this.txtOptionB.Size = new System.Drawing.Size(190, 22);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.Text = "Option B";

            // 
            // txtOptionC
            // 
            this.txtOptionC.Location = new System.Drawing.Point(30, 180);
            this.txtOptionC.Size = new System.Drawing.Size(190, 22);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.Text = "Option C";

            // 
            // txtOptionD
            // 
            this.txtOptionD.Location = new System.Drawing.Point(240, 180);
            this.txtOptionD.Size = new System.Drawing.Size(190, 22);
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.Text = "Option D";

            // 
            // lblCorrectAnswer
            // 
            this.lblCorrectAnswer.AutoSize = true;
            this.lblCorrectAnswer.Location = new System.Drawing.Point(30, 220);
            this.lblCorrectAnswer.Name = "lblCorrectAnswer";
            this.lblCorrectAnswer.Text = "Select Correct Answer:";

            // 
            // cmbCorrectAnswer
            // 
            this.cmbCorrectAnswer.Location = new System.Drawing.Point(30, 240);
            this.cmbCorrectAnswer.Size = new System.Drawing.Size(150, 22);
            this.cmbCorrectAnswer.Name = "cmbCorrectAnswer";

            // 
            // btnSaveQuestion
            // 
            this.btnSaveQuestion.Location = new System.Drawing.Point(30, 280);
            this.btnSaveQuestion.Size = new System.Drawing.Size(150, 40);
            this.btnSaveQuestion.Name = "btnSaveQuestion";
            this.btnSaveQuestion.Text = "Save Question";
            this.btnSaveQuestion.Click += new System.EventHandler(this.btnSaveQuestion_Click);

            // 
            // AddQuestionForm
            // 
            this.ClientSize = new System.Drawing.Size(480, 350);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.txtOptionA);
            this.Controls.Add(this.txtOptionB);
            this.Controls.Add(this.txtOptionC);
            this.Controls.Add(this.txtOptionD);
            this.Controls.Add(this.lblCorrectAnswer);
            this.Controls.Add(this.cmbCorrectAnswer);
            this.Controls.Add(this.btnSaveQuestion);
            this.Name = "AddQuestionForm";
            this.Text = "Add New Question";
            this.Load += new System.EventHandler(this.AddQuestionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

namespace ApexQuizDesktop
{
    partial class QuestionBank
    {
        private System.ComponentModel.IContainer components = null;

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
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnLoadQuestions = new System.Windows.Forms.Button();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.lblCategory = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();

            // Form Properties
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.FromArgb(255, 240, 250);
            this.ClientSize = new System.Drawing.Size(750, 500);

            // Category Label
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(20, 20);
            this.lblCategory.Text = "Category:";

            // Category ComboBox
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.Location = new System.Drawing.Point(100, 17);
            this.cmbCategory.Size = new System.Drawing.Size(250, 30);

            // Load Questions Button
            this.btnLoadQuestions.Text = "Load Questions";
            this.btnLoadQuestions.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadQuestions.BackColor = System.Drawing.Color.FromArgb(255, 100, 200);
            this.btnLoadQuestions.ForeColor = System.Drawing.Color.White;
            this.btnLoadQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadQuestions.FlatAppearance.BorderSize = 0;
            this.btnLoadQuestions.Location = new System.Drawing.Point(370, 17);
            this.btnLoadQuestions.Size = new System.Drawing.Size(150, 30);
            this.btnLoadQuestions.Click += new System.EventHandler(this.btnLoadQuestions_Click);

            // DataGridView (Question List)
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuestions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQuestions.ColumnHeadersVisible = false;
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuestions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvQuestions.Location = new System.Drawing.Point(20, 70);
            this.dgvQuestions.Size = new System.Drawing.Size(700, 400);
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersVisible = false;

            // Add Controls
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.btnLoadQuestions);
            this.Controls.Add(this.dgvQuestions);

            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnLoadQuestions;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Label lblCategory;
    }
}

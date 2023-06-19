namespace LearningPlatform.View.AdminForms
{
    partial class AddingTestsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingTestsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TestNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuestionTextBox = new System.Windows.Forms.TextBox();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TestQuestionsListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddQuestionButton = new System.Windows.Forms.Button();
            this.RemoveQuestionButton = new System.Windows.Forms.Button();
            this.AddTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Форма добавления теста";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Название теста: ";
            // 
            // TestNameTextBox
            // 
            this.TestNameTextBox.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestNameTextBox.Location = new System.Drawing.Point(213, 44);
            this.TestNameTextBox.Multiline = true;
            this.TestNameTextBox.Name = "TestNameTextBox";
            this.TestNameTextBox.Size = new System.Drawing.Size(475, 20);
            this.TestNameTextBox.TabIndex = 2;
            this.TestNameTextBox.Text = "Введите название теста";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вопрос: ";
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionTextBox.Location = new System.Drawing.Point(121, 98);
            this.QuestionTextBox.Multiline = true;
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(273, 102);
            this.QuestionTextBox.TabIndex = 4;
            this.QuestionTextBox.Text = "Введите вопрос";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerTextBox.Location = new System.Drawing.Point(121, 256);
            this.AnswerTextBox.Multiline = true;
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(273, 102);
            this.AnswerTextBox.TabIndex = 6;
            this.AnswerTextBox.Text = "Введите ответ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ответ: ";
            // 
            // TestQuestionsListBox
            // 
            this.TestQuestionsListBox.FormattingEnabled = true;
            this.TestQuestionsListBox.Location = new System.Drawing.Point(551, 98);
            this.TestQuestionsListBox.Name = "TestQuestionsListBox";
            this.TestQuestionsListBox.Size = new System.Drawing.Size(237, 290);
            this.TestQuestionsListBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(637, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Вопросы";
            // 
            // AddQuestionButton
            // 
            this.AddQuestionButton.Location = new System.Drawing.Point(433, 183);
            this.AddQuestionButton.Name = "AddQuestionButton";
            this.AddQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.AddQuestionButton.TabIndex = 9;
            this.AddQuestionButton.Text = "------>";
            this.AddQuestionButton.UseVisualStyleBackColor = true;
            this.AddQuestionButton.Click += new System.EventHandler(this.AddQuestionButton_Click);
            // 
            // RemoveQuestionButton
            // 
            this.RemoveQuestionButton.Location = new System.Drawing.Point(433, 253);
            this.RemoveQuestionButton.Name = "RemoveQuestionButton";
            this.RemoveQuestionButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveQuestionButton.TabIndex = 10;
            this.RemoveQuestionButton.Text = "<------";
            this.RemoveQuestionButton.UseVisualStyleBackColor = true;
            this.RemoveQuestionButton.Click += new System.EventHandler(this.RemoveQuestionButton_Click);
            // 
            // AddTestButton
            // 
            this.AddTestButton.Location = new System.Drawing.Point(615, 402);
            this.AddTestButton.Name = "AddTestButton";
            this.AddTestButton.Size = new System.Drawing.Size(151, 36);
            this.AddTestButton.TabIndex = 11;
            this.AddTestButton.Text = "Добавить тест";
            this.AddTestButton.UseVisualStyleBackColor = true;
            this.AddTestButton.Click += new System.EventHandler(this.AddTestButton_Click);
            // 
            // AddingTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddTestButton);
            this.Controls.Add(this.RemoveQuestionButton);
            this.Controls.Add(this.AddQuestionButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TestQuestionsListBox);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.QuestionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TestNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddingTestsForm";
            this.Text = "AddingTestsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TestNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox QuestionTextBox;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox TestQuestionsListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddQuestionButton;
        private System.Windows.Forms.Button RemoveQuestionButton;
        private System.Windows.Forms.Button AddTestButton;
    }
}
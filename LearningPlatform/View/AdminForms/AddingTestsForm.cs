using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LearningPlatform.Model;
using LearningPlatform.Controller;

namespace LearningPlatform.View.AdminForms
{
    public partial class AddingTestsForm : Form
    {
        
        Test test = new Test();

        public AddingTestsForm()
        {
            InitializeComponent();
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            if(QuestionTextBox.Text != "" || AnswerTextBox.Text !="")
            {
                test.Questions.Add(new Question()
                {
                    Title = QuestionTextBox.Text,
                    Answers = AnswerTextBox.Text,
                });
                UpdateTestQuestions();
            }
        }

        private void RemoveQuestionButton_Click(object sender, EventArgs e)
        {
            test.Questions.Remove((Question)TestQuestionsListBox.SelectedItem);
            UpdateTestQuestions();
        }

        private void AddTestButton_Click(object sender, EventArgs e)
        {
            test.Name = TestNameTextBox.Text;
            if(TestQuestionsListBox.Items.Count > 0) 
            {
                DatabaseManagement.instance.AddTestAsync(test);
            }
           else
            {
                return;
            }

        }

        private void UpdateTestQuestions()
        {
            TestQuestionsListBox.Items.Clear();
            foreach(Question question in test.Questions) 
            { 
                TestQuestionsListBox.Items.Add(question);
            }
        }
    }
}

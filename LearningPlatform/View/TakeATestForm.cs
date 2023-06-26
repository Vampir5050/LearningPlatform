using LearningPlatform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningPlatform.View
{
    public partial class TakeATestForm : Form
    {
        int Counter = 0;
        int RightAnswers = 0;
        Test tempTest;
        public TakeATestForm(Test test)
        {
            tempTest = test;
            InitializeComponent();
            label1.Text += tempTest.Name;
            label2.Text += tempTest.Questions.ElementAt(Counter).Title;
            label4.Text += tempTest.Questions.Count();
            Counter++;
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            
            if(Counter > tempTest.Questions.Count())
            {
                AnswerButton.Enabled = false;
                label5.Text += RightAnswers.ToString();
                return;
            }
            Question TempQuestion = tempTest.Questions.ElementAt(Counter - 1);
            if (TempQuestion is null)
            {
                return;
            }

            if (Counter < tempTest.Questions.Count())
            {
                UpdateQuestion();
                TestCheck(TempQuestion);
            }
            else
            {
                TestCheck(TempQuestion);
                AnswerButton.Enabled = false;
                label5.Text += RightAnswers.ToString();
            }

        }


        private void UpdateQuestion()
        {
            label2.Text = "Вопрос: " + tempTest.Questions.ElementAt(Counter).Title;
        }

        private void TestCheck(Question question)
        {
            if (textBox1.Text.ToLower() == question.Answers.ToLower())
            {
                RightAnswers++;
                Counter++;
            }
            else
            {
                Counter++;
            }
        }

    }
}

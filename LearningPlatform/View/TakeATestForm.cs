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
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            Question TempQuestion = tempTest.Questions.ElementAt(Counter);
            if (TempQuestion is null)
            {
                return;
            }
            if(textBox1.Text == TempQuestion.Answers)
            {
                RightAnswers++;
                Counter++;
            }
            else
            {
                Counter++;
            }
            if(Counter == tempTest.Questions.LastOrDefault().ID)
            {
                return;
            }

            label2.Text = "Вопрос: " + tempTest.Questions.ElementAt(Counter++).Title; ;
        }
    }
}

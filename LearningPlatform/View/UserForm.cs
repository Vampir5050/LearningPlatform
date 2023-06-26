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
    public partial class UserForm : Form
    {
        public UserForm(User user)
        {
            InitializeComponent();
            LabelName.Text += user.PersonalData.FirstName.ToString();
            LabelSecondName.Text += user.PersonalData.SecondName.ToString();
            LabelPhone.Text += user.PersonalData.PhoneNumber.ToString();
            LabelMail.Text += user.PersonalData.Email.ToString();
            LabelMark.Text += user.PersonalData.AverageMark.ToString();

        }
    }
}

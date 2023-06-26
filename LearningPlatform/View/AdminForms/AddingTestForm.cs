using LearningPlatform.Controller;
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
    public partial class AddingUserForm : Form
    {
        public AddingUserForm()
        {
            InitializeComponent();
            #region
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            this.SetStyle(ControlStyles.Opaque, false);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            #endregion
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            //проверки на заполненость полей
            #region
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(SecondNameTextBox.Text))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(PhoneNumbeTextBox.Text))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                return;
            }
            if(RoleComboBox.SelectedItem == null)
            {
                return;
            }
            #endregion
            var user = new Model.User()
            {
                Login = LoginTextBox.Text,
                Password = PasswordTextBox.Text
            };
            switch (RoleComboBox.SelectedItem)
            {
                case "Администратор":
                    {
                        user.Role = Model.RoleType.Admin;
                    }
                    break;
                case "Студент":
                    {
                        user.Role = Model.RoleType.User;
                    }
                    break;
                case "Преподователь":
                    {
                        user.Role = Model.RoleType.Teacher;
                    }
                    break;

                default:
                    MessageBox.Show("Не выбрана роль!");
                    break;
            }
            user.PersonalData.FirstName = FirstNameTextBox.Text;
            user.PersonalData.SecondName = SecondNameTextBox.Text;
            user.PersonalData.PhoneNumber = PhoneNumbeTextBox.Text;
            user.PersonalData.Email = EmailTextBox.Text;
            var check = await AdminManager.instance.AddUser(user);
            if(check)
            {
                MessageBox.Show("Пользователь успешно добавлен");
            }
            else
            {
                MessageBox.Show("Такой пользователь уже существует");
            }
            LoginTextBox.Text = "";
            FirstNameTextBox.Text = "";
            SecondNameTextBox.Text = "";
            PhoneNumbeTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";

        }
    }
}

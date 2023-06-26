using LearningPlatform.Controller;
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
    public partial class UsersForm : Form
    {
        List<User> users;
        User user;
        public UsersForm()
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
            if (string.IsNullOrWhiteSpace(Login.Text))
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
                Login = Login.Text,
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
            Login.Text = "";
            FirstNameTextBox.Text = "";
            SecondNameTextBox.Text = "";
            PhoneNumbeTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";
        }

        private async void ChangeButton_Click(object sender, EventArgs e)
        {
            if (ChangeUserComboBox.SelectedItem == null) return;
            
            foreach (User item in users)
            {
                if(ChangeUserComboBox.SelectedItem.ToString() == item.ToString())
                {
                    user = item;
                    break;
                }
            }
            if (user == null) return;
            if (!string.IsNullOrWhiteSpace(ChangedFirstNameTextBox.Text)) user.PersonalData.FirstName = ChangedFirstNameTextBox.Text;
            if (!string.IsNullOrWhiteSpace(ChangedSecondNameTextBox.Text)) user.PersonalData.SecondName = ChangedSecondNameTextBox.Text;
            if (!string.IsNullOrWhiteSpace(ChangedEmailTextBox.Text)) user.PersonalData.Email = ChangedEmailTextBox.Text;
            if (!string.IsNullOrWhiteSpace(ChangedPhoneNumberTextBox.Text)) user.PersonalData.PhoneNumber = ChangedPhoneNumberTextBox.Text;
            await AdminManager.instance.ChangeUser(user);
            await UpdateUsers();
            ChangedFirstNameTextBox.Text = "";
            ChangedSecondNameTextBox.Text = "";
            ChangedEmailTextBox.Text = "";
            ChangedPhoneNumberTextBox.Text = "";
        }

        public async Task UpdateUsers()
        {
            if (ChangeUserComboBox.Items != null)
            {
                ChangeUserComboBox.Items.Clear();
                ChangeUserComboBox.SelectedItem = null;
            }
            if(RemoveUserComboBox.Items!=null)
            {
                RemoveUserComboBox.Items.Clear();
                RemoveUserComboBox.SelectedItem = null;
            }
            users = await DatabaseManagement.instance.GetUsers();
            foreach (var item in users)
            {
                if (item.Role == RoleType.Admin) continue;
                ChangeUserComboBox.Items.Add(item.ToString());
                RemoveUserComboBox.Items.Add(item.ToString());
            }
            ChangeUserComboBox.Text = "Выберите пользователя";
            RemoveUserComboBox.Text = "Выберите пользователя";
        }
        private async void UsersForm_Load(object sender, EventArgs e)
        {
            await UpdateUsers();
        }

        private async void RemoveButton_Click(object sender, EventArgs e)
        {
            if (RemoveUserComboBox.SelectedItem == null) return;

            foreach (User item in users)
            {
                if (RemoveUserComboBox.SelectedItem.ToString() == item.ToString())
                {
                    user = item;
                    break;
                }
            }
            if (user == null) return;
            await AdminManager.instance.RemoveUser(user);
            await UpdateUsers();
        }
    }
}

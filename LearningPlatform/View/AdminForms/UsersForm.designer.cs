using System.Windows.Forms;
namespace LearningPlatform.View
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.PasswordTextBox = new CueTextBox();
            this.EmailTextBox = new CueTextBox();
            this.SecondNameTextBox = new CueTextBox();
            this.FirstNameTextBox = new CueTextBox();
            this.LoginTextBox = new CueTextBox();
            this.PhoneNumbeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ChangedPhoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ChangedEmailTextBox = new CueTextBox();
            this.ChangedSecondNameTextBox = new CueTextBox();
            this.ChangedFirstNameTextBox = new CueTextBox();
            this.ChangeUserComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RemoveUserComboBox = new System.Windows.Forms.ComboBox();
            this.Login = new CueTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1259, 484);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.Login);
            this.tabPage1.Controls.Add(this.PasswordTextBox);
            this.tabPage1.Controls.Add(this.EmailTextBox);
            this.tabPage1.Controls.Add(this.SecondNameTextBox);
            this.tabPage1.Controls.Add(this.FirstNameTextBox);
            this.tabPage1.Controls.Add(this.LoginTextBox);
            this.tabPage1.Controls.Add(this.PhoneNumbeTextBox);
            this.tabPage1.Controls.Add(this.AddButton);
            this.tabPage1.Controls.Add(this.RoleComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1251, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Cue = "Введите пароль";
            this.PasswordTextBox.Location = new System.Drawing.Point(445, 331);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(360, 19);
            this.PasswordTextBox.TabIndex = 21;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextBox.Cue = "Введите email";
            this.EmailTextBox.Location = new System.Drawing.Point(445, 227);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(360, 19);
            this.EmailTextBox.TabIndex = 20;
            // 
            // SecondNameTextBox
            // 
            this.SecondNameTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.SecondNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondNameTextBox.Cue = "Введите фамилию";
            this.SecondNameTextBox.Location = new System.Drawing.Point(445, 132);
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            this.SecondNameTextBox.Size = new System.Drawing.Size(360, 19);
            this.SecondNameTextBox.TabIndex = 19;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameTextBox.Cue = "Введите имя";
            this.FirstNameTextBox.Location = new System.Drawing.Point(445, 75);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(360, 19);
            this.FirstNameTextBox.TabIndex = 18;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.Cue = "Введите логин";
            this.LoginTextBox.Location = new System.Drawing.Point(16, -31);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(360, 19);
            this.LoginTextBox.TabIndex = 17;
            // 
            // PhoneNumbeTextBox
            // 
            this.PhoneNumbeTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.PhoneNumbeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumbeTextBox.Location = new System.Drawing.Point(445, 179);
            this.PhoneNumbeTextBox.Mask = "8(999) 000-0000";
            this.PhoneNumbeTextBox.Name = "PhoneNumbeTextBox";
            this.PhoneNumbeTextBox.Size = new System.Drawing.Size(360, 19);
            this.PhoneNumbeTextBox.TabIndex = 16;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Elephant", 13.8F);
            this.AddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddButton.Location = new System.Drawing.Point(445, 368);
            this.AddButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(360, 72);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить пользователя";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RoleComboBox.BackColor = System.Drawing.Color.LightBlue;
            this.RoleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RoleComboBox.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            "Администратор",
            "Студент",
            "Преподаватель"});
            this.RoleComboBox.Location = new System.Drawing.Point(502, 19);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(221, 24);
            this.RoleComboBox.TabIndex = 15;
            this.RoleComboBox.Text = "Выберите роль";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Teal;
            this.tabPage3.Controls.Add(this.ChangeButton);
            this.tabPage3.Controls.Add(this.ChangedPhoneNumberTextBox);
            this.tabPage3.Controls.Add(this.ChangedEmailTextBox);
            this.tabPage3.Controls.Add(this.ChangedSecondNameTextBox);
            this.tabPage3.Controls.Add(this.ChangedFirstNameTextBox);
            this.tabPage3.Controls.Add(this.ChangeUserComboBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1251, 453);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Изменение данных";
            // 
            // ChangeButton
            // 
            this.ChangeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeButton.BackColor = System.Drawing.Color.LightBlue;
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Font = new System.Drawing.Font("Elephant", 13.8F);
            this.ChangeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ChangeButton.Location = new System.Drawing.Point(398, 368);
            this.ChangeButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(360, 72);
            this.ChangeButton.TabIndex = 24;
            this.ChangeButton.Text = "Изменить пользователя";
            this.ChangeButton.UseVisualStyleBackColor = false;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ChangedPhoneNumberTextBox
            // 
            this.ChangedPhoneNumberTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.ChangedPhoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangedPhoneNumberTextBox.Location = new System.Drawing.Point(826, 192);
            this.ChangedPhoneNumberTextBox.Mask = "8(999) 000-0000";
            this.ChangedPhoneNumberTextBox.Name = "ChangedPhoneNumberTextBox";
            this.ChangedPhoneNumberTextBox.Size = new System.Drawing.Size(360, 19);
            this.ChangedPhoneNumberTextBox.TabIndex = 23;
            // 
            // ChangedEmailTextBox
            // 
            this.ChangedEmailTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.ChangedEmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangedEmailTextBox.Cue = "Изменить email";
            this.ChangedEmailTextBox.Location = new System.Drawing.Point(826, 117);
            this.ChangedEmailTextBox.Name = "ChangedEmailTextBox";
            this.ChangedEmailTextBox.Size = new System.Drawing.Size(360, 19);
            this.ChangedEmailTextBox.TabIndex = 21;
            // 
            // ChangedSecondNameTextBox
            // 
            this.ChangedSecondNameTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.ChangedSecondNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangedSecondNameTextBox.Cue = "Изменить фамилию";
            this.ChangedSecondNameTextBox.Location = new System.Drawing.Point(30, 192);
            this.ChangedSecondNameTextBox.Name = "ChangedSecondNameTextBox";
            this.ChangedSecondNameTextBox.Size = new System.Drawing.Size(360, 19);
            this.ChangedSecondNameTextBox.TabIndex = 20;
            // 
            // ChangedFirstNameTextBox
            // 
            this.ChangedFirstNameTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.ChangedFirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChangedFirstNameTextBox.Cue = "Изменить имя";
            this.ChangedFirstNameTextBox.Location = new System.Drawing.Point(30, 117);
            this.ChangedFirstNameTextBox.Name = "ChangedFirstNameTextBox";
            this.ChangedFirstNameTextBox.Size = new System.Drawing.Size(360, 19);
            this.ChangedFirstNameTextBox.TabIndex = 19;
            // 
            // ChangeUserComboBox
            // 
            this.ChangeUserComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChangeUserComboBox.BackColor = System.Drawing.Color.LightBlue;
            this.ChangeUserComboBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeUserComboBox.FormattingEnabled = true;
            this.ChangeUserComboBox.Location = new System.Drawing.Point(141, 36);
            this.ChangeUserComboBox.Name = "ChangeUserComboBox";
            this.ChangeUserComboBox.Size = new System.Drawing.Size(999, 24);
            this.ChangeUserComboBox.TabIndex = 2;
            this.ChangeUserComboBox.Text = "Выберите пользователя";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Teal;
            this.tabPage2.Controls.Add(this.RemoveButton);
            this.tabPage2.Controls.Add(this.RemoveUserComboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1251, 453);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Удаление";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveButton.BackColor = System.Drawing.Color.LightBlue;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Font = new System.Drawing.Font("Elephant", 13.8F);
            this.RemoveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RemoveButton.Location = new System.Drawing.Point(421, 368);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(360, 72);
            this.RemoveButton.TabIndex = 25;
            this.RemoveButton.Text = "Удалить пользователя";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RemoveUserComboBox
            // 
            this.RemoveUserComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RemoveUserComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.RemoveUserComboBox.FormattingEnabled = true;
            this.RemoveUserComboBox.Location = new System.Drawing.Point(137, 181);
            this.RemoveUserComboBox.Name = "RemoveUserComboBox";
            this.RemoveUserComboBox.Size = new System.Drawing.Size(999, 21);
            this.RemoveUserComboBox.TabIndex = 4;
            this.RemoveUserComboBox.Text = "Выберите пользовотеля";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.LightBlue;
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Login.Cue = "Введите логин";
            this.Login.Location = new System.Drawing.Point(445, 284);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(360, 19);
            this.Login.TabIndex = 22;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 540);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Elephant", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UsersForm";
            this.Text = "Добавление пользователя";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private CueTextBox PasswordTextBox;
        private CueTextBox EmailTextBox;
        private CueTextBox SecondNameTextBox;
        private CueTextBox FirstNameTextBox;
        private CueTextBox LoginTextBox;
        private MaskedTextBox PhoneNumbeTextBox;
        private Button AddButton;
        private ComboBox RoleComboBox;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox ChangeUserComboBox;
        private CueTextBox ChangedEmailTextBox;
        private CueTextBox ChangedSecondNameTextBox;
        private CueTextBox ChangedFirstNameTextBox;
        private MaskedTextBox ChangedPhoneNumberTextBox;
        private Button ChangeButton;
        private ComboBox RemoveUserComboBox;
        private Button RemoveButton;
        private CueTextBox Login;
    }
}
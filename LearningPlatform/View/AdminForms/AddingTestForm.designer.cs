using System.Windows.Forms;
namespace LearningPlatform.View
{
    partial class AddingUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingUserForm));
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.PhoneNumbeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.LoginTextBox = new CueTextBox();
            this.FirstNameTextBox = new CueTextBox();
            this.SecondNameTextBox = new CueTextBox();
            this.EmailTextBox = new CueTextBox();
            this.PasswordTextBox = new CueTextBox();
            this.SuspendLayout();
            // 
            // RoleComboBox
            // 
            resources.ApplyResources(this.RoleComboBox, "RoleComboBox");
            this.RoleComboBox.BackColor = System.Drawing.Color.LightBlue;
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Items.AddRange(new object[] {
            resources.GetString("RoleComboBox.Items"),
            resources.GetString("RoleComboBox.Items1"),
            resources.GetString("RoleComboBox.Items2")});
            this.RoleComboBox.Name = "RoleComboBox";
            // 
            // AddButton
            // 
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddButton.Name = "AddButton";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // PhoneNumbeTextBox
            // 
            resources.ApplyResources(this.PhoneNumbeTextBox, "PhoneNumbeTextBox");
            this.PhoneNumbeTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.PhoneNumbeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneNumbeTextBox.Name = "PhoneNumbeTextBox";
            // 
            // LoginTextBox
            // 
            resources.ApplyResources(this.LoginTextBox, "LoginTextBox");
            this.LoginTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.LoginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginTextBox.Name = "LoginTextBox";
            // 
            // FirstNameTextBox
            // 
            resources.ApplyResources(this.FirstNameTextBox, "FirstNameTextBox");
            this.FirstNameTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            // 
            // SecondNameTextBox
            // 
            resources.ApplyResources(this.SecondNameTextBox, "SecondNameTextBox");
            this.SecondNameTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.SecondNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondNameTextBox.Name = "SecondNameTextBox";
            // 
            // EmailTextBox
            // 
            resources.ApplyResources(this.EmailTextBox, "EmailTextBox");
            this.EmailTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailTextBox.Name = "EmailTextBox";
            // 
            // PasswordTextBox
            // 
            resources.ApplyResources(this.PasswordTextBox, "PasswordTextBox");
            this.PasswordTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordTextBox.Name = "PasswordTextBox";
            // 
            // AddingUserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.SecondNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.PhoneNumbeTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.RoleComboBox);
            this.Name = "AddingUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button AddButton;
        private ComboBox RoleComboBox;
        private MaskedTextBox PhoneNumbeTextBox;
        private CueTextBox LoginTextBox;
        private CueTextBox FirstNameTextBox;
        private CueTextBox SecondNameTextBox;
        private CueTextBox EmailTextBox;
        private CueTextBox PasswordTextBox;
    }
}
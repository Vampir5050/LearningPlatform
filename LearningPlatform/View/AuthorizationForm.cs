using LearningPlatform.Model;
using System.Drawing.Drawing2D;
using System.Windows.Forms.Design;
//using Pbkdf2;
//using LearningPlatform.Controller;
using System.Windows.Forms;

namespace LearningPlatform
{
    public partial class AuthorizationForm : Form
    {


        public AuthorizationForm()
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
            //PasswordCheckBox.CheckedChanged += PasswordShow;
        }
        //    private void PasswordShow(object sender, EventArgs e)
        //    {
        //        if (PasswordCheckBox.Checked == false)
        //        {
        //            PasswordCheckBox.BackgroundImage = Properties.Resources.ClosedEyeIcon;
        //            PasswordTextBox.UseSystemPasswordChar = true;
        //        }
        //        else
        //        {
        //            PasswordCheckBox.BackgroundImage = Properties.Resources.OpenEyeIcon;
        //            PasswordTextBox.UseSystemPasswordChar = false;
        //        }
        //    }

        //    private async void InputButton_Click_1(object sender, EventArgs e)
        //    {
        //        if (string.IsNullOrWhiteSpace(LoginTextBox.Text))
        //        {
        //            PasswordTextBox.BackColor = Color.White;
        //            LoginTextBox.BackColor = Color.Red;
        //            return;
        //        }
        //        if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
        //        {
        //            LoginTextBox.BackColor = Color.White;
        //            PasswordTextBox.BackColor = Color.Red;
        //            return;
        //        }
        //        User user = await Authorization.instance.GetUser(LoginTextBox.Text, PasswordTextBox.Text);
        //        if (user != null)
        //        {

        //            this.Visible = false;
        //            if (new MainMenuForm(user).ShowDialog() == DialogResult.Cancel) Close();
        //        }
        //        else
        //        {
        //            MessageBox.Show("¬веден не верный логин или пароль!");
        //            LoginTextBox.BackColor = Color.Red;
        //            PasswordTextBox.BackColor = Color.Red;

        //        }

        //    }
        //}
    }
}
using LearningPlatform.Model;
using LearningPlatform.View.AdminForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningPlatform.View
{
    public partial class MainMenuForm : Form
    {
        public User user;

        public MainMenuForm(User user)
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
            if(user.Role == RoleType.Admin)
            {
                AdminButton.Visible = true;
            }
            else
            {
                AdminButton.Visible = false;
            }
            this.user = user;
            LabelName.Text += $"{user.PersonalData.FirstName} {user.PersonalData.SecondName}";


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => { new UserForm(this.user).ShowDialog(); });
        }

        private void TestsButton_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            if (new TestsForm().ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void VideoButton_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            if (new VideoSelectionForm().ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void ArticlesButton_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            if (new ArticlesForm().ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (new AdminMenuForm().ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }
    }
}

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

namespace LearningPlatform.View.AdminForms
{
    public partial class AddingEducationVideoForm : Form
    {
        public AddingEducationVideoForm()
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
            if (string.IsNullOrWhiteSpace(SubjectTextBox.Text)) return;
            if (string.IsNullOrWhiteSpace(NameTextBox.Text)) return;
            if (string.IsNullOrWhiteSpace(LinkTextBox.Text)) return;
            var educationVideo = new EducationalVideo()
            {
                Subject = SubjectTextBox.Text,
                Name = NameTextBox.Text,
                Link = LinkTextBox.Text
            };
            var check = await AdminManager.instance.AddEducationalVideo(educationVideo);
            if (check)
            {
                MessageBox.Show("Видео успешно добавлен");
            }
            else
            {
                MessageBox.Show("С таким названием видео уже существует!");
            }
            SubjectTextBox.Text = "";
            NameTextBox.Text = "";
            LinkTextBox.Text = "";

        }
    }
}

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
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
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

        private void AddingUserButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (new AddingUserForm().ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private void AddingEducationVideoButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (new AddingEducationVideoForm().ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }
    }
}

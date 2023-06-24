using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LearningPlatform.Model;
using LearningPlatform.Controller;

namespace LearningPlatform.View
{
    public partial class TestsForm : Form
    {

        private Label LabelName;
        private Label label1;
        private ListBox TestListBox;
        private PictureBox pictureBox2;

        List<Test> tests;

        public TestsForm()
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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestsForm));
            this.LabelName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TestListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelName
            // 
            resources.ApplyResources(this.LabelName, "LabelName");
            this.LabelName.Name = "LabelName";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Name = "label1";
            // 
            // TestListBox
            // 
            resources.ApplyResources(this.TestListBox, "TestListBox");
            this.TestListBox.BackColor = System.Drawing.Color.LightBlue;
            this.TestListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TestListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TestListBox.FormattingEnabled = true;
            this.TestListBox.Name = "TestListBox";
            this.TestListBox.DoubleClick += new System.EventHandler(this.TestListBox_DoubleClick);
            // 
            // TestsForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TestListBox);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.pictureBox2);
            this.Name = "TestsForm";
            this.Load += new System.EventHandler(this.TestsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void TestListBox_DoubleClick(object sender, EventArgs e)
        {
            Test tempTest = TestListBox.SelectedItem as Test;
            this.Visible = false;
            if (new TakeATestForm(tempTest).ShowDialog() == DialogResult.Cancel)
            {
                this.Visible = true;
            }
        }

        private async void TestsForm_Load(object sender, EventArgs e)
        {
            tests = await DatabaseManagement.instance.GetTestsAsync();
            foreach (var test in tests)
            {
                TestListBox.Items.Add(test);
            }
        }
    }
}

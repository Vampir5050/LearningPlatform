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
    public partial class VideoSelectionForm : Form
    {
        List<EducationalVideo> educationalVideos;
        public VideoSelectionForm()
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

        private async void VideoForm_Load(object sender, EventArgs e)
        {
         
            educationalVideos = await DatabaseManagement.instance.GetEducationalVideos();
            foreach (var item in educationalVideos)
            {
                VideolistBox.Items.Add(item).ToString();
            }
        }

        private void VideolistBox_DoubleClick(object sender, EventArgs e)
        {
            string link="";
            foreach (EducationalVideo item in educationalVideos)
            {
                if(VideolistBox.SelectedItem.ToString() == item.ToString())
                {
                    link = item.Link;
                    break;
                }
            }
            this.Visible = false;
            if(link!="")
            {
                if (new VideoPlayForm(link).ShowDialog() == DialogResult.Cancel)
                {
                    this.Visible = true;
                }
            }
            
        }
    }

}

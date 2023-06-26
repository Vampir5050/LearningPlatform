using LearningPlatform.Controller;
using LearningPlatform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningPlatform.View
{
    public partial class ArticlesForm : Form
    {
        List<Article> articles;
        public ArticlesForm()
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

        private void ArticleslistBox_DoubleClick(object sender, EventArgs e)
        {
            string link = "";
            foreach (Article item in articles)
            {
                if (ArticleslistBox.SelectedItem.ToString() == item.ToString())
                {
                    link = item.Link;
                    break;
                }
            }
            ProcessStartInfo sInfo = new ProcessStartInfo(link);
            Process.Start(sInfo);

        }
        private async void ArticlesForm_Load(object sender, EventArgs e)
        {
            articles = await DatabaseManagement.instance.GetArticles();
            foreach (var item in articles)
            {
                ArticleslistBox.Items.Add(item).ToString();
            }

        }
    }
}

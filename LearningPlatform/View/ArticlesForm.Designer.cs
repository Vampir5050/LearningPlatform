using System.Windows.Forms;
namespace LearningPlatform.View
{
    partial class ArticlesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticlesForm));
            this.LabelName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ArticleslistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
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
            // ArticleslistBox
            // 
            resources.ApplyResources(this.ArticleslistBox, "ArticleslistBox");
            this.ArticleslistBox.BackColor = System.Drawing.Color.LightBlue;
            this.ArticleslistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ArticleslistBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ArticleslistBox.FormattingEnabled = true;
            this.ArticleslistBox.Name = "ArticleslistBox";
            this.ArticleslistBox.DoubleClick += new System.EventHandler(this.ArticleslistBox_DoubleClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Name = "label1";
            // 
            // ArticlesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArticleslistBox);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ArticlesForm";
            this.Load += new System.EventHandler(this.ArticlesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelName;
        private PictureBox pictureBox2;
        private ListBox ArticleslistBox;
        private Label label1;
    }
}
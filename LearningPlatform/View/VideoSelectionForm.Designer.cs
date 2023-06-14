namespace LearningPlatform.View
{
    partial class VideoSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoSelectionForm));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.VideolistBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // VideolistBox
            // 
            resources.ApplyResources(this.VideolistBox, "VideolistBox");
            this.VideolistBox.BackColor = System.Drawing.Color.LightBlue;
            this.VideolistBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VideolistBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.VideolistBox.FormattingEnabled = true;
            this.VideolistBox.Name = "VideolistBox";
            this.VideolistBox.DoubleClick += new System.EventHandler(this.VideolistBox_DoubleClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Name = "label1";
            // 
            // VideoSelectionForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VideolistBox);
            this.Controls.Add(this.pictureBox2);
            this.Name = "VideoSelectionForm";
            this.Load += new System.EventHandler(this.VideoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox VideolistBox;
        private System.Windows.Forms.Label label1;
    }
}
using System.Windows.Forms;
namespace LearningPlatform.View
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.ArticlesButton = new System.Windows.Forms.Button();
            this.VideoButton = new System.Windows.Forms.Button();
            this.TestsButton = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AdminButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ArticlesButton
            // 
            resources.ApplyResources(this.ArticlesButton, "ArticlesButton");
            this.ArticlesButton.BackColor = System.Drawing.Color.LightBlue;
            this.ArticlesButton.Name = "ArticlesButton";
            this.ArticlesButton.UseVisualStyleBackColor = false;
            this.ArticlesButton.Click += new System.EventHandler(this.ArticlesButton_Click_1);
            // 
            // VideoButton
            // 
            resources.ApplyResources(this.VideoButton, "VideoButton");
            this.VideoButton.BackColor = System.Drawing.Color.LightBlue;
            this.VideoButton.Name = "VideoButton";
            this.VideoButton.UseVisualStyleBackColor = false;
            this.VideoButton.Click += new System.EventHandler(this.VideoButton_Click_1);
            // 
            // TestsButton
            // 
            resources.ApplyResources(this.TestsButton, "TestsButton");
            this.TestsButton.BackColor = System.Drawing.Color.LightBlue;
            this.TestsButton.Name = "TestsButton";
            this.TestsButton.UseVisualStyleBackColor = false;
            this.TestsButton.Click += new System.EventHandler(this.TestsButton_Click_1);
            // 
            // LabelName
            // 
            resources.ApplyResources(this.LabelName, "LabelName");
            this.LabelName.BackColor = System.Drawing.Color.LightBlue;
            this.LabelName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LabelName.Name = "LabelName";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // AdminButton
            // 
            resources.ApplyResources(this.AdminButton, "AdminButton");
            this.AdminButton.BackColor = System.Drawing.Color.LightBlue;
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.UseVisualStyleBackColor = false;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // MainMenuForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.ArticlesButton);
            this.Controls.Add(this.VideoButton);
            this.Controls.Add(this.TestsButton);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.pictureBox2);
            this.Name = "MainMenuForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ArticlesButton;
        private Button VideoButton;
        private Button TestsButton;
        private Label LabelName;
        private PictureBox pictureBox2;
        private Button AdminButton;
    }
}
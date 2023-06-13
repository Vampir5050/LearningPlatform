using System.Windows.Forms;
namespace LearningPlatform.View
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.label6 = new System.Windows.Forms.Label();
            this.LabelMark = new System.Windows.Forms.Label();
            this.LabelMail = new System.Windows.Forms.Label();
            this.LabelPhone = new System.Windows.Forms.Label();
            this.LabelSecondName = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Name = "label6";
            // 
            // LabelMark
            // 
            resources.ApplyResources(this.LabelMark, "LabelMark");
            this.LabelMark.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelMark.Name = "LabelMark";
            // 
            // LabelMail
            // 
            resources.ApplyResources(this.LabelMail, "LabelMail");
            this.LabelMail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelMail.Name = "LabelMail";
            // 
            // LabelPhone
            // 
            resources.ApplyResources(this.LabelPhone, "LabelPhone");
            this.LabelPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelPhone.Name = "LabelPhone";
            // 
            // LabelSecondName
            // 
            resources.ApplyResources(this.LabelSecondName, "LabelSecondName");
            this.LabelSecondName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelSecondName.Name = "LabelSecondName";
            // 
            // LabelName
            // 
            resources.ApplyResources(this.LabelName, "LabelName");
            this.LabelName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelName.Name = "LabelName";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // UserForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LabelMark);
            this.Controls.Add(this.LabelMail);
            this.Controls.Add(this.LabelPhone);
            this.Controls.Add(this.LabelSecondName);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.pictureBox2);
            this.Name = "UserForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Label LabelMark;
        private Label LabelMail;
        private Label LabelPhone;
        private Label LabelSecondName;
        private Label LabelName;
        private PictureBox pictureBox2;
    }
}
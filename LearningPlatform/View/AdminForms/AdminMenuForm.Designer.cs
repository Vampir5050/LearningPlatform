namespace LearningPlatform.View.AdminForms
{
    partial class AdminMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenuForm));
            this.AddingUserButton = new System.Windows.Forms.Button();
            this.AddingEducationVideoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddingUserButton
            // 
            resources.ApplyResources(this.AddingUserButton, "AddingUserButton");
            this.AddingUserButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddingUserButton.Name = "AddingUserButton";
            this.AddingUserButton.UseVisualStyleBackColor = false;
            this.AddingUserButton.Click += new System.EventHandler(this.AddingUserButton_Click);
            // 
            // AddingEducationVideoButton
            // 
            resources.ApplyResources(this.AddingEducationVideoButton, "AddingEducationVideoButton");
            this.AddingEducationVideoButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddingEducationVideoButton.Name = "AddingEducationVideoButton";
            this.AddingEducationVideoButton.UseVisualStyleBackColor = false;
            this.AddingEducationVideoButton.Click += new System.EventHandler(this.AddingEducationVideoButton_Click);
            // 
            // AdminMenuForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddingEducationVideoButton);
            this.Controls.Add(this.AddingUserButton);
            this.Name = "AdminMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddingUserButton;
        private System.Windows.Forms.Button AddingEducationVideoButton;
    }
}
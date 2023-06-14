namespace LearningPlatform.View.AdminForms
{
    partial class AddingEducationVideoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddingEducationVideoForm));
            this.LinkTextBox = new CueTextBox();
            this.NameTextBox = new CueTextBox();
            this.SubjectTextBox = new CueTextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.cueTextBox1 = new CueTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LinkTextBox
            // 
            this.LinkTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.LinkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LinkTextBox.Cue = "Вставте ссылку на видео";
            this.LinkTextBox.Location = new System.Drawing.Point(418, 371);
            this.LinkTextBox.Name = "LinkTextBox";
            this.LinkTextBox.Size = new System.Drawing.Size(360, 24);
            this.LinkTextBox.TabIndex = 14;
            // 
            // NameTextBox
            // 
            this.NameTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.NameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTextBox.Cue = "Введите название";
            this.NameTextBox.Location = new System.Drawing.Point(418, 282);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(360, 24);
            this.NameTextBox.TabIndex = 13;
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.SubjectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SubjectTextBox.Cue = "Введите предмет";
            this.SubjectTextBox.Location = new System.Drawing.Point(418, 205);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(360, 24);
            this.SubjectTextBox.TabIndex = 12;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddButton.BackColor = System.Drawing.Color.LightBlue;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Elephant", 13.8F);
            this.AddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.AddButton.Location = new System.Drawing.Point(418, 462);
            this.AddButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(360, 72);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Добавить видео";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cueTextBox1
            // 
            this.cueTextBox1.BackColor = System.Drawing.Color.LightBlue;
            this.cueTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cueTextBox1.Cue = "";
            this.cueTextBox1.Enabled = false;
            this.cueTextBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cueTextBox1.Location = new System.Drawing.Point(206, 36);
            this.cueTextBox1.Multiline = true;
            this.cueTextBox1.Name = "cueTextBox1";
            this.cueTextBox1.Size = new System.Drawing.Size(892, 79);
            this.cueTextBox1.TabIndex = 22;
            this.cueTextBox1.Text = resources.GetString("cueTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(529, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Инструкция!";
            // 
            // AddingEducationVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 675);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cueTextBox1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.LinkTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.SubjectTextBox);
            this.Font = new System.Drawing.Font("Elephant", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddingEducationVideoForm";
            this.Text = "Добавление учебных видео";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CueTextBox LinkTextBox;
        private CueTextBox NameTextBox;
        private CueTextBox SubjectTextBox;
        private System.Windows.Forms.Button AddButton;
        private CueTextBox cueTextBox1;
        private System.Windows.Forms.Label label1;
    }
}
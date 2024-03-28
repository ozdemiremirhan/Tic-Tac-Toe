
namespace OOP2_Lab4
{
    partial class Form_difficultyLevel
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
            this.button_Easy = new System.Windows.Forms.Button();
            this.button_Middle = new System.Windows.Forms.Button();
            this.button_Hard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Easy
            // 
            this.button_Easy.Location = new System.Drawing.Point(79, 144);
            this.button_Easy.Name = "button_Easy";
            this.button_Easy.Size = new System.Drawing.Size(127, 58);
            this.button_Easy.TabIndex = 0;
            this.button_Easy.Text = "Easy";
            this.button_Easy.UseVisualStyleBackColor = true;
            this.button_Easy.Click += new System.EventHandler(this.button_Easy_Click);
            // 
            // button_Middle
            // 
            this.button_Middle.Location = new System.Drawing.Point(233, 144);
            this.button_Middle.Name = "button_Middle";
            this.button_Middle.Size = new System.Drawing.Size(127, 58);
            this.button_Middle.TabIndex = 1;
            this.button_Middle.Text = "Mediım";
            this.button_Middle.UseVisualStyleBackColor = true;
            this.button_Middle.Click += new System.EventHandler(this.button_Middle_Click);
            // 
            // button_Hard
            // 
            this.button_Hard.Location = new System.Drawing.Point(395, 144);
            this.button_Hard.Name = "button_Hard";
            this.button_Hard.Size = new System.Drawing.Size(127, 58);
            this.button_Hard.TabIndex = 2;
            this.button_Hard.Text = "Hard";
            this.button_Hard.UseVisualStyleBackColor = true;
            this.button_Hard.Click += new System.EventHandler(this.button_Hard_Click);
            // 
            // Form_difficultyLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 347);
            this.Controls.Add(this.button_Hard);
            this.Controls.Add(this.button_Middle);
            this.Controls.Add(this.button_Easy);
            this.Name = "Form_difficultyLevel";
            this.Text = "Form_difficultyLevel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Easy;
        private System.Windows.Forms.Button button_Middle;
        private System.Windows.Forms.Button button_Hard;
    }
}
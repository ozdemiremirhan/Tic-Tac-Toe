
namespace OOP2_Lab4
{
    partial class Form_settingScreen
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
            this.button_DifficultyLevel = new System.Windows.Forms.Button();
            this.button_AdminPanel = new System.Windows.Forms.Button();
            this.button_NewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_DifficultyLevel
            // 
            this.button_DifficultyLevel.Location = new System.Drawing.Point(34, 79);
            this.button_DifficultyLevel.Name = "button_DifficultyLevel";
            this.button_DifficultyLevel.Size = new System.Drawing.Size(111, 49);
            this.button_DifficultyLevel.TabIndex = 0;
            this.button_DifficultyLevel.Text = "Difficulty Level";
            this.button_DifficultyLevel.UseVisualStyleBackColor = true;
            this.button_DifficultyLevel.Click += new System.EventHandler(this.button_DifficultyLevel_Click);
            // 
            // button_AdminPanel
            // 
            this.button_AdminPanel.Location = new System.Drawing.Point(187, 79);
            this.button_AdminPanel.Name = "button_AdminPanel";
            this.button_AdminPanel.Size = new System.Drawing.Size(111, 49);
            this.button_AdminPanel.TabIndex = 1;
            this.button_AdminPanel.Text = "AdminPanel";
            this.button_AdminPanel.UseVisualStyleBackColor = true;
            this.button_AdminPanel.Visible = false;
            this.button_AdminPanel.Click += new System.EventHandler(this.button_AdminPanel_Click);
            // 
            // button_NewGame
            // 
            this.button_NewGame.Location = new System.Drawing.Point(340, 79);
            this.button_NewGame.Name = "button_NewGame";
            this.button_NewGame.Size = new System.Drawing.Size(111, 49);
            this.button_NewGame.TabIndex = 2;
            this.button_NewGame.Text = "New Game";
            this.button_NewGame.UseVisualStyleBackColor = true;
            this.button_NewGame.Click += new System.EventHandler(this.button_NewGame_Click);
            // 
            // Form_settingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 201);
            this.Controls.Add(this.button_NewGame);
            this.Controls.Add(this.button_AdminPanel);
            this.Controls.Add(this.button_DifficultyLevel);
            this.Name = "Form_settingScreen";
            this.Text = "SettingScreen";
            this.Load += new System.EventHandler(this.Form_settingScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_DifficultyLevel;
        private System.Windows.Forms.Button button_AdminPanel;
        private System.Windows.Forms.Button button_NewGame;
    }
}
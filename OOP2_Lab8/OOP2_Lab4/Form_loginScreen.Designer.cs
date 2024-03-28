
namespace OOP2_Lab4
{
    partial class Form_loginScreen
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
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.radioButton_ShowPassword = new System.Windows.Forms.RadioButton();
            this.checkBox_RememberMe = new System.Windows.Forms.CheckBox();
            this.button_SQL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(54, 38);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(221, 20);
            this.textBox_Username.TabIndex = 0;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(54, 103);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(221, 20);
            this.textBox_Password.TabIndex = 1;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(51, 22);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(55, 13);
            this.label_UserName.TabIndex = 2;
            this.label_UserName.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(53, 87);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 3;
            this.label_Password.Text = "Password";
            // 
            // button_LogIn
            // 
            this.button_LogIn.Location = new System.Drawing.Point(180, 185);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(97, 35);
            this.button_LogIn.TabIndex = 4;
            this.button_LogIn.Text = "Log In";
            this.button_LogIn.UseVisualStyleBackColor = true;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(54, 185);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(89, 35);
            this.button_register.TabIndex = 5;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // radioButton_ShowPassword
            // 
            this.radioButton_ShowPassword.AutoSize = true;
            this.radioButton_ShowPassword.Location = new System.Drawing.Point(54, 142);
            this.radioButton_ShowPassword.Name = "radioButton_ShowPassword";
            this.radioButton_ShowPassword.Size = new System.Drawing.Size(101, 17);
            this.radioButton_ShowPassword.TabIndex = 6;
            this.radioButton_ShowPassword.TabStop = true;
            this.radioButton_ShowPassword.Text = "Show Password";
            this.radioButton_ShowPassword.UseVisualStyleBackColor = true;
            this.radioButton_ShowPassword.CheckedChanged += new System.EventHandler(this.radioButton_ShowPassword_CheckedChanged);
            // 
            // checkBox_RememberMe
            // 
            this.checkBox_RememberMe.AutoSize = true;
            this.checkBox_RememberMe.Location = new System.Drawing.Point(180, 142);
            this.checkBox_RememberMe.Name = "checkBox_RememberMe";
            this.checkBox_RememberMe.Size = new System.Drawing.Size(95, 17);
            this.checkBox_RememberMe.TabIndex = 7;
            this.checkBox_RememberMe.Text = "Remember Me";
            this.checkBox_RememberMe.UseVisualStyleBackColor = true;
            this.checkBox_RememberMe.CheckedChanged += new System.EventHandler(this.checkBox_RememberMe_CheckedChanged);
            // 
            // button_SQL
            // 
            this.button_SQL.Location = new System.Drawing.Point(117, 226);
            this.button_SQL.Name = "button_SQL";
            this.button_SQL.Size = new System.Drawing.Size(88, 38);
            this.button_SQL.TabIndex = 8;
            this.button_SQL.Text = "SQL Screen";
            this.button_SQL.UseVisualStyleBackColor = true;
            this.button_SQL.Click += new System.EventHandler(this.button_SQL_Click);
            // 
            // Form_loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 276);
            this.Controls.Add(this.button_SQL);
            this.Controls.Add(this.checkBox_RememberMe);
            this.Controls.Add(this.radioButton_ShowPassword);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Name = "Form_loginScreen";
            this.Text = "Login Screen";
            this.Load += new System.EventHandler(this.Form_loginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Button button_LogIn;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.RadioButton radioButton_ShowPassword;
        private System.Windows.Forms.CheckBox checkBox_RememberMe;
        private System.Windows.Forms.Button button_SQL;
    }
}
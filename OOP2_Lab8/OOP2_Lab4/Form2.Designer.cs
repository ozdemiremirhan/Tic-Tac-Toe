
namespace OOP2_Lab4
{
    partial class Form2
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
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_UserType = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_NameSurname = new System.Windows.Forms.TextBox();
            this.textBox_Mail = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_UserType = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_NameSurname = new System.Windows.Forms.Label();
            this.label_Mail = new System.Windows.Forms.Label();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.label_FeedBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(158, 40);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID.TabIndex = 0;
            // 
            // textBox_UserType
            // 
            this.textBox_UserType.Location = new System.Drawing.Point(158, 79);
            this.textBox_UserType.Name = "textBox_UserType";
            this.textBox_UserType.Size = new System.Drawing.Size(100, 20);
            this.textBox_UserType.TabIndex = 1;
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(158, 117);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(100, 20);
            this.textBox_Username.TabIndex = 2;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(158, 154);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(100, 20);
            this.textBox_Password.TabIndex = 3;
            // 
            // textBox_NameSurname
            // 
            this.textBox_NameSurname.Location = new System.Drawing.Point(158, 190);
            this.textBox_NameSurname.Name = "textBox_NameSurname";
            this.textBox_NameSurname.Size = new System.Drawing.Size(100, 20);
            this.textBox_NameSurname.TabIndex = 4;
            // 
            // textBox_Mail
            // 
            this.textBox_Mail.Location = new System.Drawing.Point(158, 226);
            this.textBox_Mail.Name = "textBox_Mail";
            this.textBox_Mail.Size = new System.Drawing.Size(100, 20);
            this.textBox_Mail.TabIndex = 5;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(117, 43);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(18, 13);
            this.label_ID.TabIndex = 6;
            this.label_ID.Text = "ID";
            // 
            // label_UserType
            // 
            this.label_UserType.AutoSize = true;
            this.label_UserType.Location = new System.Drawing.Point(99, 82);
            this.label_UserType.Name = "label_UserType";
            this.label_UserType.Size = new System.Drawing.Size(53, 13);
            this.label_UserType.TabIndex = 7;
            this.label_UserType.Text = "UserType";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(97, 120);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(55, 13);
            this.label_Username.TabIndex = 8;
            this.label_Username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(99, 157);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 9;
            this.label_Password.Text = "Password";
            // 
            // label_NameSurname
            // 
            this.label_NameSurname.AutoSize = true;
            this.label_NameSurname.Location = new System.Drawing.Point(75, 193);
            this.label_NameSurname.Name = "label_NameSurname";
            this.label_NameSurname.Size = new System.Drawing.Size(77, 13);
            this.label_NameSurname.TabIndex = 10;
            this.label_NameSurname.Text = "NameSurname";
            // 
            // label_Mail
            // 
            this.label_Mail.AutoSize = true;
            this.label_Mail.Location = new System.Drawing.Point(126, 229);
            this.label_Mail.Name = "label_Mail";
            this.label_Mail.Size = new System.Drawing.Size(26, 13);
            this.label_Mail.TabIndex = 11;
            this.label_Mail.Text = "Mail";
            // 
            // button_Back
            // 
            this.button_Back.Location = new System.Drawing.Point(78, 345);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(93, 41);
            this.button_Back.TabIndex = 12;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(226, 345);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(93, 41);
            this.button_Save.TabIndex = 13;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label_FeedBack
            // 
            this.label_FeedBack.AutoSize = true;
            this.label_FeedBack.Location = new System.Drawing.Point(129, 281);
            this.label_FeedBack.Name = "label_FeedBack";
            this.label_FeedBack.Size = new System.Drawing.Size(0, 13);
            this.label_FeedBack.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 450);
            this.Controls.Add(this.label_FeedBack);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label_Mail);
            this.Controls.Add(this.label_NameSurname);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.label_UserType);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBox_Mail);
            this.Controls.Add(this.textBox_NameSurname);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.textBox_UserType);
            this.Controls.Add(this.textBox_ID);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_UserType;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_NameSurname;
        private System.Windows.Forms.TextBox textBox_Mail;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_UserType;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_NameSurname;
        private System.Windows.Forms.Label label_Mail;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label_FeedBack;
    }
}
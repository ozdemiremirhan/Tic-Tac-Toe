using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_Lab4
{
    public partial class Form_loginScreen : Form
    {
        public Form_loginScreen()
        {
            InitializeComponent();
        }

        private void button_LogIn_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "admin" && textBox_Password.Text == "admin")
            {
                this.Hide();
                Form_settingScreen settingScreen = new Form_settingScreen();
                settingScreen.UserType = textBox_Username.Text;
                settingScreen.ShowDialog();
                this.Close();

            }
           else
            {
                this.Hide();
                Form_settingScreen settingScreen = new Form_settingScreen();
                settingScreen.UserType = textBox_Username.Text;
                settingScreen.ShowDialog();
                this.Close();

            }
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.previousForm = "loginscreen";
            form2.ShowDialog();
            this.Close();
        }
        
        private void radioButton_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_ShowPassword.Checked == true)
            {
                textBox_Password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_Password.UseSystemPasswordChar = true;
            }
        }

        private void Form_loginScreen_Load(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = true;
            if (Properties.Settings.Default.Username != string.Empty)
            {
                textBox_Username.Text = Properties.Settings.Default.Username;
                textBox_Password.Text = Properties.Settings.Default.Password;
            }
        }

        private void checkBox_RememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_RememberMe.Checked == true)
            {
                String username = textBox_Username.Text;
                String password = textBox_Password.Text;
                Properties.Settings.Default.Username = username;
                Properties.Settings.Default.Password = password;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }

        private void button_SQL_Click(object sender, EventArgs e)
        {
            Form_SQL form_SQL = new Form_SQL();
            this.Hide();
            form_SQL.ShowDialog();
            this.Close();
        }
    }
}

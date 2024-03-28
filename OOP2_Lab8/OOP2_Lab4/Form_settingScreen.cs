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
    public partial class Form_settingScreen : Form
    {
        public string UserType { get; set; }
        public Form_settingScreen()
        {
            InitializeComponent();
        }

        private void button_NewGame_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void Form_settingScreen_Load(object sender, EventArgs e)
        {
            if (UserType == "admin")
            {
                button_AdminPanel.Visible = true;
            }
            else
                button_AdminPanel.Visible = false;
        }

        private void button_AdminPanel_Click(object sender, EventArgs e)
        {
            Form_adminPanel adminPanel = new Form_adminPanel();
            this.Hide();
            adminPanel.ShowDialog();
            this.Close();
        }

        private void button_DifficultyLevel_Click(object sender, EventArgs e)
        {
            Form_difficultyLevel difficultyLevel = new Form_difficultyLevel();
            this.Hide();
            difficultyLevel.ShowDialog();
            this.Close();
        }
    }
}

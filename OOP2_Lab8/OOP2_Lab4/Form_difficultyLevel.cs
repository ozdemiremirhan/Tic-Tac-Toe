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
    public partial class Form_difficultyLevel : Form
    {
        public Form_difficultyLevel()
        {
            InitializeComponent();
        }

        private void button_Easy_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void button_Hard_Click(object sender, EventArgs e)
        {
            Form_difficultGame difficultGame = new Form_difficultGame();
            this.Hide();
            difficultGame.ShowDialog();
            this.Close();
        }

        private void button_Middle_Click(object sender, EventArgs e)
        {
            Form_mediumGame mediumGame = new Form_mediumGame();
            this.Hide();
            mediumGame.ShowDialog();
            this.Close();
        }
    }
}

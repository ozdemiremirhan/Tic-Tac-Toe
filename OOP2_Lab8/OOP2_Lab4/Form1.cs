using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testScript;

namespace OOP2_Lab4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            resetGame();
            button_Back.Image = null;
            button_Back.Text = "Back";
        }
        private void resetGame()
        {
            loadbuttons();
            foreach (Button item in buttons)
            {
                item.Enabled = true;
                item.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\soruişareti.jpg");
                item.Tag = "";
            }
            
            
        }
        List<Button> buttons;
        //int[] board = new int[9];
        int[] boardIndex = new int[9] {0,0,0,0,0,0,0,0,0};
        
        private void loadbuttons()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }
        
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            
            b.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\X.jpg");
            //board[buttons.IndexOf(b)] = 1;
            Button[] board = buttons.ToArray();

            boardIndex[buttons.IndexOf(b)] = 1;
            for (int i = buttons.IndexOf(b) + 1; i < board.Length; i++)
            {
                board[i - 1] = board[i];
            }
            buttons.Remove(b);
            ComputerMove();
            b.Enabled = false;
            
            b.Tag = "x";
           
            
           
           
            check_winner();
        }
        private void check_winner()
        {

            String winner = "";

            if (buttons.Count >= 0)
            {
                if ((button1.Tag == "x") && (button2.Tag == "x") && (button3.Tag == "x")
                    || (button4.Tag == "x") && (button5.Tag == "x") && (button6.Tag == "x")
                    || (button7.Tag == "x") && (button8.Tag == "x") && (button9.Tag == "x"))
                {
                    winner = "x";
                    MessageBox.Show("X Wins!");
                    foreach (Button item in buttons)
                    {
                        item.Enabled = false;
                    }
                }
                else if ((button1.Tag == "x") && (button4.Tag == "x") && (button7.Tag == "x")
                     || (button2.Tag == "x") && (button5.Tag == "x") && (button8.Tag == "x")
                     || (button3.Tag == "x") && (button6.Tag == "x") && (button9.Tag == "x"))
                {
                    winner = "x";
                    MessageBox.Show("X Wins!");
                    foreach (Button item in buttons)
                    {
                        item.Enabled = false;
                    }
                }
                else if ((button1.Tag == "x") && (button5.Tag == "x") && (button9.Tag == "x")
                    || (button3.Tag == "x") && (button5.Tag == "x") && (button7.Tag == "x"))
                {
                    winner = "x";
                    MessageBox.Show("X Wins!");
                    foreach (Button item in buttons)
                    {
                        item.Enabled = false;
                    }
                }
                else if ((button1.Tag == "o") && (button2.Tag == "o") && (button3.Tag == "o")
                    || (button4.Tag == "o") && (button5.Tag == "o") && (button6.Tag == "o")
                    || (button7.Tag == "o") && (button8.Tag == "o") && (button9.Tag == "o"))
                {
                    winner = "o";
                    MessageBox.Show("O Wins!");
                    foreach (Button item in buttons)
                    {
                        item.Enabled = false;
                    }
                }
                else if ((button1.Tag == "o") && (button4.Tag == "o") && (button7.Tag == "o")
                     || (button2.Tag == "o") && (button5.Tag == "o") && (button8.Tag == "o")
                     || (button3.Tag == "o") && (button6.Tag == "o") && (button9.Tag == "o"))
                {
                    winner = "o";
                    MessageBox.Show("O Wins!");
                    foreach (Button item in buttons)
                    {
                        item.Enabled = false;
                    }
                }
                else if ((button1.Tag == "o") && (button5.Tag == "o") && (button9.Tag == "o")
                   || (button3.Tag == "o") && (button5.Tag == "o") && (button7.Tag == "o"))
                {
                    winner = "o";
                    MessageBox.Show("O Wins!");
                    foreach (Button item in buttons)
                    {
                        item.Enabled = false;
                    }
                }
                else if (buttons.Count == 0 && winner == "")
                {
                    winner = "draw";
                    MessageBox.Show("Draw!");
                }
            }
            
            testClass t = new testClass();
            label_skor.Text = "Skor: "+ t.testFuncXoX(textBox_StudentNumber.Text,
                winner, button1.Tag.ToString(), button2.Tag.ToString(),
                button3.Tag.ToString(), button4.Tag.ToString(),
                button5.Tag.ToString(), button6.Tag.ToString(),
                button7.Tag.ToString(), button8.Tag.ToString(),
                button9.Tag.ToString()).ToString();
 
        }
        private void ComputerMove()
        {
            MinimaxAlgorithm m = new MinimaxAlgorithm();
            
            int index;
            
           
            if (buttons.Count > 1)
            {
                Button[] board = buttons.ToArray();

                index = m.GetBestMove(boardIndex);
                index = buttons.IndexOf(board[index%(buttons.Count)]);
                boardIndex[index] = -1;
                
                buttons[index].Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\Circle.png");
                buttons[index].Tag = "o";
                buttons[index].Enabled = false;
                buttons.RemoveAt(index);
                for(int i = index+1; i < board.Length; i++)
                {
                    board[i - 1] = board[i];
                }
                
            }
          
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void textBox_StudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void textBox_StudentNumber_Enter(object sender, EventArgs e)
        {
            textBox_StudentNumber.Text = "";
        }

        private int MiniMaxAlgorithm(Button b)
        {
            Random rand = new Random();
            int index=0;
            if (buttons.Count == 9)
            {
                if(buttons.IndexOf(b)==8|| buttons.IndexOf(b) == 7 || buttons.IndexOf(b) == 6)
                {
                    index = buttons.IndexOf(b) - 3;
                }
                else
                {
                    index= buttons.IndexOf(b) + 3;
                }
                
            }
            else
            {
                index = rand.Next(buttons.Count);
            }
            
            return index;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            Form_difficultyLevel difficultyLevel = new Form_difficultyLevel();
            this.Hide();
            difficultyLevel.ShowDialog();
            this.Close();
        }
    }
}

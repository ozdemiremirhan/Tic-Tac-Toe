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
    public partial class Form_difficultGame : Form
    {
        private const int BoardSize = 5;
        private const int MaxDepth = 5;
        private const string PlayerX = "X";
        Image PlayerXimage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\X.jpg");
        private const string PlayerO = "O";
        Image PlayerOimage = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\Circle.png");
        private string[,] board;
        private bool playerXTurn;

        public Form_difficultGame()
        {
            InitializeComponent();
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            board = new string[BoardSize, BoardSize];
            foreach (Button button in Controls.OfType<Button>())
            {
                button.Text = "";
                button.Enabled = true;
                button.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + @"\soruişareti.jpg");
                button_Restart.Image = null;
                button_Restart.Text = "Restart";
                button_Back.Image = null;
                button_Back.Text = "Back";
            }

            playerXTurn = true;
        }
        private void DisableAllButtons()
        {
            foreach (Button button in Controls.OfType<Button>())
            {
                button.Enabled = false;
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            try
            {
                var button = (Button)sender;
                var row = int.Parse(button.Name.Substring(6, 1));
                var col = int.Parse(button.Name.Substring(7, 1));

                if (IsValidMove(row, col))
                {
                    button.Text = playerXTurn ? PlayerX : PlayerO;
                    button.Image = playerXTurn ? PlayerXimage : PlayerOimage;
                    button.Enabled = false;
                    board[row, col] = button.Text;

                    if (CheckWin(playerXTurn ? PlayerX : PlayerO))
                    {
                        MessageBox.Show($"Player {(playerXTurn ? PlayerX : PlayerO)} wins!");
                        DisableAllButtons();
                        button_Restart.Enabled = true;
                        button_Back.Enabled = true;
                        return;
                    }

                    if (IsBoardFull())
                    {
                        MessageBox.Show("It's a draw!");
                        DisableAllButtons();
                        button_Restart.Enabled = true;
                        button_Back.Enabled = true;
                        return;
                    }

                    playerXTurn = !playerXTurn;

                    if (!playerXTurn)
                    {
                        // AI's turn
                        var bestMove = FindBestMove();
                        var aiButton = Controls.OfType<Button>()
                            .FirstOrDefault(btn => btn.Name == $"button{bestMove.Row}{bestMove.Col}");
                        aiButton.PerformClick();
                    }
                }
            }
            catch
            {
            }
        }

        private bool IsValidMove(int row, int col)
        {
            return string.IsNullOrEmpty(board[row, col]);
        }

        private bool CheckWin(string player)
        {
            // Check rows
            for (var i = 0; i < BoardSize; i++)
            {
                for (var j = 0; j <= BoardSize - 3; j++)
                {
                    if (board[i, j] == player && board[i, j + 1] == player && board[i, j + 2] == player)
                        return true;
                }
            }

            // Check columns
            for (var i = 0; i < BoardSize; i++)
            {
                for (var j = 0; j <= BoardSize - 3; j++)
                {
                    if (board[j, i] == player && board[j + 1, i] == player && board[j + 2, i] == player)
                        return true;
                }
            }

            // Check diagonals
            for (var i = 0; i <= BoardSize - 3; i++)
            {
                for (var j = 0; j <= BoardSize - 3; j++)
                {
                    // Check diagonal from top-left to bottom-right
                    if (board[i, j] == player && board[i + 1, j + 1] == player && board[i + 2, j + 2] == player)
                        return true;

                    // Check diagonal from top-right to bottom-left
                    if (board[i, BoardSize - j - 1] == player && board[i + 1, BoardSize - j - 2] == player && board[i + 2, BoardSize - j - 3] == player)
                        return true;
                }
            }

            return false;
        }

        private bool IsBoardFull()
        {
            return !board.Cast<string>().Any(string.IsNullOrEmpty);
        }

        private (int Row, int Col) FindBestMove()
        {
            int bestScore = int.MinValue;
            (int Row, int Col) bestMove = (-1, -1);

            for (int i = 0; i < BoardSize; i++)
            {
                for (int j = 0; j < BoardSize; j++)
                {
                    if (string.IsNullOrEmpty(board[i, j]))
                    {
                        board[i, j] = PlayerO;

                        int score = MiniMax(board, 0, int.MinValue, int.MaxValue, false);

                        board[i, j] = "";

                        if (score > bestScore)
                        {
                            bestScore = score;
                            bestMove = (i, j);
                        }
                    }
                }
            }

            return bestMove;
        }

        private int MiniMax(string[,] board, int depth, int alpha, int beta, bool isMaximizingPlayer)
        {
            string result = CheckGameResult();

            if (result == PlayerX)
            {
                return -1;
            }

            if (result == PlayerO)
            {
                return 1;
            }

            if (IsBoardFull())
            {
                return 0;
            }

            if (depth >= MaxDepth)
            {
                return 0;
            }

            if (isMaximizingPlayer)
            {
                int bestScore = int.MinValue;

                for (int i = 0; i < BoardSize; i++)
                {
                    for (int j = 0; j < BoardSize; j++)
                    {
                        if (string.IsNullOrEmpty(board[i, j]))
                        {
                            board[i, j] = PlayerO;
                            int score = MiniMax(board, depth + 1, alpha, beta, false);
                            board[i, j] = "";

                            bestScore = Math.Max(score, bestScore);
                            alpha = Math.Max(alpha, bestScore);

                            if (beta <= alpha)
                                break;
                        }
                    }
                }

                return bestScore;
            }
            else
            {
                int bestScore = int.MaxValue;

                for (int i = 0; i < BoardSize; i++)
                {
                    for (int j = 0; j < BoardSize; j++)
                    {
                        if (string.IsNullOrEmpty(board[i, j]))
                        {
                            board[i, j] = PlayerX;
                            int score = MiniMax(board, depth + 1, alpha, beta, true);
                            board[i, j] = "";

                            bestScore = Math.Min(score, bestScore);
                            beta = Math.Min(beta, bestScore);

                            if (beta <= alpha)
                                break;
                        }
                    }
                }

                return bestScore;
            }
        }

        private string CheckGameResult()
        {
            for (int row = 0; row < BoardSize; row++)
            {
                if (board[row, 0] != "" && board[row, 0] == board[row, 1] && board[row, 0] == board[row, 2])
                {
                    return board[row, 0];
                }
            }

            for (int col = 0; col < BoardSize; col++)
            {
                if (board[0, col] != "" && board[0, col] == board[1, col] && board[0, col] == board[2, col])
                {
                    return board[0, col];
                }
            }

            if (board[0, 0] != "" && board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
            {
                return board[0, 0];
            }

            if (board[0, 2] != "" && board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
            {
                return board[0, 2];
            }

            return "";
        }

        private void button_Restart_Click(object sender, EventArgs e)
        {
            InitializeBoard();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

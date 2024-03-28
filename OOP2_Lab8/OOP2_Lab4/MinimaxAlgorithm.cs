using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Lab4
{
    public class MinimaxAlgorithm
    {
        public int Minimax(int[] board, int depth, bool isMaximizingPlayer)
        {
            int score = Evaluate(board);
            if (score == 10 || score == -10 || depth == 0)
            {
                return score;
            }

            if (isMaximizingPlayer)
            {
                int bestScore = int.MinValue;
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == 0)
                    {
                        board[i] = 1;
                        int currentScore = Minimax(board, depth - 1, false);
                        board[i] = 0;
                        bestScore = Math.Max(bestScore, currentScore);
                    }
                }
                return bestScore;
            }
            else
            {
                int bestScore = int.MaxValue;
                for (int i = 0; i < board.Length; i++)
                {
                    if (board[i] == 0)
                    {
                        board[i] = -1;
                        int currentScore = Minimax(board, depth - 1, true);
                        board[i] = 0;
                        bestScore = Math.Min(bestScore, currentScore);
                    }
                }
                return bestScore;
            }
        }

        public int GetBestMove(int[] board)
        {
            int bestScore = int.MinValue;
            int bestMove = -1;
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == 0)
                {
                    board[i] = 1;
                    int currentScore = Minimax(board, 4, false);
                    board[i] = 0;
                    if (currentScore > bestScore)
                    {
                        bestScore = currentScore;
                        bestMove = i;
                    }
                }
            }
            return bestMove;
        }

        private int Evaluate(int[] board)
        {
            // Check rows
            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == board[i + 1] && board[i + 1] == board[i + 2])
                {
                    if (board[i] == 1)
                    {
                        return 10;
                    }
                    else if (board[i] == -1)
                    {
                        return -10;
                    }
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == board[i + 3] && board[i + 3] == board[i + 6])
                {
                    if (board[i] == 1)
                    {
                        return 10;
                    }
                    else if (board[i] == -1)
                    {
                        return -10;
                    }
                }
            }

            // Check diagonals
            if (board[0] == board[4] && board[4] == board[8])
            {
                if (board[0] == 1)
                {
                    return 10;
                }
                else if (board[0] == -1)
                {
                    return -10;
                }
            }
            if (board[2] == board[4] && board[4] == board[6])
            {
                if (board[2] == 1)
                {
                    return 10;
                }
                else if (board[2] == -1)
                {
                    return -10;
                }
            }

            return 0;
        }
    }

}

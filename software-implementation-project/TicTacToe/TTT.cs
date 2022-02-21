using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace TicTacToe
{
    public partial class TTT : Form
    {
        DialogResult endGame;
        Player currentPlayer;
        int score = 0;

        public TTT()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens a new login window
        /// </summary>
        /// <returns>Player retrieved from the database</returns>
        private Player LoginDialog()
        {
            RegGUI login = new();

            panel.Enabled = false;

            if (login.ShowDialog(this) == DialogResult.OK)
            {
                Text = "Tic-Tac-Toe: " + login.Player.Nickname;
                panel.Enabled = true;

                return login.Player;
            }

            return null;
        }

        /// <summary>
        /// Checks for a three-in-a-row in every direction on the board
        /// </summary>
        /// <returns>True if a three-in-a-row was found, otherwise false</returns>
        private static bool Winner(List<Button> board)
        {
            /*
            The board is indexed from the top left:
            topLeft = 0, top = 1, topRight = 2
            left = 3, middle = 4, right = 5
            bottomLeft = 6, bottom = 7, bottomRight = 8
            */

            // If digits were used here, they would show to the user.
            // To avoid declaring a winner immediately based on a three-in-a-row of empty strings,
            // checking for a disabled button is required.

            if (!board[0].Enabled && board[0].Text == board[1].Text && board[1].Text == board[2].Text)
            {
                return true;
            }
            else if (!board[3].Enabled && board[3].Text == board[4].Text && board[4].Text == board[5].Text)
            {
                return true;
            }
            else if (!board[6].Enabled && board[6].Text == board[7].Text && board[7].Text == board[8].Text)
            {
                return true;
            }
            else if (!board[0].Enabled && board[0].Text == board[3].Text && board[3].Text == board[6].Text)
            {
                return true;
            }
            else if (!board[1].Enabled && board[1].Text == board[4].Text && board[4].Text == board[7].Text)
            {
                return true;
            }
            else if (!board[2].Enabled && board[2].Text == board[5].Text && board[5].Text == board[8].Text)
            {
                return true;
            }
            else if (!board[0].Enabled && board[0].Text == board[4].Text && board[4].Text == board[8].Text)
            {
                return true;
            }
            else if (!board[6].Enabled && board[6].Text == board[4].Text && board[4].Text == board[2].Text)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks for a three-in-a-row in every direction on the pseudo board
        /// </summary>
        /// <returns>True if a three-in-a-row was found, otherwise false</returns>
        private static bool Winner(string[] pseudoBoard)
        {
            /*
            The pseudo board is indexed from the top left:
            topLeft = 0, top = 1, topRight = 2
            left = 3, middle = 4, right = 5
            bottomLeft = 6, bottom = 7, bottomRight = 8
            */

            // Since this is a pseudo board, digits can be used.
            // In fact they have to be used because checking for a winner in an array full of empty strings always gives you a winner.

            if (pseudoBoard[0] == pseudoBoard[1] && pseudoBoard[1] == pseudoBoard[2])
            {
                return true;
            }
            else if (pseudoBoard[3] == pseudoBoard[4] && pseudoBoard[4] == pseudoBoard[5])
            {
                return true;
            }
            else if (pseudoBoard[6] == pseudoBoard[7] && pseudoBoard[7] == pseudoBoard[8])
            {
                return true;
            }
            else if (pseudoBoard[0] == pseudoBoard[3] && pseudoBoard[3] == pseudoBoard[6])
            {
                return true;
            }
            else if (pseudoBoard[1] == pseudoBoard[4] && pseudoBoard[4] == pseudoBoard[7])
            {
                return true;
            }
            else if (pseudoBoard[2] == pseudoBoard[5] && pseudoBoard[5] == pseudoBoard[8])
            {
                return true;
            }
            else if (pseudoBoard[0] == pseudoBoard[4] && pseudoBoard[4] == pseudoBoard[8])
            {
                return true;
            }
            else if (pseudoBoard[6] == pseudoBoard[4] && pseudoBoard[4] == pseudoBoard[2])
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Shows a MessageBox with an option to start a new game
        /// </summary>
        /// <param name="winner"></param>
        private async Task EndGame(string winner)
        {
            string result;

            if (winner == "Draw!")
            {
                endGame = MessageBox.Show("Draw! New game?", "Game over", MessageBoxButtons.YesNo);
                if (endGame == DialogResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    panel.Enabled = false;
                }
            }
            else
            {
                if (winner == "X")
                {
                    // The author is aware that this code is unreachable.
                    DatabaseConnection db = new();

                    score++;

                    result = await db.SaveHighscore(score, currentPlayer);

                    if (result != "all good")
                    {
                        Text = "Tic-Tac-Toe: " + currentPlayer.Nickname + " - " + result;
                    }
                }

                endGame = MessageBox.Show(winner + " wins! New game?", "Game over", MessageBoxButtons.YesNo);

                if (endGame == DialogResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    panel.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Enables the panel, clears every button's text and enables them.
        /// </summary>
        private void ResetGame()
        {
            panel.Enabled = true;

            foreach (Button button in panel.Controls)
            {
                button.Text = "";
                button.Enabled = true;
            }
        }

        /// <summary>
        /// Checks if any buttons on the board are empty
        /// </summary>
        /// <param name="board"></param>
        /// <returns>True if an empty button was found, otherwise false</returns>
        private static bool MovesLeft(List<Button> board)
        {
            foreach (var move in board)
            {
                if (move.Text == "")
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if any pseudo buttons on the pseudo board are empty
        /// </summary>
        /// <param name="pseudoBoard"></param>
        /// <returns>True if an empty pseudo button was found, otherwise false</returns>
        private static bool MovesLeft(string[] pseudoBoard)
        {
            foreach (var move in pseudoBoard)
            {
                if (char.IsDigit(move[0]))
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Minimax algorithm to find the best possible move for the computer. Totally winnable...
        /// </summary>
        /// <param name="pseudoBoard"></param>
        /// <param name="depth"></param>
        /// <param name="bot"></param>
        /// <returns>-10, 0 or 10 points depending on the outcome of the move</returns>
        private int Minimax(string[] pseudoBoard, int depth, bool bot)
        {
            // If it would be the bot's turn and there is already a winner, minus points to the bot!
            if (bot && Winner(pseudoBoard))
            {
                return -10;
            }
            // If it would be the player's turn and there is already a winner, plus points to the bot!
            else if (!bot && Winner(pseudoBoard))
            {
                return 10;
            }
            // If no moves are left, no points whatsoever.
            else if (MovesLeft(pseudoBoard) == false)
            {
                return 0;
            }

            // If it would be the bot's turn, the algorithm tries to raise the best-value.
            if (bot)
            {
                int best = -10;

                for (int i = 0; i < pseudoBoard.Length; i++)
                {
                    if (char.IsDigit(pseudoBoard[i][0]))
                    {
                        pseudoBoard[i] = "O";

                        // Math.Max is used in the bot's case
                        best = Math.Max(best, Minimax(pseudoBoard, depth + 1, false));

                        pseudoBoard[i] = i.ToString();
                    }
                }

                return best;
            }
            // If it would be the player's turn, the algorithm tries to lower the best-value.
            else
            {
                int best = 10;

                for (int i = 0; i < pseudoBoard.Length; i++)
                {
                    if (char.IsDigit(pseudoBoard[i][0]))
                    {
                        pseudoBoard[i] = "X";

                        // This is the biggest difference. In the player's case, Math.Min is chosen.
                        best = Math.Min(best, Minimax(pseudoBoard, depth + 1, true));

                        pseudoBoard[i] = i.ToString();
                    }
                }

                return best;
            }
        }

        /// <summary>
        /// A fair bot that calls the Minimax algorithm to it's aid in determining the best move for itself
        /// </summary>
        /// <param name="board"></param>
        /// <returns>The best move in the current state of the board as an index number</returns>
        private int Bot(List<Button> board)
        {
            string[] pseudoBoard = new string[9];
            int bestValue = -10, moveIndex = 0;

            // "Converting" the Button list to an array so that the bot's decision making is not shown to the player as flashing buttons
            for (int i = 0; i < board.Count; i++)
            {
                if (board[i].Text != "")
                {
                    pseudoBoard[i] = board[i].Text;
                }
                else
                {
                    pseudoBoard[i] = i.ToString();
                }
            }

            // Here the bot makes temporary moves on a pseudo board and saves the highest valued move's index
            for (int i = 0; i < pseudoBoard.Length; i++)
            {
                // Use of digits explained in Winner().
                if (char.IsDigit(pseudoBoard[i][0]))
                {
                    pseudoBoard[i] = "O";

                    int moveValue = Minimax(pseudoBoard, 0, false);

                    pseudoBoard[i] = i.ToString();

                    if (moveValue > bestValue)
                    {
                        bestValue = moveValue;
                        moveIndex = i;
                    }
                }
            }

            return moveIndex;
        }

        private void ChangePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
            currentPlayer = LoginDialog();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Written by Tearow:\n" +
                "https://github.com/tearoww", "About Tic-Tac-Toe");
        }

        private void TTT_Shown(object sender, EventArgs e)
        {
            currentPlayer = LoginDialog();
        }

        /// <summary>
        /// Marks the player's move on the board and calls the Bot to make it's move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            List<Button> board = new();

            button.Text = "X";
            button.Enabled = false;

            foreach (Button b in panel.Controls)
            {
                board.Add(b);
            }

            // Since the foreach likes to iterate through the buttons from the bottom right up, reversing makes the order easier to understand.
            board.Reverse();

            if (Winner(board))
            {
                await EndGame("X");
            }
            else if (!MovesLeft(board) && !Winner(board))
            {
                await EndGame("Draw!");
            }
            else
            {
                // Bot is called to make a move
                int botMove = Bot(board);
                board[botMove].Text = "O";
                board[botMove].Enabled = false;

                if (Winner(board))
                {
                    await EndGame("O");
                }
                else if (!MovesLeft(board) && !Winner(board))
                {
                    await EndGame("Draw!");
                }
            }
        }
    }
}

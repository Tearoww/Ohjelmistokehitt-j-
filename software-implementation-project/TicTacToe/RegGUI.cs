using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class RegGUI : Form
    {
        Player player;

        public Player Player { get => player; set => player = value; }

        public RegGUI()
        {
            InitializeComponent();
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

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (loginRadioButton.Checked)
            {
                Text = "Login";
                button.Text = "Login";
                loginToolStripMenuItem.Text = "Login";
            }
            else
            {
                Text = "Registration";
                button.Text = "Register";
                loginToolStripMenuItem.Text = "Registration";
            }
        }

        private async void Button_Click(object sender, EventArgs e)
        {
            DatabaseConnection db = new();
            player = new();
            string result;

            if (string.IsNullOrWhiteSpace(nicknameTextBox.Text))
            {
                resultLabel.ResetText();
                resultLabel.Text = "Nickname cannot be empty!";
            }
            else if (string.IsNullOrWhiteSpace(passwordLabel.Text))
            {
                resultLabel.ResetText();
                resultLabel.Text = "Password cannot be empty!";
            }
            else
            {
                if (loginRadioButton.Checked)
                {
                    (player, result) = await db.Login(nicknameTextBox.Text, passwordTextBox.Text);

                    if (result == "all good")
                    {
                        DialogResult = DialogResult.OK;
                        Hide();
                    }
                    else
                    {
                        resultLabel.ResetText();
                        resultLabel.Text = result;
                    }
                }
                else
                {
                    result = await db.Register(nicknameTextBox.Text, passwordTextBox.Text);

                    if (result == "all good")
                    {
                        await db.Login(nicknameTextBox.Text, passwordTextBox.Text);

                        DialogResult = DialogResult.OK;
                        Hide();
                    }
                    else
                    {
                        resultLabel.ResetText();
                        resultLabel.Text = result;
                    }
                }
            }
        }
    }
}

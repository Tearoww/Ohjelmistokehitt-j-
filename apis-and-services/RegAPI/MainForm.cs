using System;
using System.Net.Http;
using System.Text.Json;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace RegAPI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async Task GetJoke()
        {
            HttpClient client = new();

            client.BaseAddress = new Uri("https://v2.jokeapi.dev/");

            var streamTask = client.GetStreamAsync("joke/Any?safe-mode&type=twopart");

            var joke = await JsonSerializer.DeserializeAsync<Joke>(await streamTask);

            jokeSetupLabel.Text = joke.setup;
            jokeDeliveryLabel.Text = joke.delivery;
        }

        private async Task GuessGender()
        {
            HttpClient client = new();

            client.BaseAddress = new Uri("https://api.genderize.io/");

            var streamTask = client.GetStreamAsync("?name=" + firstNameTextBox.Text);

            var gender = await JsonSerializer.DeserializeAsync<Gender>(await streamTask); ;

            if (gender.gender != null)
            {
                // NullReferenceException couldn't be handled, hence the if

                string guessedGender = char.ToUpper(gender.gender[0]) + gender.gender[1..];
                decimal percentage = Math.Round(gender.probability * 100, 0);

                genderComboBox.SelectedItem = guessedGender;
                probabilityLabel.Text = percentage.ToString() + " %";
            }
            else
            {
                genderComboBox.SelectedItem = null;
                probabilityLabel.Text = "";
                ageUpDown.Value = 1;
            }
        }

        private async Task GuessAge()
        {
            HttpClient client = new();

            client.BaseAddress = new Uri("https://api.agify.io/");

            var streamTask = client.GetStreamAsync("?name=" + firstNameTextBox.Text);

            var age = await JsonSerializer.DeserializeAsync<Age>(await streamTask);

            ageUpDown.Value = age.age;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _ = GetJoke();
        }

        private void firstNameTextBox_Leave(object sender, EventArgs e)
        {
            _ = GuessGender();
            _ = GuessAge();
        }

        private void lastNameTextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(firstNameTextBox.Text) && !string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                registerButton.Enabled = true;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                resultLabel.Text = "First name not given!";
            }
            else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                resultLabel.Text = "Last name not given!";
            }
            else if (genderComboBox.SelectedItem == null)
            {
                resultLabel.Text = "Gender not selected!";
            }
            else
            {
                if (ageUpDown.Value >= 18)
                {
                    resultLabel.Text = "Registration successful!";
                }
                else
                {
                    resultLabel.Text = "Can't register. You are underage!";
                }
            }
        }
    }
}

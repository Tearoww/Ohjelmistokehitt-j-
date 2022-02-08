using Npgsql;
using System;
using System.Windows.Forms;

namespace T1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void inputField_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || string.IsNullOrWhiteSpace(lastNameTextBox.Text) || string.IsNullOrWhiteSpace(studentGroupComboBox.Text))
            {
                registerButton.Enabled = false;
            }
            else
            {
                registerButton.Enabled = true;
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=schooldatabases;Database=registration_database";

            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            using (var cmd = new NpgsqlCommand(
                "INSERT INTO public.registrees (first_name, last_name, student_group_id) " +
                "VALUES (@first_name, @last_name, " +
                "(SELECT id FROM public.student_groups WHERE group_name = @group_name))", connection))
            {
                cmd.Parameters.AddWithValue("first_name", firstNameTextBox.Text);
                cmd.Parameters.AddWithValue("last_name", lastNameTextBox.Text);
                cmd.Parameters.AddWithValue("group_name", studentGroupComboBox.Text);
                cmd.ExecuteNonQuery();
            }

            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            studentGroupComboBox.ResetText();
        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=schooldatabases;Database=registration_database";

            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            dataGridView1.Rows.Clear();

            using (var cmd = new NpgsqlCommand(
                "SELECT registrees.id, registrees.first_name, registrees.last_name, student_groups.group_name " +
                "FROM public.registrees, public.student_groups WHERE student_groups.id = registrees.student_group_id " +
                "ORDER BY registrees.id ASC", connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
                }
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridView origin = sender as DataGridView;

            string connectionString = "Host=localhost;Username=postgres;Password=schooldatabases;Database=registration_database";

            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            using (var cmd = new NpgsqlCommand("DELETE FROM public.registrees WHERE id = @id", connection))
            {
                cmd.Parameters.AddWithValue("id", origin.SelectedRows[0].Cells[0].Value);
                cmd.ExecuteNonQuery();
            }
        }

        private void studentGroupComboBox_Enter(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=schooldatabases;Database=registration_database";

            using var connection = new NpgsqlConnection(connectionString);

            connection.Open();

            studentGroupComboBox.Items.Clear();

            using (var cmd = new NpgsqlCommand("SELECT * FROM public.student_groups ORDER BY id ASC", connection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    studentGroupComboBox.Items.Add(reader.GetValue(1));
                }
            }
        }

        private void studentGroupComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                registerButton.Enabled = false;
            }
            else
            {
                registerButton.Enabled = true;
            }
        }
    }
}

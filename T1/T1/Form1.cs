using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace T1
{
    public partial class Rekisterointi : Form
    {
        public Rekisterointi()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            SqlConnection myConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Rekisteri;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConnection.Open();
        }

        private void buttonRekisteroidy_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Rekisteri;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConnection.Open();

            using (var cmd = new SqlCommand("insert into Nimet (Etunimi, Sukunimi, Ryhmä_Id) values (@etunimi, @sukunimi, (select Id from Opiskelijaryhmä where Ryhmän_nimi= @ryhman_nimi))", myConnection))
            {
                cmd.Parameters.AddWithValue("etunimi", EtunimitextBox.Text);
                cmd.Parameters.AddWithValue("sukunimi", SukunimitextBox.Text);
                cmd.Parameters.AddWithValue("ryhman_nimi", OpiskelijaryhmacomboBox.Text);
                cmd.ExecuteNonQuery();
            }
            EtunimitextBox.Clear();
            SukunimitextBox.Clear();

        }

        private void buttonHae_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Rekisteri;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConnection.Open();

            dataGridView1.Rows.Clear();

            using (var cmd = new SqlCommand("SELECT Nimet.Id, Nimet.Etunimi, Nimet.Sukunimi, Opiskelijaryhmä.Ryhmän_nimi FROM Nimet, Opiskelijaryhmä where Opiskelijaryhmä.Id=Nimet.Ryhmä_Id", myConnection))
            using (var reader = cmd.ExecuteReader())
            {
                while ( reader.Read())
                    dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1),reader.GetValue(2),reader.GetValue(3));
            }
        }

        private void Tekstikentta_teksipaivittyi(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EtunimitextBox.Text)||string.IsNullOrWhiteSpace(SukunimitextBox.Text)||string.IsNullOrWhiteSpace(OpiskelijaryhmacomboBox.Text))
            {
                buttonRekisteroidy.Enabled = false;
            }
            else
            {
                buttonRekisteroidy.Enabled = true;
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DataGridView source = sender as DataGridView;
            SqlConnection myConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Rekisteri;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConnection.Open();
            using (var cmd = new SqlCommand("DELETE FROM Nimet WHERE Id = @id", myConnection))
            {
                cmd.Parameters.AddWithValue("id", source.SelectedRows[0].Cells[0].Value);
                cmd.ExecuteNonQuery();
            }

        }

        private void OpiskelijaryhmacomboBox_DropDown(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Rekisteri;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            myConnection.Open();
            OpiskelijaryhmacomboBox.Items.Clear();
            using (var cmd = new SqlCommand("SELECT * FROM Opiskelijaryhmä", myConnection))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                    OpiskelijaryhmacomboBox.Items.Add(reader.GetValue(1));
            }
        }

        private void OpiskelijaryhmacomboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EtunimitextBox.Text) || string.IsNullOrWhiteSpace(SukunimitextBox.Text))
            {
                buttonRekisteroidy.Enabled = false;
            }
            else
            {
                buttonRekisteroidy.Enabled = true;
            }
        }
    }
}

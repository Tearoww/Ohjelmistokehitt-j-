
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Autokauppa.model
{
    public class DatabaseHallinta
    {
        string yhteysTiedot;
        SqlConnection dbYhteys;
        SqlCommand cmd;

        public DatabaseHallinta()
        {

        }

        public bool connectDatabase()
        {
            yhteysTiedot = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Autokauppa;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            dbYhteys = new SqlConnection(yhteysTiedot);

            try
            {
                dbYhteys.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Virheilmoitukset:" + e);
                dbYhteys.Close();
                return false;

            }

        }

        public void disconnectDatabase()
        {
            dbYhteys.Close();
        }

        public bool saveAutoIntoDatabase(Auto newAuto)
        {
            bool palaute = false;
            return palaute;


        }

        public List<AutoMerkki> getAllAutoMakersFromDatabase()
        {
            connectDatabase();
            List<AutoMerkki> palaute = new List<AutoMerkki>();
            cmd = new SqlCommand("select * from AutonMerkki", dbYhteys);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                AutoMerkki merkki = new AutoMerkki();
                merkki.Id = reader.GetInt32(0);
                merkki.MerkkiNimi = reader.GetString(1);
                palaute.Add(merkki);
            }
            disconnectDatabase();
            return palaute;

        }

        public List<AutoMalli> getAutoModelsByMakerId(int makerId)

        {
            connectDatabase();
            List<AutoMalli> palaute = new List<AutoMalli>();
            cmd = new SqlCommand("select * from AutonMallit where AutonMerkkiID = @merkki_id", dbYhteys);
            cmd.Parameters.AddWithValue("merkki_id", makerId);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                AutoMalli malli = new AutoMalli();
                malli.Id = reader.GetInt32(0);
                malli.MalliNimi = reader.GetString(1);
                malli.MerkkiId = reader.GetInt32(2);
                palaute.Add(malli);
            }
            disconnectDatabase();
            return palaute;
        }

    }
}

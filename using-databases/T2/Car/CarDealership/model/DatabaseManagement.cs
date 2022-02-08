using Npgsql;
using System;
using System.Collections.Generic;

namespace CarDealership.model
{
    public class DatabaseManagement
    {
        string connectionString;
        NpgsqlConnection connection;
        NpgsqlCommand cmd;

        public DatabaseManagement()
        {
        }

        public bool Connect()
        {
            connectionString = "Host=localhost;Username=postgres;Password=schooldatabases;Database=car_dealership";

            connection = new NpgsqlConnection(connectionString);
            
            try
            { 
                connection.Open();
                return true;
            }
            catch(Exception e)
            { 
                Console.WriteLine("Errors:" + e);
                connection.Close();
                return false;
            }
        }

        public void Disconnect()
        {
            connection.Close();
        }

        public bool SaveCar(Car car)
        {
            if (Connect())
            {
                cmd = new(
                    "INSERT INTO public.cars (price, date_of_registration, engine_displacement, mileage, make_id, model_id, color_id, fuel_id) " +
                    "VALUES (@price, @date_of_registration, @engine_displacement, @mileage, @make_id, @model_id, @color_id, @fuel_id)", connection);

                cmd.Parameters.AddWithValue("price", car.Price);
                cmd.Parameters.AddWithValue("date_of_registration", car.DateOfRegistration);
                cmd.Parameters.AddWithValue("engine_displacement", car.EngineDisplacement);
                cmd.Parameters.AddWithValue("mileage", car.Mileage);
                cmd.Parameters.AddWithValue("make_id", car.MakeId);
                cmd.Parameters.AddWithValue("model_id", car.ModelId);
                cmd.Parameters.AddWithValue("color_id", car.ColorId);
                cmd.Parameters.AddWithValue("fuel_id", car.FuelId);

                if (cmd.ExecuteNonQuery() != -1)
                {
                    Disconnect();

                    return true;
                }
                else
                {
                    Disconnect();

                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public List<Make> GetMakes()
        {
            if (Connect())
            {
                List<Make> makes = new();
                cmd = new("SELECT * FROM public.makes ORDER BY id ASC", connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Make make = new();
                    make.Id = reader.GetInt32(0);
                    make.Name = reader.GetString(1);
                    makes.Add(make);
                }

                Disconnect();

                return makes;
            }
            else
            {
                return null;
            }
        }

        public List<Model> GetModels(int selectedMake) 
        {
            if (Connect())
            {
                List<Model> models = new();
                cmd = new(
                    "SELECT * FROM public.models WHERE make_id = @make_id", connection);
                cmd.Parameters.AddWithValue("make_id", selectedMake);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Model model = new();
                    model.Id = reader.GetInt32(0);
                    model.ModelName = reader.GetString(1);
                    model.MakeId = reader.GetInt32(2);
                    models.Add(model);
                }

                Disconnect();

                return models;

            }
            else
            {
                return null;
            }
        }

        public List<Color> GetColors()
        {
            if (Connect())
            {
                List<Color> colors = new();
                cmd = new("SELECT * FROM public.colors ORDER BY id ASC", connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Color color = new();
                    color.Id = reader.GetInt32(0);
                    color.ColorName = reader.GetString(1);
                    colors.Add(color);
                }

                Disconnect();

                return colors;
            }
            else
            {
                return null;
            }
        }

        public List<Fuel> GetFuels()
        {
            if (Connect())
            {
                List<Fuel> fuels = new();
                cmd = new("SELECT * FROM public.fuels ORDER BY id ASC", connection);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Fuel fuel = new();
                    fuel.Id = reader.GetInt32(0);
                    fuel.FuelName = reader.GetString(1);
                    fuels.Add(fuel);
                }

                Disconnect();

                return fuels;
            }
            else
            {
                return null;
            }
        }

        public (Car, bool) GetCar(int carId)
        {
            if (Connect())
            {
                bool foundCar = false;
                Car car = new();
                cmd = new("SELECT * FROM public.cars WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("id", carId);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    foundCar = true;

                    car.Price = reader.GetDecimal(1);
                    car.DateOfRegistration = reader.GetDateTime(2);
                    car.EngineDisplacement = reader.GetDecimal(3);
                    car.Mileage = reader.GetInt32(4);
                    car.MakeId = reader.GetInt32(5);
                    car.ModelId = reader.GetInt32(6);
                    car.ColorId = reader.GetInt32(7);
                    car.FuelId = reader.GetInt32(8);
                }

                Disconnect();

                if (foundCar)
                {
                    return (car, true);
                }
                else
                {
                    return (null, false);
                }
            }
            else
            {
                return (null, false);
            }
        }

        public int GetIdentity(string orderBy)
        {
            if (Connect())
            {
                if (orderBy == "ASC")
                {
                    cmd = new("SELECT * FROM public.cars ORDER BY id ASC", connection);
                    var identity = cmd.ExecuteScalar();

                    Disconnect();

                    return (int)identity;
                }
                else
                {
                    cmd = new("SELECT * FROM public.cars ORDER BY id DESC", connection);
                    var identity = cmd.ExecuteScalar();

                    Disconnect();

                    return (int)identity;
                }
            }
            else
            {
                return -1;
            }
        }

        public bool DeleteCar(int id)
        {
            if (Connect())
            {
                cmd = new("DELETE FROM public.cars WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("id", id);

                if (cmd.ExecuteNonQuery() != -1)
                {
                    Disconnect();

                    return true;
                }
                else
                {
                    Disconnect();

                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

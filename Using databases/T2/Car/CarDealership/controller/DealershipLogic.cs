using System.Collections.Generic;
using CarDealership.model;

namespace CarDealership.controller
{
    public class DealershipLogic
    {
        readonly DatabaseManagement database = new();

        public bool TestDatabaseConnection()
        {
            bool connected = database.Connect();
            return connected;
        }

        public bool SaveCar(Car car) 
        {
            bool saved = database.SaveCar(car);
            return saved;
        }

        public List<Make> GetMakes()
        {
            return database.GetMakes();
        }

        public List<Model> GetModels(int selectedMake) 
        {
            return database.GetModels(selectedMake);
        }

        public List<Color> GetColors()
        {
            return database.GetColors();
        }

        public List<Fuel> GetFuels()
        {
            return database.GetFuels();
        }

        public (Car, bool) GetCar(int carId)
        {
            return database.GetCar(carId);
        }

        public int GetIdentity(string orderBy)
        {
            return database.GetIdentity(orderBy);
        }

        public bool DeleteCar(int id)
        {
            return database.DeleteCar(id);
        }
    }
}

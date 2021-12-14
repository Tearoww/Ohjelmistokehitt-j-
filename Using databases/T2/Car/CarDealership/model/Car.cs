using System;

namespace CarDealership.model
{
    public class Car
    {
        int id, mileage, makeId, modelId, colorId, fuelId;
        decimal price, engineDisplacement;
        DateTime dateOfRegistration;

        public int Id { get => id; set => id = value; }
        public decimal Price { get => price; set => price = value; }
        public DateTime DateOfRegistration { get => dateOfRegistration; set => dateOfRegistration = value; }
        public decimal EngineDisplacement { get => engineDisplacement; set => engineDisplacement = value; }
        public int Mileage { get => mileage; set => mileage = value; }
        public int MakeId { get => makeId; set => makeId = value; }
        public int ModelId { get => modelId; set => modelId = value; }
        public int ColorId { get => colorId; set => colorId = value; }
        public int FuelId { get => fuelId; set => fuelId = value; }
    }
}

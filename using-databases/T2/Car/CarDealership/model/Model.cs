namespace CarDealership.model
{
    public class Model
    {
        int id, makeId;
        string modelName;

        public int Id { get => id; set => id = value; }
        public int MakeId { get => makeId; set => makeId = value; }
        public string ModelName { get => modelName; set => modelName = value; }
    }
}

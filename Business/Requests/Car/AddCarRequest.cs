namespace Business.Requests.Car
{
    public class AddCarRequest
    {
        public string Name { get; set; }
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        public short ModelYear { get; set; }
        public string Plate { get; set; }
        public AddCarRequest(string name, int colorId, int modelId, string carState, int kilometer, short modelYear, string plate)
        {
            Name = name;
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            ModelYear = modelYear;
            Plate = plate;
        }
    }
}
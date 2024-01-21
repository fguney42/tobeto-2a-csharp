namespace Business.Requests.Model
{
    public class AddModelRequest
    {
        public string Name { get; set; }
        public short Year { get; set; }
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }
        public decimal DailyPrice { get; set; }
        public AddModelRequest(string name, short year, int brandID, int fuelId, int transmissionId, decimal dailyPrice)
        {
            Name = name;
            Year = year;
            BrandId = brandID;
            FuelId = fuelId;
            TransmissionId = transmissionId;
            DailyPrice = dailyPrice;
        }
    }
}

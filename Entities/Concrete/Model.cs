using Core.Entities;

namespace Entities.Concrete;

public class Model : Entity<int>
{
    public string Name { get; set; }
    public short Year { get; set; }
    public int BrandId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public decimal DailyPrice { get; set; }

    public Model()
    {
    }
    public Model(string name, short year, int brandId, int fuelId, int transmissionId, decimal dailyPrice)
    {
        Name = name;
        Year = year;
        BrandId = brandId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        DailyPrice = dailyPrice;
    }
}
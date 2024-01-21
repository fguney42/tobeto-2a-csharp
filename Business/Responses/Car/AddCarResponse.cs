using System;
using System.Collections.Generic;

namespace Business.Responses.Car
{
    public class AddCarResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        public short ModelYear { get; set; }
        public string Plate { get; set; }
        public AddCarResponse(int id, string name, int colorId, int modelId, string carState, int kilometer, short modelYear, string plate)
        {
            Id = id;
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
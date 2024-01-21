﻿namespace Business.Dtos.Car
{
    public class CarListItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        public short ModelYear { get; set; }
        public string Plate { get; set; }
    }
}
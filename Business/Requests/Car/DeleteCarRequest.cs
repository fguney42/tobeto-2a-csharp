﻿namespace Business.Requests.Car
{
    public class DeleteCarRequest
    {
        public int Id { get; set; }
        public DeleteCarRequest(int id)
        {
            Id = id;
        }
    }
}
﻿using AutoMapper;
using Business.Dtos.Fuel;
using Business.Requests.Fuel;
using Business.Responses.Fuel;
using Entities.Concrete;

namespace Business.Mapping.Profiles.AutoMapper
{
    public class FuelMapperProfile : Profile
    {
        public FuelMapperProfile()
        {
            CreateMap<AddFuelRequest, Fuel>();
            CreateMap<Fuel, AddFuelResponse>();

            CreateMap<Fuel, FuelListItemDto>();
            CreateMap<IList<Fuel>, GetFuelListResponse>().ForMember(
                destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src)
            );
        }
    }
}
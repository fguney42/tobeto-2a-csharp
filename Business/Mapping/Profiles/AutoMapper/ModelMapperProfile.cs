﻿using AutoMapper;
using Business.Dtos.Model;
using Business.Requests.Model;
using Business.Responses.Model;
using Entities.Concrete;

namespace Business.Mapping.Profiles.AutoMapper
{
    public class ModelMapperProfile : Profile
    {
        public ModelMapperProfile()
        {
            CreateMap<AddModelRequest, Model>();
            CreateMap<Model, AddModelResponse>();

            CreateMap<Model, ModelListItemDto>();
            CreateMap<IList<Model>, GetModelListResponse>().ForMember(
                destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src)
            );
        }
    }
}
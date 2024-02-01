using AutoMapper;
using Business.Dtos.Transmission;
using Business.Requests.Transmission;
using Business.Responses.Transmission;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class TransmissionMapperProfile : Profile
    {
        public TransmissionMapperProfile()
        {
            CreateMap<AddTransmissionRequest, Transmission>();
            CreateMap<Transmission, AddTransmissionResponse>();
            CreateMap<Transmission, TransmissionListItemDto>();
            CreateMap<IList<Transmission>, GetTransmissionListResponse>().ForMember(
                destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src)
            );
        }
    }
}
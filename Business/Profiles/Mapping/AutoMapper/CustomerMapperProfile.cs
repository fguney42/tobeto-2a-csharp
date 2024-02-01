using AutoMapper;
using Business.Dtos.Customer;
using Business.Requests;
using Business.Requests.Customer;
using Business.Responses.Customer;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Business.Profiles.Mapping.AutoMapper
{
    public class CustomerMapperProfile : Profile
    {
        public CustomerMapperProfile()
        {
            CreateMap<AddIndividualCustomerRequest, Customer>();
            CreateMap<Customer, AddCustomerResponse>();
            CreateMap<Customer, CustomerListItemDto>();
            CreateMap<IList<Customer>, GetCustomerListResponse>().ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));
            CreateMap<Customer, DeleteCustomerResponse>();
            CreateMap<Customer, GetCustomerByIdResponse>();
            CreateMap<UpdateIndividualCustomerRequest, Customer>();
            CreateMap<Customer, UpdateCustomerResponse>();
        }
    }
}
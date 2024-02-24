using AutoMapper;
using Business.Dtos.Customer;
using Business.Requests.Customer;
using Business.Responses.Customer;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class CustomerMapperProfile : Profile
    {
        public CustomerMapperProfile()
        {
            CreateMap<AddCustomerRequest, Customer>();
            CreateMap<Customer, AddCustomerResponse>();

            CreateMap<Customer, CustomerListItemDto>();
            CreateMap<IList<Customer>, GetCustomerListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            CreateMap<Customer, DeleteCustomerResponse>();

            CreateMap<Customer, GetCustomerByIdResponse>();

            CreateMap<UpdateCustomerRequest, Customer>();
            CreateMap<Customer, UpdateCustomerResponse>();
        }
    }
}

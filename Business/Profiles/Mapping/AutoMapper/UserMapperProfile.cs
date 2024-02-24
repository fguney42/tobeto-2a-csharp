using AutoMapper;
using Business.Dtos.User;
using Business.Requests.User;
using Business.Responses.User;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<AddUserRequest, User>();
            CreateMap<User, AddUserResponse>();

            CreateMap<User, UserListItemDto>();
            CreateMap<IList<User>, GetUserListResponse>()
                .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src));

            CreateMap<User, DeleteUserResponse>();

            CreateMap<User, GetUserByIdResponse>();

            CreateMap<UpdateUserRequest, User>();
            CreateMap<User, UpdateUserResponse>();
        }
    }
}

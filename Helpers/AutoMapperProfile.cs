using AutoMapper;
using SmartHome.API.Entities;
using SmartHome.API.Models.Users;

namespace SmartHome.API.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}
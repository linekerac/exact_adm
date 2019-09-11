using AutoMapper;
using ExactAdm.Application.DTO;
using ExactAdm.Domain.Entities;

namespace ExactAdm.Application
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}

using AutoMapper;
using ExactAdm.Domain.Entities;
using ExactAdm.Infra.Application.DTO;

namespace ExactAdm.Infra.Application
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

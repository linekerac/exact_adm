using AutoMapper;
using ExactAdm.Domain.Entities;
using ExactAdm.Domain.Interfaces.Services;
using ExactAdm.Infra.Application.DTO;
using ExactAdm.Infra.Application.Interfaces;

namespace ExactAdm.Infra.Application.Services
{
    public class UserApp : ServiceAppBase<User, UserDTO>, IUserBase
    {
        public UserApp(IMapper iMapper, IUserService servico)
            : base(iMapper, servico)
        {

        }
    }
}

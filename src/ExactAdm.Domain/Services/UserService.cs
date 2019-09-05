using ExactAdm.Domain.Entities;
using ExactAdm.Domain.Interfaces.Repositories;
using ExactAdm.Domain.Interfaces.Services;

namespace ExactAdm.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public UserService(IUserRepository repositorio)
            : base(repositorio)
        {

        }
    }
}

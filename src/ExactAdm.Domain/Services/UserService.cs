using ExactAdm.Domain.Entities;
using ExactAdm.Domain.Interfaces.Repositories;
using ExactAdm.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace ExactAdm.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        public UserService(IUserRepository repositorio)
            : base(repositorio)
        {
        }

        public IEnumerable<User> ObterUsuariosAdmin(IEnumerable<User> usuarios)
        {
            return usuarios.Where(u => u.UserIsAdmin(u));
        }
    }
}

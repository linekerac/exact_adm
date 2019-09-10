using ExactAdm.Domain.Entities;
using System.Collections.Generic;

namespace ExactAdm.Domain.Interfaces.Services
{
    public interface IUserService : IServiceBase<User>
    {
        IEnumerable<User> ObterUsuariosAdmin(IEnumerable<User> usuarios);
    }
}

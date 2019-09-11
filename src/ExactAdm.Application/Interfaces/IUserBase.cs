using ExactAdm.Application.DTO;
using ExactAdm.Domain.Entities;
using System.Collections.Generic;

namespace ExactAdm.Application.Interfaces
{
    public interface IUserBase : IAppBase<User, UserDTO>
    {
        IEnumerable<User> ObterUsuariosAdmin();
    }
}

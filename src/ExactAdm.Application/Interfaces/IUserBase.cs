using ExactAdm.Domain.Entities;
using ExactAdm.Infra.Application.DTO;
using System.Collections.Generic;

namespace ExactAdm.Infra.Application.Interfaces
{
    public interface IUserBase : IAppBase<User, UserDTO>
    {
        IEnumerable<User> ObterUsuariosAdmin();
    }
}

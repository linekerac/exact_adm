using ExactAdm.Domain.Entities;
using ExactAdm.Infra.Application.DTO;

namespace ExactAdm.Infra.Application.Interfaces
{
    public interface IUserBase : IAppBase<User, UserDTO>
    {
    }
}

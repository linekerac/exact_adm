using ExactAdm.Domain.Entities;
using ExactAdm.Infra.Application.DTO;
using ExactAdm.Infra.Application.Interfaces;

namespace ExactAdm.WebApi.Controllers
{
    public class UserController : ControllerBase<User, UserDTO>
    {
        public UserController(IUserBase app)
            : base(app)
        { }
    }
}
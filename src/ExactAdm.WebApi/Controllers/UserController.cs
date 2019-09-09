using ExactAdm.Domain.Entities;
using ExactAdm.Infra.Application.DTO;
using ExactAdm.Infra.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ExactAdm.WebApi.Controllers
{
    public class UserController : ControllerBase<User, UserDTO>
    {
        public UserController(IUserBase app)
            : base(app)
        { }

        [HttpPost]
        [Route("Incluir")]
        public override IActionResult Incluir(UserDTO dado)
        {
            try
            {
                app.Incluir(dado);
                return null;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
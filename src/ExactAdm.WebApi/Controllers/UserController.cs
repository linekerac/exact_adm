using ExactAdm.Domain.Entities;
using ExactAdm.Infra.Application.DTO;
using ExactAdm.Infra.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ExactAdm.WebApi.Controllers
{
    public class UserController : ControllerBase<User, UserDTO>
    {
        readonly protected IUserBase app;

        public UserController(IUserBase app)
            : base(app)
        {
            this.app = app;
        }

        [HttpPost]
        [Route("Incluir")]
        public override IActionResult Incluir(UserDTO dado)
        {
            try
            {
                return new OkObjectResult(app.Incluir(dado));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public ActionResult UsersAdmin()
        {
            var userViewModel = app.ObterUsuariosAdmin();
            return View(userViewModel);
        }
    }
}
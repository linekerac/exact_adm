using ExactAdm.Domain.Entities;
using ExactAdm.Application.DTO;
using ExactAdm.Application.Interfaces;
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
                app.Incluir(dado);
                return new OkObjectResult("ok");
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
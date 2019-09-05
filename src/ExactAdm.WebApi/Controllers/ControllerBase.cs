using System;
using ExactAdm.Domain.Entities;
using ExactAdm.Infra.Application.DTO;
using ExactAdm.Infra.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ExactAdm.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ControllerBase<Entidade, EntidadeDTO> : Controller
        where Entidade : EntidadeBase
        where EntidadeDTO : DTOBase
    {
        readonly protected IAppBase<Entidade, EntidadeDTO> app;

        public ControllerBase(IAppBase<Entidade, EntidadeDTO> app)
        {
            this.app = app;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Listar()
        {
            try
            {
                var restaurantes = app.SelecionarTodos();
                return new OkObjectResult(restaurantes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult SelecionarPorId(int id)
        {
            try
            {
                var restaurantes = app.SelecionarPorId(id);
                return new OkObjectResult(restaurantes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Incluir(EntidadeDTO dado)
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

        [HttpPut]
        public IActionResult Alterar([FromBody] EntidadeDTO dado)
        {
            try
            {
                app.Alterar(dado);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Excluir(int id)
        {
            try
            {
                app.Excluir(id);
                return new OkObjectResult(true);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
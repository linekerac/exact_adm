using AutoMapper;
using ExactAdm.Domain.Entities;
using ExactAdm.Domain.Interfaces.Services;
using ExactAdm.Infra.Application.DTO;
using ExactAdm.Infra.Application.Interfaces;
using System.Collections.Generic;

namespace ExactAdm.Infra.Application.Services
{
    public class UserApp : ServiceAppBase<User, UserDTO>, IUserBase
    {
        private readonly IUserService _usuarioService;
        public UserApp(IMapper iMapper, IUserService servico)
            : base(iMapper, servico)
        {
            _usuarioService = servico;
        }

        public IEnumerable<User> ObterUsuariosAdmin()
        {
            return _usuarioService.ObterUsuariosAdmin(_usuarioService.SelecionarTodos());
        }
    }
}

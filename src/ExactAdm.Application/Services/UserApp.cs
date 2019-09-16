using AutoMapper;
using ExactAdm.Application.DTO;
using ExactAdm.Application.Interfaces;
using ExactAdm.Domain.Entities;
using ExactAdm.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ExactAdm.Application.Services
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

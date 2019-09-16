using AutoMapper;
using ExactAdm.Application.DTO;
using ExactAdm.Application.Interfaces;
using ExactAdm.Domain.Entities;
using ExactAdm.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ExactAdm.Application.Services
{
    public class ServiceAppBase<TEntidade, TEntidadeDTO> : IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase
        where TEntidadeDTO : DTOBase
    {
        protected readonly IServiceBase<TEntidade> servico;
        protected readonly IMapper iMapper;

        public ServiceAppBase(IMapper iMapper, IServiceBase<TEntidade> servico)
            : base()
        {
            this.iMapper = iMapper;
            this.servico = servico;
        }

        public void Alterar(TEntidadeDTO entidade)
        {
            servico.Alterar(iMapper.Map<TEntidade>(entidade));
        }

        public void Excluir(int id)
        {
            servico.Excluir(id);
        }

        public void Excluir(TEntidadeDTO entidade)
        {
            servico.Excluir(iMapper.Map<TEntidade>(entidade));
        }

        public void Incluir(TEntidadeDTO entidade)
        {
            var t = iMapper.Map<TEntidadeDTO, TEntidade>(entidade);
            servico.Incluir(t);
        }

        public TEntidadeDTO SelecionarPorId(int id)
        {
            return iMapper.Map<TEntidadeDTO>(servico.SelecionarPorId(id));
        }

        public IEnumerable<TEntidadeDTO> SelecionarTodos()
        {
            return iMapper.Map<IEnumerable<TEntidadeDTO>>(servico.SelecionarTodos());
        }
    }
}

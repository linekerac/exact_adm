using ExactAdm.Domain.Entities;
using ExactAdm.Domain.Interfaces.Repositories;
using ExactAdm.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ExactAdm.Domain.Services
{
    public class ServiceBase<TEntidade> : IServiceBase<TEntidade> where TEntidade : EntidadeBase
    {
        protected readonly IRepositoryBase<TEntidade> repositorio;

        public ServiceBase(IRepositoryBase<TEntidade> repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Alterar(TEntidade entidade)
        {
            repositorio.Alterar(entidade);
        }

        public void Excluir(int id)
        {
            repositorio.Excluir(id);
        }

        public void Excluir(TEntidade entidade)
        {
            repositorio.Excluir(entidade);
        }

        public int Incluir(TEntidade entidade)
        {
            return repositorio.Incluir(entidade);
        }

        public TEntidade SelecionarPorId(int id)
        {
            return repositorio.SelecionarPorId(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return repositorio.SelecionarTodos();
        }
    }
}

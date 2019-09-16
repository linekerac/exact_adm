using ExactAdm.Domain.Entities;
using ExactAdm.Domain.Interfaces.Repositories;
using ExactAdm.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace ExactAdm.Infra.Data.Repositories
{
    public class RepositoryBase<TEntidade> : IRepositoryBase<TEntidade>
        where TEntidade : EntidadeBase
    {
        protected readonly ApplicationDbContext contexto;

        public RepositoryBase(ApplicationDbContext contexto)
            : base()
        {
            this.contexto = contexto;
        }

        public void Alterar(TEntidade entidade)
        {
            contexto.InitTransacao();
            contexto.Set<TEntidade>().Attach(entidade);
            contexto.Entry(entidade).State = EntityState.Modified;
            contexto.SendChanges();
        }

        public void Excluir(int id)
        {
            var entidade = SelecionarPorId(id);
            if (entidade != null)
            {
                contexto.InitTransacao();
                contexto.Set<TEntidade>().Remove(entidade);
                contexto.SendChanges();
            }
        }

        public void Excluir(TEntidade entidade)
        {
            contexto.InitTransacao();
            contexto.Set<TEntidade>().Remove(entidade);
            contexto.SendChanges();
        }

        public void Incluir(TEntidade entidade)
        {
            contexto.InitTransacao();
            contexto.Set<TEntidade>().Add(entidade);
            contexto.SendChanges();
        }

        public TEntidade SelecionarPorId(int id)
        {
            return contexto.Set<TEntidade>().Find(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return contexto.Set<TEntidade>().ToList();
        }
    }
}

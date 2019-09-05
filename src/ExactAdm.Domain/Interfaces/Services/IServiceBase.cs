using ExactAdm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExactAdm.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntidade>
        where TEntidade : EntidadeBase
    {
        int Incluir(TEntidade entidade);
        void Excluir(int id);
        void Excluir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        TEntidade SelecionarPorId(int id);
        IEnumerable<TEntidade> SelecionarTodos();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ExactAdm.Domain.Entities
{
    public class User : EntidadeBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public User(int Id, string Nome, string Sobrenome)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
        }
    }
}

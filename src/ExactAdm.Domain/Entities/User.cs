using System;
using System.Collections.Generic;
using System.Text;

namespace ExactAdm.Domain.Entities
{
    public class User : EntidadeBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public User()
        {

        }
    }
}

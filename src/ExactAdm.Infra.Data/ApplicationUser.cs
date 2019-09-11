using ExactAdm.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExactAdm.Infra.Data
{
    public class ApplicationUser : IdentityUser
    {
        public int? UsuarioId { get; set; }
        public virtual User User { get; set; }
    }
}

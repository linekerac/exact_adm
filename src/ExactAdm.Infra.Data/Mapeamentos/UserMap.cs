using ExactAdm.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExactAdm.Infra.Data.Mapeamentos
{
    public class UserMap : MapBase<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.ToTable("user");
            builder.Property(c => c.Nome).IsRequired().HasColumnName("Nome").HasMaxLength(100);
            builder.Property(c => c.Sobrenome).IsRequired().HasColumnName("Sobrenome");
        }
    }
}

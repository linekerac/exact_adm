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
            builder.ToTable("users");
            builder.Property(c => c.USERID).IsRequired().HasColumnName("USERID").HasMaxLength(100);
            builder.Property(c => c.PASSWORD).IsRequired().HasColumnName("PASSWORD");
        }
    }
}

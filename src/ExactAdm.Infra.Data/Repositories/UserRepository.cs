using ExactAdm.Domain.Entities;
using ExactAdm.Domain.Interfaces.Repositories;
using ExactAdm.Infra.Data.Context;

namespace ExactAdm.Infra.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext contexto)
            : base(contexto)
        {
        }
    }
}

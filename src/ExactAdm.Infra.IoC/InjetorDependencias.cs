using ExactAdm.Domain.Interfaces.Repositories;
using ExactAdm.Domain.Interfaces.Services;
using ExactAdm.Domain.Services;
using ExactAdm.Infra.Application.Interfaces;
using ExactAdm.Infra.Application.Services;
using ExactAdm.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace ExactAdm.Infra.IoC
{
    public class InjetorDependencias
    {
        public static void Registrar(IServiceCollection svcCollection)
        {
            //Aplicação
            svcCollection.AddScoped(typeof(IAppBase<,>), typeof(ServiceAppBase<,>));
            svcCollection.AddScoped<IUserBase, UserApp>();

            //Domínio
            svcCollection.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));
            svcCollection.AddScoped<IUserService, UserService>();

            //Repositorio
            svcCollection.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
            svcCollection.AddScoped<IUserRepository, UserRepository>();
        }
    }
}

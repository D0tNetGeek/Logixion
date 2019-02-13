using Ninject.Modules;
using Logixion.Domain.IRepository;
using Logixion.Domain.Repository;
using Logixion.Domain.Database;
namespace Logixion.Infrastructure.DependencyInjection
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<LogixionDbContext>().To<LogixionDbContext>();
            Bind<IUserDetailRepository>().To<UserDetailRepository>();
            Bind<IEmployeeRepository>().To<EmployeeRepository>();
        }
    }
}

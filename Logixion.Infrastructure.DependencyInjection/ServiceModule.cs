using Ninject.Modules;
using Logixion.Services.IService;
using Logixion.Services.Service;

namespace Logixion.Infrastructure.DependencyInjection
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILogixionMapper>().To<LogixionMapper>();
            Bind<IUserDetailService>().To<UserDetailService>();
            Bind<IEmployeeService>().To<EmployeeService>();
        }
    }
}

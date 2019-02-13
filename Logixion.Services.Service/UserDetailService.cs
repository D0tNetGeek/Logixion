using Logixion.Domain.IRepository;
using Logixion.Services.IService;
using Logixion.Services.Models;
namespace Logixion.Services.Service
{
    public class UserDetailService : GenericService<UserDetail, Logixion.Domain.Entities.UserDetail, int>, IUserDetailService
    {
        public UserDetailService(IUserDetailRepository userDetailRepository) : base(userDetailRepository)
        {
        }
    }
}

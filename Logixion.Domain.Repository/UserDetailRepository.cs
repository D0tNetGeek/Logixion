using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Logixion.Domain.Database;
using Logixion.Domain.Entities;
using Logixion.Domain.IRepository;
using System.Data.Entity;

namespace Logixion.Domain.Repository
{
    public class UserDetailRepository : GenericRepository<UserDetail, int>, IUserDetailRepository
    {
        public UserDetailRepository(LogixionDbContext logixionDb) : base(logixionDb)
        {
        }
        
    }
}

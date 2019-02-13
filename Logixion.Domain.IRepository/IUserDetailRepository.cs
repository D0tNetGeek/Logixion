using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logixion.Domain.Entities;
using System.Linq.Expressions;

namespace Logixion.Domain.IRepository
{
    public interface IUserDetailRepository:IGenericRepository<UserDetail,int>
    {
        
    }
}

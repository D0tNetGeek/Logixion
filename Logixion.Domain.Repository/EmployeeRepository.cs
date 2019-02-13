using Logixion.Domain.Database;
using Logixion.Domain.Entities;
using Logixion.Domain.IRepository;

namespace Logixion.Domain.Repository
{
    public class EmployeeRepository : GenericRepository<Employee, int>, IEmployeeRepository
    {
        public EmployeeRepository(LogixionDbContext logixionDb) : base(logixionDb)
        {
        }
        
    }
}

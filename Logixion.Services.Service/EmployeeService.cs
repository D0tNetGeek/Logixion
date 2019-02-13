using Logixion.Domain.IRepository;
using Logixion.Services.IService;
using Logixion.Services.Models;
namespace Logixion.Services.Service
{
    public class EmployeeService : GenericService<Employee, Logixion.Domain.Entities.Employee, int>, IEmployeeService
    {
        public EmployeeService(IEmployeeRepository employeeRepository) : base(employeeRepository)
        {
        }
    }
}

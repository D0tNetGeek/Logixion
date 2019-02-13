using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Logixion.Services.Models;
using System.Web.Mvc;
using Logixion.Services.IService;

namespace Logixion.UI.Web.Controllers
{
    public class EmployeeController : BaseController<Employee,Logixion.Domain.Entities.Employee,int>
    {
       private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService) : base(employeeService)
        {
            _employeeService = employeeService;
        }
          
    }
}
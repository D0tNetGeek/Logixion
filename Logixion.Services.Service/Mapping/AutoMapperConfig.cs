using Logixion.Domain.Entities;
using Logixion.Services.IService;
using System.Collections.Generic;

namespace Logixion.Services.Service
{
    public  class LogixionMapper:ILogixionMapper
    {
        public  void Load()
        {
            AutoMapper.Mapper.Initialize(cfg => {
                cfg.CreateMap<UserDetail, Logixion.Services.Models.UserDetail>();
                cfg.CreateMap<Employee, Logixion.Services.Models.Employee>();
                cfg.CreateMap<Logixion.Services.Models.UserDetail,UserDetail>();
                cfg.CreateMap<Logixion.Services.Models.Employee,Employee>();
            });
        }
    }
}

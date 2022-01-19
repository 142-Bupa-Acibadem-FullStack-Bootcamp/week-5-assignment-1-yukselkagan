using Northwind.Bll.Base;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Dal.Abstract;

namespace Northwind.Bll
{
    public class EmployeeTerritoryManager : BllBase<EmployeeTerritory, DtoEmployeeTerritory>, IEmployeeTerritoryService
    {
        private readonly IEmployeeTerritoryRepository employeeTerritoryRepository;

        public EmployeeTerritoryManager(IServiceProvider service) : base(service)
        {
            employeeTerritoryRepository = service.GetService<IEmployeeTerritoryRepository>();
        }

    }
}

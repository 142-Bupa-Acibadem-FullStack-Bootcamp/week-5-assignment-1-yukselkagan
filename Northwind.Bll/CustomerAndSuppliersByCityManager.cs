using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Interface;

namespace Northwind.Bll
{
    public class CustomerAndSuppliersByCityManager : BllBase<CustomerAndSuppliersByCity, DtoCustomerAndSuppliersByCity>, ICustomerAndSuppliersByCityService
    {
        private readonly ICustomerAndSuppliersByCityRepository customerAndSuppliersByCityRepository;

        public CustomerAndSuppliersByCityManager(IServiceProvider service) : base(service)
        {
            customerAndSuppliersByCityRepository = service.GetService<ICustomerAndSuppliersByCityRepository>();

        }




    }
}

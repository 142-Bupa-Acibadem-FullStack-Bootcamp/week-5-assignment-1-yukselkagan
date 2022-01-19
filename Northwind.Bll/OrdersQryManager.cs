using Northwind.Bll.Base;
using Northwind.Dal.Abstract;
using Northwind.Entity.Dto;
using Northwind.Entity.Models;
using Northwind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Bll
{
    public class OrdersQryManager : BllBase<OrdersQry, DtoOrdersQry>, IOrdersQryService
    {
        private readonly IOrdersQryRepository ordersQryRepository;
        public OrdersQryManager(IServiceProvider service) : base(service)
        {
            ordersQryRepository = service.GetService<IOrdersQryRepository>();
        }
    }
}

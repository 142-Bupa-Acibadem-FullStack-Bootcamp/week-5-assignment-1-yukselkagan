﻿using Northwind.Bll.Base;
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
    public class CurrentProductListManager : BllBase<CurrentProductList, DtoCurrentProductList>, ICurrentProductListService
    {
        private readonly ICurrentProductListRepository currentProductListRepository;

        public CurrentProductListManager(IServiceProvider service) : base(service)
        {
            currentProductListRepository = service.GetService<ICurrentProductListRepository>();
        }

        public IQueryable CurrentProductListReport()
        {
            return currentProductListRepository.CurrentProductListReport();
        }
    }
}

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
    public class ProductsByCategoryManager : BllBase<ProductsByCategory, DtoProductsByCategory>, IProductsByCategoryService
    {
        private readonly IProductsByCategoryRepository productsByCategoryRepository;
        public ProductsByCategoryManager(IServiceProvider service) : base(service)
        {

            productsByCategoryRepository = service.GetService<IProductsByCategoryRepository>();
            
        }
    }
}

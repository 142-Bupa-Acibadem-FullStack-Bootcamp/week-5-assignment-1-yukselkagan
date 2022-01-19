using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Concrete.Entityframework.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Northwind.Dal.Abstract;
using Northwind.Entity.Models;

namespace Northwind.Dal.Seed
{
    public class UserSeed
    {
        private readonly IUserRepository userRepository;

        public UserSeed(IServiceProvider service)
        {
            userRepository = service.GetService<IUserRepository>();
        }

        public void SeedUser()
        {


            User newUser = new User
            {
                UserName = "khn",
                UserLastName = "khn",
                UserCode = "khn",
                Password = "pass"
            };


            userRepository.SeedUser(newUser);



        }


    }
}

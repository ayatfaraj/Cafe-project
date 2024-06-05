using cafe.domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe.persistance
{
    public class cafecontext :DbContext
    {
      public DbSet<User> MyProperty { get; set; }
        public DbSet<Order> Orders { get; set; }



    }
}

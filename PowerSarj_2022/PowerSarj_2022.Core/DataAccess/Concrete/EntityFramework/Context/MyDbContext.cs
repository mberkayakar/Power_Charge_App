using Microsoft.EntityFrameworkCore;
using PowerSarj_2022.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace PowerSarj_2022.Core.DataAccess.Concrete.EntityFramework.ContextFolder.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Fill> MyProperty { get; set; }

    }
}

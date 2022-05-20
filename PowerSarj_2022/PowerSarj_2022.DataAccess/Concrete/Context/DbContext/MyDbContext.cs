﻿using Microsoft.EntityFrameworkCore;
using PowerSarj_2022.DataAccess.Concrete.Context.Configuration;
using PowerSarj_2022.DataAccess.Concrete.Context.DbEntities;
using PowerSarj_2022.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerSarj_2022.DataAccess.Concrete.Context.EfContext
{
    public class MyDbContext : DbContext 
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {


        }
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new DevicesConfiguration());
            modelBuilder.ApplyConfiguration(new FillsConfiguration());
            modelBuilder.ApplyConfiguration(new OperationsConfiguration());
            modelBuilder.ApplyConfiguration(new UsersConfiguration());

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Fill> Fills { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<User> Users { get; set; }



    }
}

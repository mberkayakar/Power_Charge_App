using Microsoft.EntityFrameworkCore;
using PowerSarj_2022.DataAccess.Concrete.Context.Configuration;
using PowerSarj_2022.Entities.Concrete;

namespace PowerSarj_2022.DataAccess.Concrete.Context.EfContext
{
    public class MyDbContext : DbContext 
    {


        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
           
        }

        #region MyRegion
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{

        //    //options.UseLazyLoadingProxies();
        //}

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfiguration());
            modelBuilder.ApplyConfiguration(new DevicesConfiguration());
            modelBuilder.ApplyConfiguration(new FillsConfiguration());
            modelBuilder.ApplyConfiguration(new OperationsConfiguration());
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new AllowedSitesConfiguration());



            
            modelBuilder.Entity<User>().HasMany(x => x.devices).WithMany(x => x.User);
                
                
                //.HasForeignKey(x => x.userid).OnDelete(DeleteBehavior.Cascade);
            
          

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Fill> Fills { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<User> Users { get; set; }



    }
}

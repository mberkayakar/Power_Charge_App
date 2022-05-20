using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PowerSarj_2022.Entities.Concrete;
using System;

namespace PowerSarj_2022.DataAccess.Concrete.Context.Configuration
{
    public class AdminConfiguration : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(c => c.Id).HasName("AdminId");
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.Id).HasColumnName("CategoryID");
            builder.Property(c => c.Name).HasColumnName("CategoryName");
        }
    }
}

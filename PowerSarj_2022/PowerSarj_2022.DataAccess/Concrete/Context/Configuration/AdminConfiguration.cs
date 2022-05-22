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
            builder.Property(c => c.Id).HasColumnName("AdminId");
            builder.Property(c => c.Name).HasColumnName("AdminName");



            builder.HasData(
                new Admin
                {
                    Id = 1,
                    Name = "Recep",
                    Surname = "Cengiz",
                },

                new Admin
                {
                    Id = 2,
                    Name = "Ahmet",
                    Surname = "Yılmaz",
                }

                );



        }
    }
}

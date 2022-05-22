using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PowerSarj_2022.Entities.Concrete;

namespace PowerSarj_2022.DataAccess.Concrete.Context.EfContext
{
    public class DevicesConfiguration : IEntityTypeConfiguration<Device>
    {
        public void Configure(EntityTypeBuilder<Device> builder)
        {
            builder.HasKey(c => c.Id).HasName("DeviceId");

            builder.HasData(
                new Devices
                {

                },
 
        }
    }
}
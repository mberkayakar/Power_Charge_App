using Microsoft.EntityFrameworkCore;
using PowerSarj_2022.Business.Concrete;
using PowerSarj_2022.Entities.Concrete;
using System.Linq;

namespace PowerSarj_2022.DataAccess.Abstract
{
    public class DeviceManager : GenericManager<Device>, IDeviceService
    {


        private readonly IDeviceRepository _deviceService;
        private readonly DbContext _dbContext;
        public DeviceManager(IDeviceRepository _deviceService , DbContext db) : base(_deviceService)
        {
            _dbContext = db;


        }


        public void deneme()
        {
            var model = _dbContext.Set<Device>().Select(x => x.devicename);


            System.Console.WriteLine("asdşasidşalsdişalsldş");
        }


    }
}

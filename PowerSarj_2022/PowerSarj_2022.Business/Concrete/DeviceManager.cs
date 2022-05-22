using PowerSarj_2022.Business.Concrete;
using PowerSarj_2022.Entities.Concrete;

namespace PowerSarj_2022.DataAccess.Abstract
{
    public class DeviceManager : GenericManager<Device>, IDeviceService
    {


        //private readonly IDeviceRepository _deviceService;
        public DeviceManager(IDeviceRepository _deviceService) : base(_deviceService)
        {



        }



    }
}

using PowerSarj_2022.Business.Concrete;
using PowerSarj_2022.Entities.Concrete;

namespace PowerSarj_2022.DataAccess.Abstract
{
    public class AdminManager : GenericManager<Admin>, IAdminService
    {

        //private IAdminRepository adminrepository;
        public AdminManager(IAdminRepository genericRepository) : base(genericRepository)
        {
            //adminrepository = genericRepository;
        }




    }
}

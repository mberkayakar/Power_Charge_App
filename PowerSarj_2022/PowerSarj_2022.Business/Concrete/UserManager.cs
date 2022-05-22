using PowerSarj_2022.Business.Concrete;
using PowerSarj_2022.Core.DataAccess.Abstract;
using PowerSarj_2022.Entities.Concrete;

namespace PowerSarj_2022.DataAccess.Abstract
{

    public class UserManager : GenericManager<User>, IUserService
    {
        public UserManager(IUserRepository genericRepository) : base(genericRepository)
        {

        }
    }
}

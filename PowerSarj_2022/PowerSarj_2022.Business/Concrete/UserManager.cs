using PowerSarj_2022.Business.Concrete;
using PowerSarj_2022.Core.DataAccess.Abstract;
using PowerSarj_2022.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PowerSarj_2022.DataAccess.Abstract
{

    public class UserManager : GenericManager<User>, IUserService
    {

        private readonly IUserRepository _userService;

        public UserManager(IUserRepository genericRepository) : base(genericRepository)
        {

            _userService = genericRepository;

        }

        public IEnumerable<User> GetAllUserİnformation(Expression<Func<User, bool>> filter, params Expression<Func<User, object>>[] children )
        {
            return _userService.GetAllUserİnformation(filter,children);
        }
    }
}

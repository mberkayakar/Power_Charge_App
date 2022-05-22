using PowerSarj_2022.Business.Abstract;
using PowerSarj_2022.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PowerSarj_2022.DataAccess.Abstract
{
    public interface IUserService: IGenericService<User>
    {

        IEnumerable<User> GetAllUserİnformation(Expression<Func<User, bool>> filter, params Expression<Func<User, object>>[] children );

    }
}

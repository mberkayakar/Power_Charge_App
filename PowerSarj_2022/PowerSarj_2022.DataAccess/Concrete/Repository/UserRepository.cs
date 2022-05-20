﻿using Microsoft.EntityFrameworkCore;
using PowerSarj_2022.Core.DataAccess.Concrete;
using PowerSarj_2022.DataAccess.Abstract;
using PowerSarj_2022.Entities.Concrete;

namespace PowerSarj_2022.DataAccess.Concrete.Repository
{

    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(DbContext db) : base(db)
        {
        }
    }
}

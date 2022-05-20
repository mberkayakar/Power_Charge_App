using Microsoft.EntityFrameworkCore;
using PowerSarj_2022.Core.DataAccess.Concrete;
using PowerSarj_2022.DataAccess.Abstract;
using PowerSarj_2022.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerSarj_2022.DataAccess.Concrete.Repository
{

    public class AdminRepository : GenericRepository<Admin>, IAdminRepository
    {

        public AdminRepository(DbContext db) : base(db)
        {

        }
    }
}

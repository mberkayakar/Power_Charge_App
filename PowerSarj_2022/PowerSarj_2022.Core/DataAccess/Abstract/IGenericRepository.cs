﻿using PowerSarj_2022.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PowerSarj_2022.Core.DataAccess.Abstract
{
    public interface IGenericRepository<T> where T : class , IEntity , new()
    {
        void Add(T entity); 
        void Update(T entity);
        void Delete(T entity);
        T GetObject( Expression<Func<T,bool>> where = null);
        IEnumerable<T> GetAll(Expression<Func<T, bool>> where = null);
    }
}

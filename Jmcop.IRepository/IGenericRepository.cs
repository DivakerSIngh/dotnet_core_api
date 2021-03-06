﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Jmcop.IGenericRepository
{
    public interface IGenericRepository<T> where T : class
    {

        T GetById(int id);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
        IQueryable<T> List();
        IEnumerable<T> List(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       
    }
}

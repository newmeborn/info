﻿using System.Linq.Expressions;

namespace info.Repository.IRepository
{
    public interface IRepository<T> where T : class  
    {
        // T : infomed
        T GetFirstOrDefault(Expression<Func<T, bool>> filter);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entity);
    }
}

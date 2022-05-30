using info.Models;
using info.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq.Expressions;

namespace info.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly infoDbContext _context;
        internal DbSet<T> dbSet;

        
        public Repository(infoDbContext context)
        {
            _context = context;
            this.dbSet = _context.Set<T>();
        }
        public void Add(T entity) 
        {
           dbSet.Add(entity);
           
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList(); // since we dont have any other conditions here 
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;

            query = query.Where(filter);

            return query.FirstOrDefault();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }
    }
}

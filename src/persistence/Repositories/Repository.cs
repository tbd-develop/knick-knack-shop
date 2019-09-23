using System.Linq;
using Microsoft.EntityFrameworkCore;
using persistence.Contracts;

namespace persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public void Insert(T @object)
        {
            _context.Set<T>().Add(@object);

            _context.SaveChanges();
        }

        public void Delete(T @object)
        {
            _context.Set<T>().Remove(@object);

            _context.SaveChanges();
        }

        public void Update(T @object)
        {
            _context.Set<T>().Update(@object);

            _context.SaveChanges();
        }

        public IQueryable<T> Get()
        {
            return _context.Set<T>();
        }
    }
}
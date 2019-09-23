using System.Linq;

namespace persistence.Contracts
{
    public interface IRepository
    { }

    public interface IRepository<T> : IRepository
        where T : class
    {
        void Insert(T @object);
        void Delete(T @object);
        void Update(T @object);
    }
}
namespace persistence.Contracts
{
    public interface IRepository
    { }

    public interface IRepository<in T> : IRepository
        where T : class
    {
        void Insert(T @object);
        void Delete(T @object);
        void Update(T @object);
    }
}
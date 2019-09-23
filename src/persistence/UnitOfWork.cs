using models;
using persistence.Contracts;
using persistence.DataContext;
using persistence.Repositories;

namespace persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(ApplicationContext context)
        {
            KnickKnacks = new Repository<KnickKnack>(context);
        }

        public IRepository<KnickKnack> KnickKnacks { get; }
    }
}
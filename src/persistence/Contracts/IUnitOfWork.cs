using models;

namespace persistence.Contracts
{
    public interface IUnitOfWork
    {
        IRepository<KnickKnack> KnickKnacks { get; }
    }
}
using models;
using persistence.Repositories;

namespace persistence.Contracts
{
    public interface IUnitOfWork
    {
        IKnickKnackRepository KnickKnacks { get; }
    }
}
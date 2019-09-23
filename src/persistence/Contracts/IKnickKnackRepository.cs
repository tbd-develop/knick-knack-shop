using System.Collections.Generic;
using models;
using viewmodels;

namespace persistence.Contracts
{
    public interface IKnickKnackRepository : IRepository<KnickKnack>
    {
        IEnumerable<KnickKnackViewModel> GetAllKnickKnacksForName(string name);
    }
}
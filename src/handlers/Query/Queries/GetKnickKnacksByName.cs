using System.Collections;
using System.Collections.Generic;
using MediatR;
using viewmodels;

namespace handlers.Query.Queries
{
    public class GetKnickKnackByName : IRequest<IEnumerable<KnickKnackViewModel>>
    {
        public string Name { get; set; }
    }
}
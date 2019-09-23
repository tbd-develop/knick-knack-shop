using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using handlers.Query.Queries;
using MediatR;
using persistence.Contracts;
using viewmodels;

namespace handlers.Query.Handlers
{
    public class GetKnickKnackByNameHandler : IRequestHandler<GetKnickKnackByName, IEnumerable<KnickKnackViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetKnickKnackByNameHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<KnickKnackViewModel>> Handle(GetKnickKnackByName request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_unitOfWork.KnickKnacks.GetAllKnickKnacksForName(request.Name));
        }
    }
}
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using handlers.Command.Commands;
using MediatR;
using models;
using persistence.Contracts;

namespace handlers.Command.Handlers
{
    public class RegisterNewKnickKnacksHandler : IRequestHandler<RegisterNewKnickKnack>
    {
        private readonly IUnitOfWork _unitOfWork;

        public RegisterNewKnickKnacksHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Unit> Handle(RegisterNewKnickKnack request, CancellationToken cancellationToken)
        {
            _unitOfWork.KnickKnacks.Insert(new KnickKnack()
            {
                Name = request.Name,
                PricePaid = request.PricePaid,
                Valuation = request.Valuation
            });

            return await Task.FromResult(Unit.Value);
        }
    }
}
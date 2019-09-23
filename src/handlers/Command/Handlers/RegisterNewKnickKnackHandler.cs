using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using handlers.Command.Commands;
using MediatR;

namespace handlers.Command.Handlers
{
    public class RegisterNewKnickKnacksHandler : IRequestHandler<RegisterNewKnickKnack>
    {
        public async Task<Unit> Handle(RegisterNewKnickKnack request, CancellationToken cancellationToken)
        {
            Debugger.Break();

            return await Task.FromResult(Unit.Value);
        }
    }
}
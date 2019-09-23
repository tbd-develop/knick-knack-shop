using MediatR;

namespace handlers.Command.Commands
{
    public class RegisterNewKnickKnack : IRequest
    {
        public string Name { get; set; }
        public decimal PricePaid { get; set; }
        public decimal Valuation { get; set; }
    }
}
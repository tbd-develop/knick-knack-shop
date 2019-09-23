using api.Models;
using handlers.Command.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("register")]
    public class RegistrationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RegistrationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost, Route("knick-knack")]
        public void RegisterNewKnickKnack(RegisterNewKnickKnackInputModel model)
        {
            _mediator.Send(new RegisterNewKnickKnack
            {
                Name = model.Name,
                PricePaid = model.PricePaid,
                Valuation = model.Valuation
            });
        }
    }
}
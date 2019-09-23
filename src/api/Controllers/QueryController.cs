using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using handlers.Query.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using viewmodels;

namespace api.Controllers
{
    [ApiController]
    [Route("get")]
    public class QueryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public QueryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet, Route("knick-knacks-by-name")]
        public async Task<IEnumerable<KnickKnackViewModel>> GetKnickKnacksByName(string name)
        {
            return await _mediator.Send(new GetKnickKnackByName() { Name = name });
        }
    }
}
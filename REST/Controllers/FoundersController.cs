using MediatR;
using Microsoft.AspNetCore.Mvc;
using TeledocWebApplication.Core;
using TeledocWebApplication.Core.Model;
using TeledocWebApplication.REST.Commands.CreateFounder;
using TeledocWebApplication.REST.Commands.DeleteFounder;
using TeledocWebApplication.REST.Commands.EditFounder;
using TeledocWebApplication.REST.Queries.GetFounder;
using TeledocWebApplication.REST.Queries.GetFoundersList;

namespace TeledocWebApplication.REST.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class FounderController : ControllerBase
    {
        private TeledocDbContext _context;
        private IMediator _mediator;
        public FounderController(TeledocDbContext context, IMediator mediator) =>
             (_context, _mediator) = (context, mediator);

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateFounderCommand request)
        {
            var client_id = await _mediator.Send(request);
            return Ok(client_id);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Founder>> Get(Guid id)
        {
            var query = new GetFounderQuery()
            {
                id = id
            };
            var answ = await _mediator.Send(query);
            return Ok(answ);
        }
        [HttpGet]
        public async Task<ActionResult<List<Founder>>> GetAll()
        {
            var answ = await _mediator.Send(new GetFoundersListQuery());
            return Ok(answ);
        }
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] EditFounderCommand request)
        {
            var answ = await _mediator.Send(request);
            return Ok(answ);

        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var answ = await _mediator.Send(new DeleteFounderCommand() { id = id });
            return Ok(answ);
        }
    }
}

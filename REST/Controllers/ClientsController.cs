using MediatR;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Security.Cryptography;
using TeledocWebApplication.Core;
using TeledocWebApplication.Core.Model;
using TeledocWebApplication.REST.Commands.CreateClient;
using TeledocWebApplication.REST.Commands.DeleteClient;
using TeledocWebApplication.REST.Commands.EditClient;
using TeledocWebApplication.REST.Queries.GetClient;
using TeledocWebApplication.REST.Queries.GetClientsListQuery;

namespace TeledocWebApplication.REST.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ClientsController : ControllerBase
    {
        private TeledocDbContext _context;
        private IMediator _mediator;
        public ClientsController(TeledocDbContext context, IMediator mediator) =>
             (_context, _mediator) = (context, mediator);

        [HttpPost]
        public async Task<ActionResult<Guid>> Create([FromBody] CreateClientCommand request)
        {
            var client_id = await _mediator.Send(request);
            return Ok(client_id);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> Get(Guid id)
        {
            var query = new GetClientQuery()
            {
                id = id
            };
            var answ = await _mediator.Send(query);
            return Ok(answ);
        }
        [HttpGet]
        public async Task<ActionResult<List<Client>>> GetAll()
        {
            var answ = await _mediator.Send(new GetClientsListQuery());
            return Ok(answ);
        }
        [HttpPut]
        public async Task<ActionResult> Put([FromBody]EditClientCommand request)
        {
            var answ = await _mediator.Send(request);
            return Ok(answ);
            
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var answ = await _mediator.Send(new DeleteClientCommand() { id = id});
            return Ok(answ);
        }
    }
}

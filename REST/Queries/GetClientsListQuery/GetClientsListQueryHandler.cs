using MediatR;
using Microsoft.EntityFrameworkCore;
using TeledocWebApplication.Core;
using TeledocWebApplication.Core.Model;
using TeledocWebApplication.REST.Queries.ViewModels;

namespace TeledocWebApplication.REST.Queries.GetClientsListQuery
{
    public class GetClientListQueryHandler
        : IRequestHandler<GetClientsListQuery, ClientsListViewModel>
    {
        private readonly TeledocDbContext _context;
        public GetClientListQueryHandler( TeledocDbContext context) => _context = context;
        public async Task<ClientsListViewModel> Handle(GetClientsListQuery request, 
            CancellationToken cancellationToken)
        {
            var clientQuery = await _context.clients.Select(c => new ClientViewModel()
            {
                id = c.id,
                inn = c.inn,
                title = c.title,
                creationDate = c.creationDate,
                editDate = c.editDate
            }).ToListAsync(cancellationToken);

            return new ClientsListViewModel() { list = clientQuery };
        }
    }
}

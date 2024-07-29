using MediatR;
using TeledocWebApplication.Core.Model;
using TeledocWebApplication.Core;
using Microsoft.EntityFrameworkCore;
using TeledocWebApplication.REST.Queries.ViewModels;

namespace TeledocWebApplication.REST.Queries.GetClient
{
    public class GetClientQueryHandler
        : IRequestHandler<GetClientQuery, ClientViewModel>
    {
        private readonly TeledocDbContext _context;
        public GetClientQueryHandler(TeledocDbContext context) => _context = context;
        public async Task<ClientViewModel> Handle(GetClientQuery request,
            CancellationToken cancellationToken)
        {
            var clientQuery = await _context.clients
                .Where(c => c.id == request.id)
                .Select(c => new ClientViewModel() { 
                    id = c.id,
                    inn = c.inn,
                    title = c.title,
                    creationDate = c.creationDate,
                    editDate = c.editDate
                }).FirstOrDefaultAsync();

            if (clientQuery == null) 
            {
                throw new Exception("Entity not found");
            }
            return clientQuery;
        }
    }
}

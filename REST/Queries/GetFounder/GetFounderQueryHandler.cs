using MediatR;
using TeledocWebApplication.Core.Model;
using TeledocWebApplication.Core;
using TeledocWebApplication.REST.Queries.GetFounder;
using Microsoft.EntityFrameworkCore;
using TeledocWebApplication.REST.Queries.ViewModels;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace TeledocWebApplication.REST.Queries.GetFounder
{
    public class GetFounderQueryHandler
        : IRequestHandler<GetFounderQuery, FounderViewModel>
    {
        private readonly TeledocDbContext _context;
        public GetFounderQueryHandler(TeledocDbContext context) => _context = context;
        public async Task<FounderViewModel> Handle(GetFounderQuery request,
            CancellationToken cancellationToken)
        {
            var founderQuery = await _context.founders.Where(f => f.id == request.id)
                .Select( f => new FounderViewModel()
                {
                    id = f.id,
                    name = f.name,
                    surname = f.surname,
                    middlename = f.middlename,
                    editDate = f.editDate,
                    creationDate = f.creationDate,
                    inn = f.inn,
                    clientId = f.clientId
                })
                .FirstOrDefaultAsync();

            if (founderQuery == null)
            {
                throw new Exception("Entity not found");
            }
            return founderQuery;
        }
    }
}

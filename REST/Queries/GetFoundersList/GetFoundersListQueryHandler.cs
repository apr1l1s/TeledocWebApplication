using MediatR;
using TeledocWebApplication.Core.Model;
using TeledocWebApplication.Core;
using Microsoft.EntityFrameworkCore;
using TeledocWebApplication.REST.Queries.ViewModels;

namespace TeledocWebApplication.REST.Queries.GetFoundersList
{
    public class GetFoundersListQueryHandler
        : IRequestHandler<GetFoundersListQuery, FoundersListViewModel>
    {
        private readonly TeledocDbContext _context;
        public GetFoundersListQueryHandler(TeledocDbContext context) => _context = context;
        public async Task<FoundersListViewModel> Handle(GetFoundersListQuery request,
            CancellationToken cancellationToken)
        {
            var founderQuery = await _context.founders.
                Select(f => new FounderViewModel()
                {
                    id = f.id,
                    name = f.name,
                    surname = f.surname,
                    middlename = f.middlename,
                    editDate = f.editDate,
                    creationDate = f.creationDate,
                    inn = f.inn,
                    clientId = f.clientId
                }).ToListAsync(cancellationToken);

            return new FoundersListViewModel() { list = founderQuery };
        }
    }
}

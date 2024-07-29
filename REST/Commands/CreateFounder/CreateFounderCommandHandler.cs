using MediatR;
using TeledocWebApplication.Core.Model;
using TeledocWebApplication.Core;
using TeledocWebApplication.REST.Commands.CreateClient;

namespace TeledocWebApplication.REST.Commands.CreateFounder
{
    public class CreateFounderCommandHandler
        : IRequestHandler<CreateFounderCommand, Guid>
    {
        private readonly TeledocDbContext _context;
        public CreateFounderCommandHandler(TeledocDbContext context) => _context = context;
        public async Task<Guid> Handle(CreateFounderCommand request, CancellationToken cancellationToken)
        {
            var founder = new Founder
            {
                id = Guid.NewGuid(),
                inn = request.inn,
                surname = request.surname,
                name = request.name,
                middlename = request.middlename,
                creationDate = DateTime.Now,
                editDate = null,
                clientId = request.clientId
            };
            await _context.founders.AddAsync(founder, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return founder.id;
        }
    }
}

using MediatR;
using TeledocWebApplication.Core;
using TeledocWebApplication.Core.Model;

namespace TeledocWebApplication.REST.Commands.CreateClient
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, Guid>
    {
        private readonly TeledocDbContext _context;
        public CreateClientCommandHandler(TeledocDbContext context) => _context = context;
        public async Task<Guid> Handle(CreateClientCommand request, CancellationToken cancellationToken)
        {
            var client = new Client
            {
                id = Guid.NewGuid(),
                inn = request.inn,
                title = request.title,
                statusType = request.statusType,
                creationDate = DateTime.Now,
                editDate = null
            };
            await _context.clients.AddAsync(client, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return client.id;
        }
    }
}

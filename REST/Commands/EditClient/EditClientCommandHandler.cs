using MediatR;
using Microsoft.EntityFrameworkCore;
using TeledocWebApplication.Core;

namespace TeledocWebApplication.REST.Commands.EditClient
{
    public class EditClientCommandHandler
        : IRequestHandler<EditClientCommand, Unit>
    {
        public EditClientCommandHandler(TeledocDbContext context) => _context = context;
        private readonly TeledocDbContext _context;
        public async Task<Unit> Handle(EditClientCommand request, CancellationToken cancellationToken)
        {
            var entity = 
                await _context.clients.FirstOrDefaultAsync(client => 
                client.id == request.id, cancellationToken);
            if (entity == null)
            {
                throw new Exception("Entity not found");
            }
            entity.title = request.title;
            entity.inn = request.inn;
            entity.statusType = request.statusType;
            entity.editDate = DateTime.Now;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

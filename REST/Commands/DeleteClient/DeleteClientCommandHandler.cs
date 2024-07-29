using MediatR;
using TeledocWebApplication.Core;

namespace TeledocWebApplication.REST.Commands.DeleteClient
{
    public class DeleteClientCommandHandler
        : IRequestHandler<DeleteClientCommand, Unit>
    {
        private readonly TeledocDbContext _context;
        public DeleteClientCommandHandler(TeledocDbContext context) => _context = context;

        public async Task<Unit> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.clients.FindAsync(new object[] { request.id }, cancellationToken);

            if (entity == null || entity.id != request.id)
            {
                throw new Exception("Entity not found");
            }
            _context.clients.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}

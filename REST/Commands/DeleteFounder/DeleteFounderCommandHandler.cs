using MediatR;
using TeledocWebApplication.Core;
using TeledocWebApplication.REST.Commands.DeleteClient;

namespace TeledocWebApplication.REST.Commands.DeleteFounder
{
    public class DeleteFounderCommandHandler
        : IRequestHandler<DeleteFounderCommand, Unit>
    {
        private readonly TeledocDbContext _context;
        public DeleteFounderCommandHandler(TeledocDbContext context) => _context = context;

        public async Task<Unit> Handle(DeleteFounderCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.founders.FindAsync(new object[] { request.id }, cancellationToken);

            if (entity == null)
            {
                throw new Exception("Entity not found");
            }
            _context.founders.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}

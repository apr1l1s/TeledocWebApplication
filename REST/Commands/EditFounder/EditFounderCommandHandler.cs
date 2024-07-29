using MediatR;
using Microsoft.EntityFrameworkCore;
using TeledocWebApplication.Core;

namespace TeledocWebApplication.REST.Commands.EditFounder
{
    public class EditFounderCommandHandler
        : IRequestHandler<EditFounderCommand, Unit>
    {
        public EditFounderCommandHandler(TeledocDbContext context) => _context = context;
        private readonly TeledocDbContext _context;
        public async Task<Unit> Handle(EditFounderCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.founders.FirstOrDefaultAsync(founder =>
                founder.id == request.id, cancellationToken);
            if (entity == null)
            {
                throw new Exception("Entity not found");
            }
            entity.surname = request.surname;
            entity.name = request.name;
            entity.middlename = request.middlename;
            entity.inn = request.inn;
            entity.clientId = request.clientId;
            entity.editDate = DateTime.Now;

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}

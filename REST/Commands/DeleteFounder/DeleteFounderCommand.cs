using MediatR;

namespace TeledocWebApplication.REST.Commands.DeleteFounder
{
    public class DeleteFounderCommand
    : IRequest<Unit>
    {
        public Guid id { get; set; }
    }
}

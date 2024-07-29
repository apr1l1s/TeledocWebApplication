using MediatR;

namespace TeledocWebApplication.REST.Commands.DeleteClient
{
    public class DeleteClientCommand
        : IRequest<Unit>
    {
        public Guid id { get; set; }
    }
}

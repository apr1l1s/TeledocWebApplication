using MediatR;

namespace TeledocWebApplication.REST.Commands.CreateClient
{
    public class CreateClientCommand : IRequest<Guid>
    {
        public string inn { get; set; } = string.Empty;
        public string title { get; set; } = string.Empty;
        public bool statusType { get; set; } //ип 1 юр 0
    }
}

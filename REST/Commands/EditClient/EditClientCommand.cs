using MediatR;

namespace TeledocWebApplication.REST.Commands.EditClient
{
    public class EditClientCommand
        : IRequest<Unit>
    {
        public Guid id { get; set; }
        public string inn { get; set; }
        public string title { get; set; }
        public bool statusType { get; set; } //ип 1 юр 0
    }
}

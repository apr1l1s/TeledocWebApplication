using MediatR;

namespace TeledocWebApplication.REST.Commands.EditFounder
{
    public class EditFounderCommand
        : IRequest<Unit>
    {
        public Guid id { get; set; }
        public string inn { get; set; } = string.Empty;
        public string surname { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public string middlename { get; set; } = string.Empty;
        //Внешний ключ
        public Guid? clientId { get; set; }
    }
}

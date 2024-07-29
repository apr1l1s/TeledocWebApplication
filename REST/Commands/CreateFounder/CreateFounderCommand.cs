using MediatR;
using TeledocWebApplication.Core.Model;

namespace TeledocWebApplication.REST.Commands.CreateFounder
{
    public class CreateFounderCommand : IRequest<Guid>
    {
        public string inn { get; set; } = string.Empty;
        public string surname { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public string middlename { get; set; } = string.Empty;
        //Внешний ключ
        public Guid? clientId { get; set; }
    }
}

using FluentValidation;

namespace TeledocWebApplication.REST.Commands.DeleteClient
{
    public class DeleteClientCommandValidator
        : AbstractValidator<DeleteClientCommand>
    {
        public DeleteClientCommandValidator()
        {
            RuleFor(d => d.id).NotEqual(Guid.Empty);
        }
    }
}

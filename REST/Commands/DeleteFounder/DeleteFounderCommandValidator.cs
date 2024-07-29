using FluentValidation;
using TeledocWebApplication.REST.Commands.DeleteClient;

namespace TeledocWebApplication.REST.Commands.DeleteFounder
{
    public class DeleteFounderCommandValidator
        : AbstractValidator<DeleteFounderCommand>
    {
        public DeleteFounderCommandValidator()
        {
            RuleFor(d => d.id).NotEqual(Guid.Empty);
        }
    }
}

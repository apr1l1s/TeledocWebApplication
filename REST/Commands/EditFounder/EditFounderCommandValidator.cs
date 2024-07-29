using FluentValidation;

namespace TeledocWebApplication.REST.Commands.EditFounder
{
    public class EditFounderCommandValidator
        : AbstractValidator<EditFounderCommand>
    {
        public EditFounderCommandValidator()
        {
            RuleFor(e => e.id).NotEqual(Guid.Empty);
            RuleFor(e => e.surname).NotEmpty().MaximumLength(100);
            RuleFor(e => e.name).NotEmpty().MaximumLength(100);
            RuleFor(e => e.middlename).NotEmpty().MaximumLength(100);
            RuleFor(e => e.inn).NotEmpty().MinimumLength(12).MaximumLength(12);
        }
    }
}

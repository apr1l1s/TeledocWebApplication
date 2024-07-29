using FluentValidation;

namespace TeledocWebApplication.REST.Commands.CreateFounder
{
    public class CreateFounderCommandValidator
        : AbstractValidator<CreateFounderCommand>
    {
        public CreateFounderCommandValidator()
        {
            RuleFor(createFounderCommand =>
                createFounderCommand.surname).NotEmpty().MaximumLength(100);
            RuleFor(createFounderCommand =>
                createFounderCommand.name).NotEmpty().MaximumLength(100);
            RuleFor(createFounderCommand =>
                createFounderCommand.middlename).NotEmpty().MaximumLength(100);
            RuleFor(createClientCommand =>
                createClientCommand.inn).NotEmpty().MinimumLength(12).MaximumLength(12);
        }
    }
}

using FluentValidation;

namespace TeledocWebApplication.REST.Commands.CreateClient
{
    public class CreateClientCommandValidator
        : AbstractValidator<CreateClientCommand>
    {
        public CreateClientCommandValidator() 
        {
            RuleFor(createClientCommand =>
                createClientCommand.title).NotEmpty().MaximumLength(100);
            RuleFor(createClientCommand =>
                createClientCommand.inn).NotEmpty().MinimumLength(12).MaximumLength(12);
        }
    }
}

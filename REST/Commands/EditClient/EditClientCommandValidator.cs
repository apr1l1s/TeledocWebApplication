using FluentValidation;

namespace TeledocWebApplication.REST.Commands.EditClient
{
    public class EditClientCommandValidator
        : AbstractValidator<EditClientCommand>
    {
        public EditClientCommandValidator()
        {
            RuleFor(editClientCommand =>
                editClientCommand.id).NotEqual(Guid.Empty);
            RuleFor(createClientCommand =>
                createClientCommand.title).NotEmpty().MaximumLength(100);
            RuleFor(createClientCommand =>
                createClientCommand.inn).NotEmpty().MinimumLength(12).MaximumLength(12);
        }
    }
}

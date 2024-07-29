using FluentValidation;

namespace TeledocWebApplication.REST.Queries.GetClient
{
    public class GetClientQueryValidator
        : AbstractValidator<GetClientQuery>
    {
        public GetClientQueryValidator()
        {
            RuleFor(d => d.id).NotEqual(Guid.Empty);
        }
    }
}

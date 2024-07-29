using MediatR;
using TeledocWebApplication.Core.Model;
using TeledocWebApplication.REST.Queries.ViewModels;

namespace TeledocWebApplication.REST.Queries.GetFounder
{
    public class GetFounderQuery : IRequest<FounderViewModel>
    {
        public Guid id { get; set; }
    }
}

using MediatR;
using TeledocWebApplication.Core.Model;
using TeledocWebApplication.REST.Queries.ViewModels;

namespace TeledocWebApplication.REST.Queries.GetFoundersList
{
    public class GetFoundersListQuery
        : IRequest<FoundersListViewModel>
    {
        public List<Founder> founders { get; set; }
    }
}

using MediatR;
using TeledocWebApplication.Core.Model;
using TeledocWebApplication.REST.Queries.ViewModels;

namespace TeledocWebApplication.REST.Queries.GetClientsListQuery
{
    public class GetClientsListQuery : IRequest<ClientsListViewModel> { }
}

using MediatR;
using TeledocWebApplication.Core.Model;
using TeledocWebApplication.REST.Queries.ViewModels;

namespace TeledocWebApplication.REST.Queries.GetClient
{
    public class GetClientQuery : IRequest<ClientViewModel> 
    {
        public Guid id;
    }

}

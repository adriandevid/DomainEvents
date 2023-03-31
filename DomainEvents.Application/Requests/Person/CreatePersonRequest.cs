using DomainEvents.Application.Responses.Response;
using MediatR;

namespace DomainEvents.Application.Requests.Person
{
    public class CreatePersonRequest : IRequest<ApiResponse>
    {
        public string Name { get; set; }
    }
}

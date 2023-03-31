
using DomainEvents.Application.Requests.Person;
using DomainEvents.Application.Responses.Response;
using DomainEvents.Domain.Entities.Person.Events;
using MediatR;

namespace DomainEvents.Application.CommandsHandlers.Person
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonRequest, ApiResponse>
    {
        public async Task<ApiResponse> Handle(CreatePersonRequest request, CancellationToken cancellationToken)
        {
            var person = new Domain.Entities.Person.Person(request.Name);
            var eventCreatePerson = new CreatePersonEvent();

            person.StartedCreatePerson();

            return await Task.Run(() => new ApiResponse { IsValid = true});
        }
    }
}

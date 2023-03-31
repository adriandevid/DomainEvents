using DomainEvents.Application.Requests.Request;
using DomainEvents.Application.Requests.User;
using DomainEvents.Application.Responses.Response;
using MediatR;

namespace DomainEvents.Application.CommandsHandlers.User
{
    public class CreateUserCommandHandler : BaseRequestHandler, IRequestHandler<CreateUserRequest, ApiResponse>
    {
        private readonly IPublisher _publisher;
        public CreateUserCommandHandler(IPublisher publisher) : base(publisher)
        {
            _publisher= publisher;
        }

        public async Task<ApiResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var user = new Domain.Entities.User.User("user", "12345");
            return await saveChanges(user.DomainEvents.ToList());
        }
    }
}

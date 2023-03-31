using MediatR;

namespace DomainEvents.Domain.Entities.User.Events
{
    public class CreateUserEvent : INotification
    {
        public CreateUserEvent()
        {

        }

        public CreateUserEvent(string? name)
        {
            Name = name;
        }

        public string? Name { get; set; }
    }
}

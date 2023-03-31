
using MediatR;

namespace DomainEvents.Domain.Entities.Client.Events
{
    public class CreateClientEvent : INotification
    {
        public string? Name { get; set; }
        public int Years { get; set; }
    }
}

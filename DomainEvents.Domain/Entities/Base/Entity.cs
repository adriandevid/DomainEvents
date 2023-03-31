using MediatR;

namespace DomainEvents.Domain.Entities.Base
{
    public class Entity
    {
        public long Id { get; set; }

        //Create a container of events private and create container of events public.

        private List<INotification> _domainEvents = new List<INotification>();
        public IReadOnlyCollection<INotification> DomainEvents => _domainEvents.AsReadOnly();


        protected void AppendDomainEvent(INotification notification) 
        {
            _domainEvents.Add(notification);
        }
    }
}

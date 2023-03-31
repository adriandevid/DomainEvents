using DomainEvents.Domain.Entities.Base;
using DomainEvents.Domain.Entities.Client.Events;
namespace DomainEvents.Domain.Entities.Client
{
    public class Client : Entity
    {
        public Client()
        {

        }

        public Client(string? name, int years)
        {
            Name= name;
            Years= years;

            CreateClientEventAppendInDomainEvents();
        }


        public string? Name { get; set; }
        public int Years { get; set; }


        private void CreateClientEventAppendInDomainEvents() {
            AppendDomainEvent(new CreateClientEvent());
        }
    }
}

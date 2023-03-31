using DomainEvents.Domain.Entities.Base;
using MediatR;

namespace DomainEvents.Domain.Entities.Person.Events
{
    public class CreatePersonEvent : EventArgs
    {
        public CreatePersonEvent()
        {

        }
        public CreatePersonEvent(string name)
        {
            Name = name;
            Invoke();
        }

        public string? Name { get; set; }

        public void Invoke() {
            Console.WriteLine(" ==> Invoked event with name propertie of {0}", Name);
        }
    }
}

using DomainEvents.Domain.Entities.Base;
using DomainEvents.Domain.Entities.Person.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents.Domain.Entities.Person
{
    public class Person
    {
        public Person()
        {

        }

        public Person(string name)
        {
            Name= name;
        }

        public event EventHandler<CreatePersonEvent> CreatePersonEvent;

        public void StartedCreatePerson() {
            OnRaiseCreatePersonEvent(new CreatePersonEvent(Name));
        }

        public void OnRaiseCreatePersonEvent(CreatePersonEvent e) 
        {
            EventHandler<CreatePersonEvent> raiseEvent = CreatePersonEvent;
            if (raiseEvent != null) {
                raiseEvent(this, e);
            }

        }

        public string Name { get; set; }
    }
}

using DomainEvents.Domain.Entities.Base;
using DomainEvents.Domain.Entities.User.Events;

namespace DomainEvents.Domain.Entities.User
{
    public class User : Entity
    {
        public User()
        {

        }

        public User(string name, string password)
        {
            Name = name;
            Password = password;

            CreateUserEventAppendInDomainEvents();
        }

        public string? Name { get; set; }
        public string? Password { get; set; }


        private void CreateUserEventAppendInDomainEvents()
        {
            AppendDomainEvent(new CreateUserEvent(Name));
        }
    }
}

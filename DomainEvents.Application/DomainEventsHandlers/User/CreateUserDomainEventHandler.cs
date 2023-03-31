using DomainEvents.Domain.Entities.User.Events;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents.Application.DomainEventsHandlers.User
{
    public class CreateUserDomainEventHandler : INotificationHandler<CreateUserEvent>
    {
        public async Task Handle(CreateUserEvent notification, CancellationToken cancellationToken)
        {
           await Task.Run(() => { Console.WriteLine("=====> Evento acionado"); });
        }
    }
}

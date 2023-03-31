using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents.Domain.Entities.User.Events
{
    public class RejectCreateUserEvent : INotification
    {
        public long Id { get; set; }
    }
}

using DomainEvents.Application.Responses.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents.Application.Interfaces.Request
{
    public interface IBaseRequestHandler
    {
        Task<ApiResponse> saveChanges(List<INotification> notifications);
    }
}

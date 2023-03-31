using DomainEvents.Application.Interfaces.Request;
using DomainEvents.Application.Responses.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents.Application.Requests.Request
{
    public class BaseRequestHandler
    {
        private readonly IPublisher _publisher;
        public BaseRequestHandler(IPublisher publisher)
        {
            _publisher= publisher;
        }

        public async Task<ApiResponse> saveChanges(List<INotification> notifications)
        {
            foreach (var item in notifications)
            {
                await _publisher.Publish(item);
            }

            var successState = await Task.Run(() => new ApiResponse { IsValid = true });
            return successState;
        }
    }
}

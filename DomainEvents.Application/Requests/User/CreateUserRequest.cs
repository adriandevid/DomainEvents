using DomainEvents.Application.Responses.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainEvents.Application.Requests.User
{
    public class CreateUserRequest : IRequest<ApiResponse>
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
    }
}

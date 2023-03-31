using System.Reflection;
using DomainEvents.Application.Interfaces.Request;
using DomainEvents.Application.Requests.Person;
using DomainEvents.Application.Requests.Request;
using DomainEvents.Application.Requests.User;
using DomainEvents.Application.Responses.Response;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR((mediatr) => mediatr.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.Load("DomainEvents.Application")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//using mediatr notification
app.MapGet("/create-user", async (IMediator mediator) =>
{
    return await mediator.Send<ApiResponse>(new CreateUserRequest());
})
.WithName("user");

app.MapGet("/create-person", async (IMediator mediator, string name) =>
{
    var request = new CreatePersonRequest();
    request.Name = name;
    return await mediator.Send<ApiResponse>(request);
})
.WithName("person");

app.Run();
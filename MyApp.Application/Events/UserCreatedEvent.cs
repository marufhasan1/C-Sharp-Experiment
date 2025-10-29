using MediatR;

namespace CleanArchitecture.Application.Events;
public record UserCreatedEvent(Guid UserId) : INotification;

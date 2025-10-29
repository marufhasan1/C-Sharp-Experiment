using MediatR;
using Microsoft.Extensions.Logging;

namespace CleanArchitecture.Application.Events
{

    public class StartMembershipEventHandler(ILogger<StartMembershipEventHandler> logger)
        : INotificationHandler<UserCreatedEvent>
    {
        public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
            logger.LogInformation("User Created: Membership start {UserId}",notification.UserId);

            await Task.Delay(2000, cancellationToken);

            logger.LogInformation("User Created: Membership done {UserId}",notification.UserId);

        }
    }
}

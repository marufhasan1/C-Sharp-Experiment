using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Events
{
    public class SendEmailEventHandler(ILogger<SendEmailEventHandler> logger)
        : INotificationHandler<UserCreatedEvent>
    {
        public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
        {
            //throw new NotImplementedException();
            logger.LogInformation("User Created: Send email start");

            await Task.Delay(2000, cancellationToken);

            logger.LogInformation("User Created: Send email done");

        }
    }
}

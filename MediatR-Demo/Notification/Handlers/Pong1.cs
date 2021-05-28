using MediatR;
using MediatR_Demo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_Demo.NotificationHandler
{
    public class Pong1 : INotificationHandler<Ping>
    {
        public Task Handle(Ping notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Pong1, {DateTime.Now}");
            return Task.CompletedTask;
        }

    }
}

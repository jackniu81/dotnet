using MediatR;
using MediatR_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_Demo.RequestResponse
{
    public class RequestHandeler : IRequestHandler<RequestModel, string>
    {
        public Task<string> Handle(RequestModel request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"Pong {DateTime.Now}");
        }
    }
}

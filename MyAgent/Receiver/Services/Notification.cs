﻿using Grpc.Core;
using GrpcAgent;
using System;
using System.Threading.Tasks;

namespace Receiver.Services
{
    public class Notification : Notifier.NotifierBase
    {
        public override Task<NotifyReply> Notify(NotifyRequest request, ServerCallContext context)
        {
            Console.WriteLine($"Received: {request.Content}");

            return Task.FromResult(new NotifyReply() { IsSuccess = true });
        }
    }
}

using System;
using DotNetCore.CAP;
using RabbitMQ.SqlServer.IService;

namespace RabbitMQ.SqlServer.Service
{
    public class SubscribeService : ISubscribeService, ICapSubscribe
    {
        [CapSubscribe("xxx.test.test1")]
        public void CheckReceivedMessage(dynamic param)
        {
            Console.WriteLine(param.ToString());
        }
    }
}
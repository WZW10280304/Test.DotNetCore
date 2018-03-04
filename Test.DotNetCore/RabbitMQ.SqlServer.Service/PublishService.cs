using DotNetCore.CAP;
using RabbitMQ.SqlServer.IService;

namespace RabbitMQ.SqlServer.Service
{
    public class PublishService : IPublishService
    {
        private readonly ICapPublisher _publisher;

        //在构造函数中获取接口实例
        public PublishService(ICapPublisher publisher)
        {
            _publisher = publisher;
        }

        public void PublishMessage(dynamic param, string callbackName = null)
        {
            _publisher.PublishAsync("xxx.test.test1", param, callbackName);
        }
    }
}
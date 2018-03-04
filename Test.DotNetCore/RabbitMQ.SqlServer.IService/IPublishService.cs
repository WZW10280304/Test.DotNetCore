namespace RabbitMQ.SqlServer.IService
{
    public interface IPublishService
    {
        void PublishMessage(dynamic param, string callbackName = null);
    }
}
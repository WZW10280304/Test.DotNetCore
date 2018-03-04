namespace RabbitMQ.SqlServer.IService
{
    public interface ISubscribeService
    {
        void CheckReceivedMessage(dynamic param);
    }
}
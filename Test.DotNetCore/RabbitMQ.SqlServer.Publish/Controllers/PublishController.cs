using System;
using System.Threading.Tasks;
using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;

namespace RabbitMQ.SqlServer.Publish.Controllers
{
    public class PublishController : Controller
    {
        private readonly ICapPublisher _publisher;

        //在构造函数中获取接口实例
        public PublishController(ICapPublisher publisher)
        {
            _publisher = publisher;
        }

        [Route("publish")]
        public async Task<string> PublishMessage()
        {
            await _publisher.PublishAsync("xxx.test.test1", new Person { Name = "N" + DateTime.Now.Ticks, Age = DateTime.Now.Second });

            return "xxx.test.test1";
        }

        [Route("~/publish2")]
        public async Task<IActionResult> PublishMessageWithTransaction([FromServices]AppDbContext dbContext, [FromServices]ICapPublisher publisher)
        {
            using (var trans = dbContext.Database.BeginTransaction())
            {
                // 此处填写你的业务代码

                //如果你使用的是EF，CAP会自动发现当前环境中的事务，所以你不必显式传递事务参数。
                //由于本地事务, 当前数据库的业务操作和发布事件日志之间将实现原子性。
                await publisher.PublishAsync("xxx.test.test1", new Person { Name = "N" + DateTime.Now.Ticks, Age = DateTime.Now.Second });

                throw new Exception();

                trans.Commit();
            }
            return Ok();
        }

        public string Index()
        {
            return "Subscribe";
        }
    }
}
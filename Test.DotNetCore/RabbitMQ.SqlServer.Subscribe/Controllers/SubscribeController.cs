using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;

namespace RabbitMQ.SqlServer.Subscribe.Controllers
{
    public class SubscribeController : Controller
    {
        [CapSubscribe("xxx.test.test1")]
        public void CheckReceivedMessage(Person person)
        {
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);

            //Response.WriteAsync(person.ToString());
        }

        public string Index()
        {
            return "Subscribe";
        }
    }
}
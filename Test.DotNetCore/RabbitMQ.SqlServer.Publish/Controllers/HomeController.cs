using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.SqlServer.Publish.Models;

namespace RabbitMQ.SqlServer.Publish.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ICapPublisher _publisher;

        ////在构造函数中获取接口实例
        //public HomeController(ICapPublisher publisher)
        //{
        //    _publisher = publisher;
        //}

        //[Route("publish")]
        //public async Task<string> PublishMessage()
        //{
        //    await _publisher.PublishAsync("xxx.test.test1", new Person { Name = "Foo", Age = 11 });

        //    return "xxx.test.test1";
        //}

        //[CapSubscribe("xxx.test.test1")]
        //public void CheckReceivedMessage(Person person)
        //{
        //    Console.WriteLine(person.Name);
        //    Console.WriteLine(person.Age);

        //    //Response.WriteAsync(person.ToString());
        //}

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
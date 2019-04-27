using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebReadJson.Models;

namespace WebReadJson.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var webClient = new WebClient();
            var json = webClient.DownloadString(@"C:\Users\mehar\source\repos\WebApiJson\WebApiJson\App_Data\books.json");
            var books = JsonConvert.DeserializeObject<Books>(json);
            return View(books);
        }
    }
}
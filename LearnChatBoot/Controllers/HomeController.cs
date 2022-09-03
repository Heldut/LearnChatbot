using LearnChatBoot.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LearnChatBoot.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult About()
        {
            UserMessage userMessage = new UserMessage();
            //ViewData["Message"] = "Your application description page.";

            return View(userMessage);
        }

        [HttpPost]
        public IActionResult About(UserMessage model)
        {
            //ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpGet]
        public IActionResult Contact()
        {
            //ViewData["Message"] = "Your contact page.";
            UserMessage userMessage = new UserMessage();

            ViewBag.Mensagem = "Teste1\n\nTeste2\n\nTeste3\n\n";

            return View(userMessage);
        }

        [HttpPost]
        public IActionResult Contact(string msg)
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

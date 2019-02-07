using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P2app.Models;


namespace P2app.Controllers
{
    public class CalculateController : Controller
    {
        public IActionResult Index()
        {
             return View();
        }
        public IActionResult Greeting()
        {
            return Content("Welcome to my App !! :)");
        }

        public IActionResult Calculate()
        {
            return View("Views/Calculate/Calculate.cshtml");
        }

        public IActionResult JSON()
        {
            return Json(new
            {
                apptype = ".NET Core",
                appname = "P2app" ,
                author = "Santosh Sekhar, Muchkur Bogarajula",
                course = "44663"
            });
        }

        public IActionResult HTML()
        {
            return Content("<!DOCTYPE html><html><body>Come calculate with us!!</body></html>", "text/html");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
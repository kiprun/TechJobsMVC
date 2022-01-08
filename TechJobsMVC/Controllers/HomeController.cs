using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TechJobsMVC.Models;

namespace TechJobsMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()//displays the homepage. Pulls template from (Views/Home/Index.cshtml)
        {
            Dictionary<string, string> actionChoices = new Dictionary<string, string>();
            actionChoices.Add("search", "Search");//adds "search" option to homepage
            actionChoices.Add("list", "List");//adds "list" option to homepage

            ViewBag.actions = actionChoices;//allows (Views/Home/Index.cshtml) to iterate thru Dictionary actionChoices
            return View();
        }
    }
}

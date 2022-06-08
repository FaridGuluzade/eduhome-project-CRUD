using Microsoft.AspNetCore.Mvc;
using System;
namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

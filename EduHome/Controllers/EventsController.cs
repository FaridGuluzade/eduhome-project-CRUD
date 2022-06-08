using Microsoft.AspNetCore.Mvc;
using System;

namespace EduHome.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

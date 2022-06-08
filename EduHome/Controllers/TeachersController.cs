using Microsoft.AspNetCore.Mvc;
using System;

namespace EduHome.Controllers
{
    public class TeachersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

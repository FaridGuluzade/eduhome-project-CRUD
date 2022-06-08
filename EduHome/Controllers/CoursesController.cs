using Microsoft.AspNetCore.Mvc;
using System;

namespace EduHome.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

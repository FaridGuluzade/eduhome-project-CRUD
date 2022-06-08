using Microsoft.AspNetCore.Mvc;
using System;

namespace EduHome.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

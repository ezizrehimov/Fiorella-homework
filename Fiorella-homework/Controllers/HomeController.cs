﻿using Microsoft.AspNetCore.Mvc;

namespace Fiorella_homework.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

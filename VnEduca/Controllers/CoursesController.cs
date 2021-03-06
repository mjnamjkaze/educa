﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PlayIt.Models;

namespace PlayIt.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CoursesController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}

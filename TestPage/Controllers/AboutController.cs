﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TestPage.Controllers
{
    [Route("about")]
    public class AboutController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
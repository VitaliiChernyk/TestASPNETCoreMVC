using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace TestPage.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("login")]
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Login(string userName, string password)
        {
            if (userName != null && password != null && userName.Equals("acc1") && password.Equals("test"))
            {
                HttpContext.Session.SetString("username", userName);
                return View("Success");
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Index");
            }

        }
        [Route("logout")]
        [HttpGet, ValidateAntiForgeryToken]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index");
        }
    }
}
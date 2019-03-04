using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using LIA2Project.Models;

namespace LIA2Project.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private UserManager<Users> _userManager;

        public HomeController(UserManager<Users> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            string name = _userManager.GetUserName(HttpContext.User);
            ViewData["name"] = name;
            return View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}

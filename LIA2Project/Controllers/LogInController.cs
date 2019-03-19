using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using LIA2Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace LIA2Project.Controllers
{
    public class LogInController : Controller
    {
        public static HttpClient client = new HttpClient();
        public static bool LoggedIn = false;
        public static DeskUser TheUser = new DeskUser();

        public static void SetupClient()
        {
            var user = Encoding.ASCII.GetBytes($"{TheUser.UserName}:{TheUser.Password}");

            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(user));

            LoggedIn = true;
        }




        public IActionResult Index()
        {
            return View();
        }
    }
}
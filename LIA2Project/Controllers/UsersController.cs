using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LIA2Project.Models;
using LIA2Project.Models.DataAccess;


namespace LIA2Project.Controllers
{
    public class UsersController : Controller
    {
        CasesDataAccessLayer objCase = new CasesDataAccessLayer();

        [HttpGet]
        [Route("api/Users/Index")]
        public IEnumerable<Users> Index()
        {
            return objCase.GetAllUsers();
        }

        [HttpGet]
        [Route("api/Users/Details/{id}")]
        public Users Details(int id)
        {
            return objCase.GetUsersData(id);
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
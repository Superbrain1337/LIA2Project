using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LIA2Project.Models;
using LIA2Project.Models.DataAccess;

namespace LIA2Project.Controllers
{
    public class CaseContactsController : Controller
    {
        CasesDataAccessLayer objCase = new CasesDataAccessLayer();

        [HttpGet]
        [Route("api/Casecontacts/Index")]
        public IEnumerable<CaseContacts> Index()
        {
            return objCase.GetAllCaseContacts();
        }

        [HttpGet]
        [Route("api/Casecontacts/Details/{id}")]
        public CaseContacts Details(int id)
        {
            return objCase.GetCaseContactsData(id);
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
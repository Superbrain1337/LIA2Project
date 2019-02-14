using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LIA2Project.Models;
using LIA2Project.Models.DataAccess;

namespace LIA2Project.Controllers
{
    public class CasesController : Controller
    {
        CasesDataAccessLayer objCase = new CasesDataAccessLayer();

        [HttpGet]
        [Route("api/Cases/Index")]
        public IEnumerable<Cases> Index()
        {
            return objCase.GetAllCases();
        }

        [HttpPost]
        [Route("api/Cases/Create")]
        public int Create(Cases cas)
        {
            return objCase.AddCase(cas);
        }

        [HttpGet]
        [Route("api/Cases/Details/{id}")]
        public Cases Details(int id)
        {
            return objCase.GetCaseData(id);
        }

        [HttpPut]
        [Route("api/Cases/Edit")]
        public int Edit(Cases cas)
        {
            return objCase.UpdateCase(cas);
        }

        [HttpDelete]
        [Route("api/Cases/Delete/{id}")]
        public int Delete(int id)
        {
            return objCase.DeleteCase(id);
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

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LIA2Project.Models;
using LIA2Project.Models.DataAccess;

namespace LIA2Project.Controllers
{
    public class DevicesController : Controller
    {
        CasesDataAccessLayer objCase = new CasesDataAccessLayer();

        [HttpGet]
        [Route("api/Devices/Index")]
        public IEnumerable<CaseDevices> Index()
        {
            return objCase.GetAllDevices();
        }

        [HttpGet]
        [Route("api/Devices/Details/{id}")]
        public CaseDevices Details(int id)
        {
            return objCase.GetDeviceData(id);
        }

        [HttpPut]
        [Route("api/Devices/Edit")]
        public int Edit(CaseDevices dev)
        {
            return objCase.UpdateDevice(dev);
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
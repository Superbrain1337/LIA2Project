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
        DevicesDataAccessLayer objDev = new DevicesDataAccessLayer();

        [HttpGet]
        [Route("api/Devices/Index")]
        public IEnumerable<CaseDevices> Index()
        {
            return objDev.GetAllDevices();
        }

        [HttpGet]
        [Route("api/Devices/Details/{id}")]
        public CaseDevices Details(int id)
        {
            return objDev.GetDeviceData(id);
        }

        [HttpPut]
        [Route("api/Devices/Edit")]
        public int Edit(CaseDevices dev)
        {
            return objDev.UpdateDevice(dev);
        }

        [HttpGet]
        [Route("api/Inventory/{id}")]
        public Inventory GetDeviceInventory(Guid id)
        {
            return objDev.GetDeviceInventory(id);
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
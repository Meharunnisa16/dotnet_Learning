using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi1.Models;
using WebApi1.services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {


        private readonly IDataServices _services;

        public DataController(IDataServices services)
        {
            _services = services;
        }


        // GET: api/<controller>
        [HttpGet]
        [Route ("GetDataValues")]
        public ActionResult<Dictionary<string, DataValues>> GetDataValues(DataValues values)
        {
            var dataValues = _services.GetDataValues(values);

            if (dataValues.Count == 0)
             {
                return NotFound();
            }

            return dataValues;
        }

        // POST api/<controller>


        [HttpPost]
        [Route("AddDataValues")]

        public ActionResult<DataValues> AddDataValues(DataValues values)
        {
            var dataValues = _services.AddDataValues(values);

            if (dataValues == null)
            {
                return NotFound();
            }

            return dataValues;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

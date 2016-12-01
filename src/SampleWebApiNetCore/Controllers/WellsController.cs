using Microsoft.AspNetCore.Mvc;
using SampleWebApiNetCore.Models;
using SampleWebApiNetCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApiNetCore.Controllers
{
    [Route("api/[controller]")]
    public class WellsController : Controller
    {
        private IWellRepository wellRep;

        public WellsController(IWellRepository context)
        {
            wellRep = context;
        }

        // GET api/wells
        [HttpGet]
        public IEnumerable<Well> Get()
        {
            return wellRep.GetAll();
        }

        // GET api/wells/1
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var well = wellRep.Find(id);
            if(well == null)
            {
                return NotFound();
            }

            return new ObjectResult(well);
        }

        // POST api/wells
        [HttpPost]
        public IActionResult Post([FromBody] Well well)
        {
            if(well == null)
            {
                return BadRequest();
            }

            wellRep.Add(well);
            return new ObjectResult(well);
        }

        // DELETE api/wells/1
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var well = wellRep.Find(id);
            if (well == null)
            {
                return NotFound();
            }

            wellRep.Remove(id);
            // better OkResult() instead of new NoContentResult()
            return Ok();
        }
    }
}

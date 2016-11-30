using Microsoft.AspNetCore.Mvc;
using SampleWebApiNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApiNetCore.Controllers
{
    [Route("api/[controller]")]
    public class WellsController : Controller
    {
        private DataBaseContext db;

        public WellsController(DataBaseContext context)
        {
            db = context;
        }

        // GET api/wells
        [HttpGet]
        public IEnumerable<Well> Get()
        {
            return db.Wells.ToList();
        }
    }
}

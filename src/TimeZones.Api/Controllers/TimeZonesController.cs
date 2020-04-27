using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TimeZones.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeZonesController : ControllerBase
    {
        // GET: api/TimeZones
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/TimeZones/America/New_York
        [HttpGet("{name}", Name = "Get")]
        public Zone Get(string name)
        {
            return (Zone)name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESI.Server.hubs;
using ESI.Server.Models;
using ESI.Server.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace ESI.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SensorController : ControllerBase
    {
        private ISensorService sensors { get; set; }
        public ISensorDataGenerator generator { get; set; }

        public SensorController(
            ISensorDataGenerator _generator,
            ISensorService _sensors)
        {
            this.generator = _generator;
            this.sensors = _sensors;
        }

        

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Sensor>> Get()
        {
            this.generator.Start();
            return this.sensors.ReadAll();
        }
    }
}

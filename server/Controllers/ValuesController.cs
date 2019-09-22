using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESI.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace ESI.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoraGatewayController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<LoraGateway>> Get()
        {
            return new LoraGateway[] {
                new LoraGateway() { 
                    GatewayID =Guid.NewGuid(), 
                    Lat = 49.14655560543898,
                    Long = 9.217690050777271 
                },
                new LoraGateway() { 
                    GatewayID =Guid.NewGuid(), 
                    Lat = 49.14797322423572,
                    Long = 9.232485009692498 
                }
            };
        }
    }
}

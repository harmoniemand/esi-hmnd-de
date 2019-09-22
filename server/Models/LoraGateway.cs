using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ESI.Server.Models
{
    public class LoraGateway
    {
        public Guid GatewayID { get; set; }
        public string Title { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
    }
}
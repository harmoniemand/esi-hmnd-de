using System;
using ESI.Server.Models;

namespace ESI.Server.Models
{
    public class Value
    {
        public Guid SensorId { get; set; }
        public double Data { get; set; }
    }
}
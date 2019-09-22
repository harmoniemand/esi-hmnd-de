using System;
using ESI.Server.Models;

namespace ESI.Server.Models
{
    public class Sensor
    {
        public Guid SensorId { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
    }
}
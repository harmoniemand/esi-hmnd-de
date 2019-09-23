using System;
using System.Collections.Generic;
using ESI.Server.Models;

namespace ESI.Server.Models
{
    public class SensorStation
    {
        public Guid SensorStationId { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public decimal BatteryLevel { get; set; }

        public List<Sensor> Sensors { get; set; }

        public SensorStation()
        {
            this.Sensors = new List<Sensor>();
        }
    }
}
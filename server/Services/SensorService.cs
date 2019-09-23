using System;
using System.Collections.Generic;
using System.Linq;
using ESI.Server.Models;

namespace ESI.Server.Services
{
    public class SensorService : ISensorService
    {
        List<Sensor> sensors = new List<Sensor>();

        
        public SensorService()
        {
            this.CreateSensor(
                new Sensor()
                {
                    SensorId = Guid.NewGuid(),
                    Lat = 49.15490633976864,
                    Long = 9.24628257751465
                }
            );

            this.CreateSensor(
            new Sensor()
            {
                SensorId = Guid.NewGuid(),
                Lat = 49.15286439945769,
                Long = 9.241465330123903
            }
            );

            this.CreateSensor(
                new Sensor()
                {
                    SensorId = Guid.NewGuid(),
                    Lat = 49.15893383781975,
                    Long = 9.234673976898195
                }
            );

            this.CreateSensor(
                new Sensor()
                {
                    SensorId = Guid.NewGuid(),
                    Lat = 49.156716649444874,
                    Long = 9.22980308532715
                }
            );

            this.CreateSensor(
                new Sensor()
                {
                    SensorId = Guid.NewGuid(),
                    Lat = 49.143755338239046,
                    Long = 9.214954376220705
                }
            );

            this.CreateSensor(
                new Sensor()
                {
                    SensorId = Guid.NewGuid(),
                    Lat = 49.14537656485309,
                    Long = 9.252226352691652
                }
            );

            this.CreateSensor(
                new Sensor()
                {
                    SensorId = Guid.NewGuid(),
                    Lat = 49.14233058015447,
                    Long = 9.264392852783205
                }
            );

            this.CreateSensor(
                new Sensor()
                {
                    SensorId = Guid.NewGuid(),
                    Lat = 49.135479939809464,
                    Long = 9.262676239013674
                }
            );

            this.CreateSensor(
                new Sensor()
                {
                    SensorId = Guid.NewGuid(),
                    Lat = 49.12197242062903,
                    Long = 9.238944053649904
                }
            );

            this.CreateSensor(
                new Sensor()
                {
                    SensorId = Guid.NewGuid(),
                    Lat = 49.117492503570894,
                    Long = 9.234158992767336
                }
            );
        }

        public void CreateSensor(Sensor s) {
            if (this.sensors.Any(m=>m.SensorId == s.SensorId)) {
                this.sensors.Remove(this.sensors.First(m=>m.SensorId == s.SensorId));
            }

            this.sensors.Add(s);
        }

        public Sensor[] ReadAll()
        {
            return this.sensors.ToArray();
        }


    }
}
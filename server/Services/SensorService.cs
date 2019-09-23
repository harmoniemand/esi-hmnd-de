using System;
using ESI.Server.Models;

namespace ESI.Server.Services
{
    public class SensorService : ISensorService
    {
        public Sensor[] ReadAll()
        {
            return new Sensor[] {
                new Sensor() {
                    SensorId = Guid.NewGuid(),
                    Lat = 49.15490633976864,
                    Long = 9.24628257751465
                },

                new Sensor() {
                    SensorId = Guid.NewGuid(),
                    Lat =  49.15286439945769,
                    Long = 9.241465330123903
                },

                new Sensor() {
                    SensorId = Guid.NewGuid(),
                    Lat = 49.15893383781975,
                    Long = 9.234673976898195
                },
                
                new Sensor() {
                    SensorId = Guid.NewGuid(),
                    Lat = 49.156716649444874,
                    Long = 9.22980308532715
                },

                new Sensor() {
                    SensorId = Guid.NewGuid(),
                    Lat = 49.143755338239046,
                    Long = 9.214954376220705
                },
                
                new Sensor() {
                    SensorId = Guid.NewGuid(),
                    Lat = 49.14537656485309, 
                    Long = 9.252226352691652
                },

                new Sensor() { 
                    SensorId = Guid.NewGuid(),
                    Lat = 49.14233058015447, 
                    Long = 9.264392852783205
                },
                
                new Sensor() { 
                    SensorId = Guid.NewGuid(),
                    Lat = 49.135479939809464,
                    Long = 9.262676239013674
                },

                new Sensor() { 
                    SensorId = Guid.NewGuid(),
                    Lat = 49.12197242062903,
                    Long = 9.238944053649904
                },

                new Sensor() { 
                    SensorId = Guid.NewGuid(),
                    Lat = 49.117492503570894,
                    Long = 9.234158992767336
                }
            };
        }
    }
}
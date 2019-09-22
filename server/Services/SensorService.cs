using System;
using ESI.Server.Models;

namespace ESI.Server.Services {
    public class SensorService : ISensorService {
        public Sensor[] ReadAll() {
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
                
    // { lat: 49.15893383781975, lng: 9.234673976898195, id: 'a6c58701' },
    // { lat: 49.156716649444874, lng: 9.22980308532715, id: '1ae4b966' },
    // { lat: 49.143755338239046, lng: 9.214954376220705, id: 'b1a672f2' },
    // { lat: 49.14537656485309, lng: 9.252226352691652, id: '64baee2c' },
    // { lat: 49.14233058015447, lng: 9.264392852783205, id: 'f03ee77c' },
    // { lat: 49.135479939809464, lng: 9.262676239013674, id: '0777c192' },
    // { lat: 49.12197242062903, lng: 9.238944053649904, id: '9c611781' },
    // { lat: 49.117492503570894, lng: 9.234158992767336, id: '2c1525dc' }
            };
        }
    }
}
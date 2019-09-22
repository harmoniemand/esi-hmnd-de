using ESI.Server.Models;

namespace ESI.Server.Services {
    public interface ISensorService {
        Sensor[] ReadAll();
        
    }
}
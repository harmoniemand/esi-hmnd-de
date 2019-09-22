using ESI.Server.Models;

namespace ESI.Server.Services {
    public interface ISensorDataGenerator {
        void Start();
        void Stop();
        
    }
}
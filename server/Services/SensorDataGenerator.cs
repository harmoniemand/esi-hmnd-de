using System;
using System.Threading;
using ESI.Server.hubs;
using ESI.Server.Models;
using Microsoft.AspNetCore.SignalR;

namespace ESI.Server.Services
{
    public class SensorDataGenerator : ISensorDataGenerator
    {
        private Timer _timer;
        private AutoResetEvent _autoResetEvent;
        private IHubContext<SensorValueHub> _hub;


        public SensorDataGenerator(IHubContext<SensorValueHub> hub)
        {
            _hub = hub;
        }

        public void Start()
        {
            if (this._timer == null)
            {
                Console.WriteLine("timer started");
                _autoResetEvent = new AutoResetEvent(false);
                _timer = new Timer(Execute, _autoResetEvent, 1000, 2000);
            }
        }

        public void Stop()
        {
            this._timer.Dispose();
        }


        public void Execute(object stateInfo)
        {
            Console.WriteLine("timer elapsed");
            _hub.Clients.All.SendAsync("transferchartdata", (this.GetData()));

        }

        public decimal GetData()
        {
            var r = new Random();
            return r.Next(20, 25);
        }

    }
}
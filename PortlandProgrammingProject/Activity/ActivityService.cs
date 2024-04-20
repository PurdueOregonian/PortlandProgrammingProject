using Microsoft.AspNetCore.SignalR;
using PortlandProgrammingProject.Hubs;

namespace PortlandProgrammingProject.Job
{
    public class ActivityService
    {
        private readonly Random _random = new Random();
        private readonly IHubContext<ActivityHub> _hubContext;

        public ActivityService(IHubContext<ActivityHub> hubContext)
        {
            _hubContext = hubContext;
            var periodicTimer = new PeriodicTimer(TimeSpan.FromSeconds(1));
            RunInBackground(TimeSpan.FromSeconds(1), () => UpdateActivity());
        }

        private void UpdateActivity()
        {
            _hubContext.Clients.All.SendAsync("Happiness", _random.Next(100));
            _hubContext.Clients.All.SendAsync("Craziness", _random.Next(100));
            _hubContext.Clients.All.SendAsync("Sleepiness", _random.Next(100));
        }

        async Task RunInBackground(TimeSpan timeSpan, Action action)
        {
            var periodicTimer = new PeriodicTimer(timeSpan);
            while (await periodicTimer.WaitForNextTickAsync())
            {
                action();
            }
        }
    }
}

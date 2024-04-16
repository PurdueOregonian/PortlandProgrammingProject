using Microsoft.AspNetCore.SignalR;

namespace PortlandProgrammingProject.Hubs
{
    public class ActivityHub : Hub
    {
        public async Task UpdateHappiness(double value)
        {
            await Clients.All.SendAsync("Happiness", value);
        }
        public async Task UpdateCraziness(double value)
        {
            await Clients.All.SendAsync("Craziness", value);
        }
        public async Task UpdateSleepiness(double value)
        {
            await Clients.All.SendAsync("Sleepiness", value);
        }
    }
}

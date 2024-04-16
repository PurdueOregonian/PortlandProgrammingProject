using Microsoft.AspNetCore.SignalR;

namespace PortlandProgrammingProject.Hubs
{
    public class ActivityHub : Hub
    {
        public async Task Start()
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public async Task Stop()
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public async Task SendProgressMessage()
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}

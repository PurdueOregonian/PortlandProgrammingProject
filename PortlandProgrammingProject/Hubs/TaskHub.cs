using Microsoft.AspNetCore.SignalR;

namespace PortlandProgrammingProject.Hubs
{
    public class TaskHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}

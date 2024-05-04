using Microsoft.AspNetCore.SignalR;

namespace CollaborationStation.Hubs;

public class ChatHub : Hub<IChatHubClient>
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.ReceiveMessage(user, message);
    }
}

public interface IChatHubClient
{
    public Task ReceiveMessage(string user, string message);
}

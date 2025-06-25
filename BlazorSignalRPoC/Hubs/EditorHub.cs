using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

public class EditorHub : Hub
{
    public async Task BroadcastText(string user, string text)
    {
        await Clients.Others.SendAsync("ReceiveText", user, text);
    }
}
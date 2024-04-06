using Microsoft.AspNet.SignalR;

public class ChatHub : Hub
{
    public void SendMessage(string name, string message)
    {        // 将收到的消息广播给所有客户端
        Clients.All.broadcastMessage(name, message);
    }
}

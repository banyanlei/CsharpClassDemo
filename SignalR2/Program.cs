//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(YourNamespace.Startup))]
namespace YourNamespace
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 启用SignalR
            app.MapSignalR();
        }
    }
}
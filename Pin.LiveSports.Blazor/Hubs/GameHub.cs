using Microsoft.AspNetCore.SignalR;
using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Core.Services;
using Pin.LiveSports.Core.Services.Interfaces;
using System.Numerics;

namespace Pin.LiveSports.Blazor.Hubs
{
    public class GameHub : Hub
    {
        private readonly IGameService _gameService;

        public GameHub(IGameService viewerService)
        {
            _gameService = viewerService;
        }

        public async Task NewViewerJoined(string viewerName)
        {
            var newViewer = new Viewer
            {
                ConnectionId = Context.ConnectionId,
                Name = viewerName,
            };

            _gameService.AddViewer(newViewer);
            await Clients.Others.SendAsync("NewViewerAddedToViewerList", viewerName);
        }
    }
}

using Pin.LiveSports.Core.Models;
using Pin.LiveSports.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Services
{
    public class GameService : IGameService
    {
        private List<Viewer> viewers;

        public GameService()
        {
            viewers = new List<Viewer>();
        }

        public void AddViewer(Viewer viewer)
        {
            viewers.Add(viewer);
        }

        public List<Viewer> GetAllViewers()
        {
            return viewers;
        }
    }
}

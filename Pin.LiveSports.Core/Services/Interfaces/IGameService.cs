using Pin.LiveSports.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Services.Interfaces
{
    public interface IGameService
    {
        void AddViewer(Viewer viewer);
        List<Viewer> GetAllViewers();
        Game GetGame();
        void SetGameIsStarted();
        void AddReport(Report report);
    }
}

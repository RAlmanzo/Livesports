using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Models
{
    public class Game
    {
        public List<Player> Players { get; set; }
        public List<Report> Reports { get; set; }
        public bool IsStarted { get; set; }
        public Player SelectedPlayer { get; set; }
    }
}

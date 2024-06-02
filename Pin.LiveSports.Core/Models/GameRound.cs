using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Models
{
    public class GameRound
    {
        public string RoundNumber { get; set; }
        public TimeSpan RoundTime { get; set; }
        public TimeSpan PenaltyTime { get; set; }
    }
}

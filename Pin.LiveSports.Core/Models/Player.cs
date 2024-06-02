using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pin.LiveSports.Core.Models
{
    public class Player
    {
        public string Image {  get; set; }
        public string Position {  get; set; }
        public string FullName { get; set; }
        public string Country { get; set; }
        public string CountryFlagIcon { get; set; }
        public List<GameRound> GameRounds { get; set; }
    }
}

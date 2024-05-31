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
        private List<Game> games = new List<Game>();
        private List<Viewer> viewers;
        private List<Player> players;

        public GameService()
        {
            viewers = new List<Viewer>();
            players = new List<Player>
            {
                new Player{Position = "-", FullName = "Bram Sikkens", Country = "België", CountryFlagIcon = null, GameRounds = null},
                new Player{Position = "-", FullName = "Peter Kauzer", Country = "Slovakije", CountryFlagIcon = null, GameRounds = null},
                new Player{Position = "-", FullName = "Pedro Goncalves", Country = "Brazilie", CountryFlagIcon = null, GameRounds = null},
                new Player{Position = "-", FullName = "Jakub Brzezinski", Country = "Polen", CountryFlagIcon = null, GameRounds = null},
                new Player{Position = "-", FullName = "Hannes Aigner", Country = "Duitsland", CountryFlagIcon = null, GameRounds = null},
            };

            var game = new Game { Players = players };
            games.Add(game);
        }

        public void AddViewer(Viewer viewer)
        {
            viewers.Add(viewer);
        }

        public List<Viewer> GetAllViewers()
        {
            return viewers;
        }

        public Game GetGame()
        {
            return games.FirstOrDefault();
        }

        public void SetGameIsStarted() 
        {
            games.FirstOrDefault().IsStarted = true;
        }
    }
}

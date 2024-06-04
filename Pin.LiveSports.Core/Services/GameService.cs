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
                new Player{Position = "-", Age = 32, FullName = "Bram Sikkens", Country = "België", CountryFlagIcon = "images/belgie.png", GameRounds = null, Image = "images/bramsikkens.png"},
                new Player{Position = "-", Age = 29, FullName = "Peter Kauzer", Country = "Slovakije", CountryFlagIcon = "images/slovakije.png", GameRounds = null, Image = "images/peterkauzer.png"},
                new Player{Position = "-", Age = 25, FullName = "Pedro Goncalves", Country = "Brazilie", CountryFlagIcon = "images/brazilie.png", GameRounds = null, Image = "images/pedro.png"},
                new Player{Position = "-", Age = 34, FullName = "Jakub Brzezinski", Country = "Polen", CountryFlagIcon = "images/polen.png", GameRounds = null, Image = "images/jakub.png"},
                new Player{Position = "-", Age = 22, FullName = "Hannes Aigner", Country = "Duitsland", CountryFlagIcon = "images/duitsland.png", GameRounds = null , Image = "images/hannes.png"},
            };

            var game = new Game {Name = "Lee Valley White Water Centre", Players = players };
            game.Reports = new List<Report>();
            games.Add(game);
        }

        public void AddReport(Report report)
        {
            GetGame().Reports.Add(report);
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
    }
}

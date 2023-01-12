using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HockeyManagment.Players;

namespace HockeyManagment.HockeyManager
{
    internal class HockeyManager : IHockeyManager
    {
        private readonly List<Player> _players;

        public HockeyManager()
        {
            _players = new List<Player>();
        }

        public void AddNewForward(int Age, string Name, int Goals)
        {
            var p = new PlayerForward(Age, Name, Goals);

            _players.Add(p);
        }

        public void AddNewForward(PlayerForward p) =>
            _players.Add(p);

        public void AddNewDefender(int Age, string Name, int Hits)
        {
            var p = new PlayerDefender(Age, Name, Hits);

            _players.Add(p);
        }

        public void AddNewDefender(PlayerDefender p) =>
            _players.Add(p);

        public void AddNewGoalie(int Age, string Name, int Rebounds)
        {
            var p = new PlayerGoalie(Age, Name, Rebounds);

            _players.Add(p);
        }

        public void AddNewGoalie(PlayerGoalie p) =>
            _players.Add(p);

        public void PrintNameAndAgeOfTheYoungestPlayer()
        {
            var youngestPlayer = _players.Where(p => p.Age == _players.Min(p1 => p1.Age));

            foreach (var p in youngestPlayer)
                Console.WriteLine($"Name: {p.Name} Age: {p.Age} {p.typeOfPlayer}");
        }
    }
}

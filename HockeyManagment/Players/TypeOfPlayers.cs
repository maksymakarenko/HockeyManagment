using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManagment.Players
{
    public class PlayerForward : Player
    {
        internal int Goals { get; set; }
        public PlayerForward(int Age, string Name, int Goals)
        {
            this.Age = Age;
            this.Name = Name;
            this.Goals = Goals;
            typeOfPlayer = TypeOfPlayer.Forward;
        }
    }

    public class PlayerDefender : Player
    {
        internal int Hits { get; set; }
        public PlayerDefender(int Age, string Name, int Hits)
        {
            this.Age = Age;
            this.Name = Name;
            this.Hits = Hits;
            typeOfPlayer = TypeOfPlayer.Defender;
        }
    }

    public class PlayerGoalie : Player
    {
        internal int Rebounds { get; set; }
        public PlayerGoalie(int Age, string Name, int Rebounds)
        {
            this.Age = Age;
            this.Name = Name;
            this.Rebounds = Rebounds;
            typeOfPlayer = TypeOfPlayer.Goalie;
        }
    }
}

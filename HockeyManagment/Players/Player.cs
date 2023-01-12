using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManagment.Players
{
    public class Player
    {
        internal int Age { get; set; }
        internal string? Name { get; set; }
        internal TypeOfPlayer typeOfPlayer { get; set; }
    }

    enum TypeOfPlayer
    {
        Forward,
        Defender,
        Goalie
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HockeyManagment.HockeyManager
{
    internal interface IHockeyManager
    {
        public void AddNewForward(int Age, string Name, int Goals);
        public void AddNewDefender(int Age, string Name, int Hits);
        public void AddNewGoalie(int Age, string Name, int Rebounds);
        public void PrintNameAndAgeOfTheYoungestPlayer();
    }
}

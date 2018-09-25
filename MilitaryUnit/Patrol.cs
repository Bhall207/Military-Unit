using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Patrol : Mission
  
    {
        public void HighValueTarget()
        {
            Console.WriteLine("alright boys lets shoot some bad guys!");
        }
        public void MissionComplete()
        {
            Console.WriteLine("Good job troops lets take it home, mission is complete");
        }

    }
}

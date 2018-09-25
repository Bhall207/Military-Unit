using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class DistributeChow : Mission
    {
        public void HandOutRations()
        {
            Console.WriteLine("I Hope everyone is hungry because there is plenty of slop to go around");

        }
        public void PackUpMerMikes()
        {
            Console.WriteLine("Less talking more eating!!! Our work here is done boys PACK IT UP");
       
        }
        public void MissonComplete()
        {
            Console.WriteLine("Lets go get these pots cleaned our work here is done, mission complete");

        }
    }
}

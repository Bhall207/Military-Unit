using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Mission
    {
        public void MissionType(string type)
        {
            Console.WriteLine("Mount up troops and get ready to head out");
        }
        public void OutOfWire()
        {
            Console.WriteLine("This is Lima 6000 radio check over");
            
        }
        public void BackToFob(string complete)
        {
            Console.WriteLine($"Good work troops our mission here is {complete}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Helicopter : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Hang in there troops while the engine warms up ");
        }
        public override void Move()
        {
            Console.WriteLine("alright gent its time for take off i hope your seatbelts are one");
        }
        public override void Fuel()
        {
            Console.WriteLine("the bird is fueled up");
        }
        public override void Maintain()
        {
            Console.WriteLine("all maint is up to date");
        }
    }
}

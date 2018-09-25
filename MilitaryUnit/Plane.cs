using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Plane : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("chicka chicka chicka, the plain has started");
        }
        public override void Move()
        {
            Console.WriteLine("Wheels up guys!");
        }
        public override void Fuel()
        {
            Console.WriteLine("We're fueled up and to cool for school");
        }
        public override void Maintain()
        {
            Console.WriteLine("This bird is in tip top shape");
        }
    }
}

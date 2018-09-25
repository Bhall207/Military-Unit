using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Humvee: Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("vroom vroom, souds a littel rough but ole betty still has a little life in her");
        }
        public override void Move()
        {
            Console.WriteLine("The humvee has moved");
        }
        public override void Fuel()
        {
            Console.WriteLine("Old Betty is all fueled up");
        }
        public override void Maintain()
        {
            Console.WriteLine("looks like everything on this humvee is good");
        }
    }
}

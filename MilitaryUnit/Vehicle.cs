using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("CLICK CLICK CLICK CLICK, darn this old thing need some elbow grease");
        }
        public virtual void Move()
        {
            Console.WriteLine("the vehicle has moved");
        }
        public virtual void Fuel()
        {
            Console.WriteLine("This ole gas guzzeler is full of fuel");
        }
        public virtual void Maintain()
        {
            Console.WriteLine("Inspection passed ! Everthing is in tip top shape ");
        }
    }
}

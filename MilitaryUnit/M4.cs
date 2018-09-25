using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class M4: WeaponSystem
    {
        public override void LoadWeapon()
        {
            Console.WriteLine("the m4 weapon system is loaded");
        }
        public override void Shoot()
        {
            Console.WriteLine("pew pew pew");
        }
        public override void Clear()
        {
            Console.WriteLine("weapon is cleared");
        }
        public override void Clean()
        {
            Console.WriteLine("YUP, this thing is clean enough to eat off of");
        }
    }
}

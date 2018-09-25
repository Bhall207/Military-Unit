using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    public class WeaponSystem
    {
        public virtual void LoadWeapon()
        {
            Console.WriteLine("load up gals it time to shoot some bad guys");
        }
        public virtual void Shoot()
        {
            Console.WriteLine("pew pew pew");
        }
        public virtual void Clear()
        {
            Console.WriteLine("weapon is cleared");
        }
         public virtual void Clean()
        {
            Console.WriteLine("YUP, this thing is clean enough to eat off of");
        }
    }
}

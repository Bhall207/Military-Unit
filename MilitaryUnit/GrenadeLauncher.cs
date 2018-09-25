using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class GrenadeLauncher: WeaponSystem
    {
        public void Fire()
        {
            Console.WriteLine("BOOOOOOMMMMMM!!!");
        }
    }
}

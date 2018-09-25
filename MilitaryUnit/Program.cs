using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitaryUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle a10 = new Plane();
            Plane f22 = new Plane();
            Vehicle hh60 = new Helicopter();
            Helicopter ah64 = new Helicopter();

            WeaponSystem M16A = new WeaponSystem();    
            WeaponSystem M4A4 = new WeaponSystem();
            GrenadeLauncher grenadeLauncher = new GrenadeLauncher();
            Patrol patrolMission = new Patrol();

            ah64.Start();
            f22.Fuel();
            patrolMission.HighValueTarget();
            M4A4.Shoot();
            M16A.Shoot();
            M4A4.Clear();
            M16A.Clear();
            patrolMission.MissionComplete();







        }
    }
}

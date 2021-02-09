using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    class Weapon
    {
        public string weaponType;

        public Weapon(string weapon)
        { 
            weaponType = weapon;
        }
        public void ChooseYourWeapon()
        {
            Console.WriteLine($"You have chosen: {weaponType}");
           
        }
    }
}
//sword action: swing,block-- robot attack ability:punch,flip
//fire action:shootfire,block--dinosaur ability; bite,throw
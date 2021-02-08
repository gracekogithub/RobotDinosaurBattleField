using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    class Weapon
    {
        public string weaponName;
        
        public int attack;
        public int defense;
       

        public Weapon()
        { 
            weaponName = "Sword";
           
            attack = 0;
            
        }
        public void ChooseYourWeapon()
        {
            Console.WriteLine("You have chosen: ");
            Console.ReadLine();
        }
    }
}
//sword action: swing,block-- robot attack ability:punch,flip
//fire action:shootfire,block--dinosaur ability; bite,throw
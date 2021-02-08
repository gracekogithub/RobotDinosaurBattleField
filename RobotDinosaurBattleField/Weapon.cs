using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    class Weapon
    {
        string robotWeapon1;
        string dinosaurWeapon1;

        public Weapon()
        {
            robotWeapon1 = "Sword";
            dinosaurWeapon1 = "Fire";
            //sword action: swing,block-- robot attack ability:punch,flip
            //fire action:shootfire,block--dinosaur ability; bite,throw
        }
    }
}

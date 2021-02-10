using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    
  public class Weapon
    {
        public string weaponType;
        public int attackPower;
        public Weapon(string weaponType, int attackPower)
        {
            this.weaponType = weaponType;
            this.attackPower = attackPower;
           
        }
    }
    
}
//sword action: swing,block-- robot attack ability:punch,flip
//fire action:shootfire,block--dinosaur ability; bite,throw
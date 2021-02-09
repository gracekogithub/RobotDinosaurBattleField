using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    class Fleet
    {
        public string roboWeapon;
        public Robot roboHealth;
        public int robotEnergy;
        public List<Robot> fleet;
     

        public Fleet()
        {
            fleet = new List<Robot>();
            Robot robot1 = new Robot("Stan");
            Robot robot2 = new Robot("Bob");
            Robot robot3 = new Robot("King");
            fleet.Add(robot1);
            fleet.Add(robot2);
            fleet.Add(robot3);

            
            

        }
    }
}

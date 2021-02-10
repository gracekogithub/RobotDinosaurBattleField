using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    public class Fleet
    {
        
        public List<Robot> fleet;

        public Fleet()
        {
            fleet = new List<Robot>();
            
            Robot robot1 = new Robot("Stan","ok",5);
            Robot robot2 = new Robot("Bob","better", 10);
            Robot robot3 = new Robot("King","best", 20);
            fleet.Add(robot1);
            fleet.Add(robot2);
            fleet.Add(robot3);
        }
       
    }
}


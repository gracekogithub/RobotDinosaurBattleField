using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    class Robot
    {
        string robotName; 
        int robotHealth;

        public Robot(string robotName)
        {
            this.robotName = robotName;
        }

        public void NameYourRobot()
        {
            string robotName = "RoboKing";
            Console.WriteLine(robotName);
        }
    }
}

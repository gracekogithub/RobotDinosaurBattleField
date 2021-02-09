using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    class Dinosaur
    {
        public string dinosaurType;
        public int dinoHealth;
        public int attack;
        public int count;


        public Dinosaur(string dinoType)
        {
            //List<Dinosaur> dino = new List<Dinosaur>();

            dinosaurType = dinoType;
            dinoHealth = 100;
            attack = 10;
            count = 0;
        }
        public void AttackRobot(Robot robot)
        {
            robot.roboHealth -= attack;
            Console.WriteLine($"{dinosaurType} attacks {robot.robotName} for {attack}");
        }
    }
}

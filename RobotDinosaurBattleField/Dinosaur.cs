using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    class Dinosaur
    {
        public string dinosaurName;
        public int dinoHealth;
        public int defense;
        public int attack;


        public Dinosaur(string dinosaurName)
        {
            this.dinosaurName = dinosaurName;
            dinoHealth = 100;
            defense = 0;
            attack = 10;
        }
        public void Attack(Robot robot)
        {
            robot.Health = robot.Health - attack;
            Console.WriteLine($"{dinosaurName} attacks {robot.robotName} for {attack}");
        }
    }
}

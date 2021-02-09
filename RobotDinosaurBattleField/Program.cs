using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    class Program
    {
        static void Main(string[] args)
        {
            // BattleField battlefield = new BattleField();
            Dinosaur dino1 = new Dinosaur("DinoX");
            Dinosaur dino2 = new Dinosaur("DinoY");
            Dinosaur dino3 = new Dinosaur("DinoZ");
            Robot robot1 = new Robot("Stan");
            Robot robot2 = new Robot("Bob");
            Robot robot3 = new Robot("King");
            dino1.AttackRobot(robot1);
            robot2.AttackDino(dino2);
            dino2.AttackRobot(robot2);
            robot3.AttackDino(dino3);

            Console.WriteLine(robot1.roboHealth);
            Console.WriteLine(dino2.dinoHealth);
            Console.WriteLine(robot2.roboHealth);
            Console.WriteLine(dino3.dinoHealth);
            Console.ReadLine();
        }
    }
}

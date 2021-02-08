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
            Robot robot1 = new Robot("Stan");
            dino1.Attack(robot1);

            Console.WriteLine(robot1.Health);
            Console.ReadLine();
        }
    }
}

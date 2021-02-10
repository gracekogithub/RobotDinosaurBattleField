using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    class BattleField
    {
        public int round;
        public Fleet roboFleet;
        public Herd dinoHerd;
        public int dinoHealthTotal;
        public int roboHealthTotal;
        public int attack;
        public Robot robot;
        


        public BattleField()
        {
            round = 0;
            roboFleet = new Fleet();
            dinoHerd = new Herd();
            dinoHealthTotal = 100;
            roboHealthTotal = 100;
            attack =20;
            robot = new Robot("");

        }

        

        public void RunBattle()
        {
            Console.WriteLine("Welcome");

            
         

            roboFleet.fleet[0].AttackDino(dinoHerd.herd[0]);
            dinoHerd.herd[0].AttackRobot(roboFleet.fleet[0]);
            TurnAttack();

        }

        
        public void TurnAttack()
        {
            if (attack==100)
            {
                Console.WriteLine("");
            }
            if (dinoHealthTotal == 0 && roboHealthTotal > 0)
            {
                Console.WriteLine("Robot wins");
            }
            if (roboHealthTotal==0 && dinoHealthTotal >0)
            {
                Console.WriteLine("Dinosaur wins");
            }
        }
    }
}
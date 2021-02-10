using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    class BattleField
    {
        public int countRobo;
        public int countDino;
        public Fleet roboFleet;
        public Herd dinoHerd;
        public int dinoHealthTotal;
        public int roboHealthTotal;
        public Robot robot;


        public BattleField()
        {
            roboFleet = new Fleet();
            dinoHerd = new Herd();
            dinoHealthTotal = 100;
            roboHealthTotal = 100;
            

        }

        public void RunBattle()
        {
            Console.WriteLine("Welcome to Robot vs Dinosaur Battlefield!\n " +
                "The robot team will attack first.");
            TurnAttack();
            

        }
        
        public void TurnAttack()
        {
          
            int countRobo = roboFleet.fleet.Count;
            int countDino = dinoHerd.herd.Count;
            roboFleet.fleet[0].AttackDino(dinoHerd.herd[0]);

            int i = 0; i++;
            if (roboFleet.fleet.Count > dinoHerd.herd.Count)
            {
                roboFleet.fleet[0].AttackDino(dinoHerd.herd[0]);
                Console.WriteLine("This round, Robot wins");
                (dinoHerd.herd).RemoveAt(0);
                i++;
            }
            if (roboFleet.fleet.Count < dinoHerd.herd.Count)
            {
                dinoHerd.herd[0].AttackRobot(roboFleet.fleet[0]);
                Console.WriteLine("This round, Dinosaur wins");
                (roboFleet.fleet).RemoveAt(0);
                i++;
            }
           
            if (roboFleet.fleet.Count == 0 || dinoHerd.herd.Count == 0 )
            {
                Console.WriteLine("Game Over!");
            }
            
            
        }
    }
    
}
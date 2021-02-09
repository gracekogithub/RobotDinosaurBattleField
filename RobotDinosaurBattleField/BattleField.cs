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
        public int score;
        public Fleet roboFleet;
        public Herd dinoHerd;
       


        public BattleField()
        {
            round = 0;
            score = 0;
            Fleet roboFleet = new Fleet();
            Herd dinoHerd = new Herd();
        }
        //start playing -load weapon-attack-win-lose---

        public void RunBattle() //main method
        {
            roboFleet.fleet[0].AttackDino(dinoHerd.herd[0]);
            dinoHerd.herd[0].AttackRobot(roboFleet.fleet[0]);

                Console.WriteLine();
            

            
            //Console.WriteLine(roboFleet.fleet[0].robotName);
            
        }
        
    }
}

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
        public Fleet fleet;
        public Herd herd;
        
        
        public BattleField()
        {
            Fleet fleet = new Fleet();
            Herd herd = new Herd();
            round = 0;
            score = 0;
        }
        //start playing -load weapon-attack-win-lose---

        public void RunBattle() //main method
        {

        }
        public void Example()
        {
            Console.WriteLine(fleet.fleet[0].robotName);
            //fleet.fleet[0].Attck(herd.herd[0])
        }
        public void DinoAttackRobo()
        {
            
        }
    }
}

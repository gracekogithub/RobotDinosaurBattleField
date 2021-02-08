using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    class Robot
    {
        public string robotName;
        
        public int Health;
        public int attack;
        public int defense;
        public int count;

        public Robot(string name)
        {
            List<Robot> robot = new List<Robot>();
            
            robotName = name;
            Health = 200;
            attack = 0;
            defense = 0;
            count = 0;
        }

        public void PickRoboWeapon()
        {
            Console.WriteLine("RoboKing loaded a weapon");
            
        }
        //public void SwingSword()
        //{
        //    swing++;
        //    if (swing > 1)
        //    {
        //        Console.WriteLine("RoboKing got 10 point");
        //    }
        //    else
        //    {

        //    }

        //}
        //public void CalculateRoboHealth()
        //{
        //    if (robotHealth <= 0)
        //    {
        //        Console.WriteLine("RoboKing lost the game.");
        //    }
        //    else 
        //    {
        //        Console.WriteLine("RoboKing! Please continue to play.");
        //    }
        //}
       
    }
}

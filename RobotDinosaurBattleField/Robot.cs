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
        public int roboHealth;
        public int attack;
        public int powerLevel;
        
        public Robot(string name)
        {
            List<Robot> robot = new List<Robot>();
            
            robotName = name;
            roboHealth = 100;
            attack = 10;
            powerLevel = 5;
        }

        public void AttackDino(Dinosaur dino)
        {
            dino.dinoHealth -= attack;
            Console.WriteLine($"{robotName} attack {dino.dinosaurType} for {attack}.  ");
            powerLevel--;

        }
        public void PickRoboWeapon()
        {
            Console.WriteLine($"{robotName} loaded a {Weapon.}");

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

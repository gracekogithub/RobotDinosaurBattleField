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
            //List<Robot> robot = new List<Robot>();
            
            robotName = name;
            roboHealth = 100;
            attack = 20;
            powerLevel = 5;
        }

        public void AttackDino(Dinosaur dinos)
        {
            Console.WriteLine($"{robotName} attack {dinos.dinosaurType} for {attack}, " +
            $"and {robotName} got {attack} points and power lever up as {powerLevel++} ");
            dinos.dinoHealth -= attack;
          
        }
      
        public void ChoseYourWeapon(Weapon weaponType)
        {
            Console.WriteLine($"{robotName} loaded a {weaponType}");

        }
       
        //    

 
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

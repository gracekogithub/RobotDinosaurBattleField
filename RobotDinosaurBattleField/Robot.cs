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
      
        public int roundWin;
        public Weapon weapon;
      
      

        public Robot(string name)
        {
            //List<Robot> robot = new List<Robot>();
            
            robotName = name;
            roboHealth = 100;
            attack = 50;
            powerLevel = 5;
            weapon = new Weapon("Sword");

            roundWin = 0;
           
         
        }

        public void AttackDino(Dinosaur dinos)
        
        
        {
            Console.WriteLine($"{robotName} attack {dinos.dinosaurType} for {attack}, " +
            $"and {robotName} got {attack} points and power lever up as {powerLevel++} ");
            dinos.dinoHealth -= attack;
          
        }
      
        public void ChoseYourWeapon()
        {
            Console.WriteLine($"{robotName} loaded a {weapon}");
            Console.ReadLine();
        }
        }
    }

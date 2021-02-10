using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    class Dinosaur
    {
        public string dinosaurType;
        public int dinoHealth;
        public int attack;
        public int dinoEnergyLevel;
        public Weapon dinoWeapon;
        


        public Dinosaur(string dinoType)
        {
            //List<Dinosaur> dino = new List<Dinosaur>();

            dinosaurType = dinoType;
            dinoHealth = 100;
            attack = 50;
            dinoEnergyLevel = 5;
            dinoWeapon = new Weapon("Sword");
        }
        public void AttackRobot(Robot robot)//method1 
        {
           robot.roboHealth -= attack;
           Console.WriteLine($"{dinosaurType} attacks {robot.robotName} for {attack}," +
                    $" and {dinosaurType} gained Energy Level {dinoEnergyLevel++}");
        }
    }
}

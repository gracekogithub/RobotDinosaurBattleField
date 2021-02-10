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
        public int dinoAttack;
        public int dinoEnergyLevel;
        
        


        public Dinosaur(string dinoType)
        {
            //List<Dinosaur> dino = new List<Dinosaur>();

            dinosaurType = dinoType;
            dinoHealth = 100;
            dinoAttack = 50;
            dinoEnergyLevel = 5;
            
            
        }
        public void AttackRobot(Robot robot)//method1 
        {
            robot.roboHealth -= dinoAttack;
            Console.WriteLine($"{dinosaurType} attacks {robot.robotName} for {dinoAttack}," +
                     $" and {dinosaurType} gained {robot.roboHealth -= dinoAttack} and Energy Level {dinoEnergyLevel + 1}");
        }
    }
}

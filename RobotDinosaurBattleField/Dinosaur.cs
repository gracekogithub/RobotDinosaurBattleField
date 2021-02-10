using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    public class Dinosaur
    {
        public string dinoType;
        public int dinoHealth;
        public int dinoAttackPower;
        public int dinoEnergyLevel;
        
        


        public Dinosaur(string dinoType, int dinoAttackPower)
        {
            //List<Dinosaur> dino = new List<Dinosaur>();

            dinoType = dinoType;
            dinoHealth = 100;
            this.dinoAttackPower = dinoAttackPower;
            dinoEnergyLevel = 5;
            
            
        }
        public void AttackRobot(Robot robot)//method1 
        {
            robot.roboHealth -= dinoAttackPower;
            Console.WriteLine($"{dinoType} attacks {robot.robotName} for {dinoAttackPower}," +
                     $" and {dinoType} gained {robot.roboHealth -= dinoAttackPower} and Energy Level {dinoEnergyLevel + 1}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    public class Robot
    {
        public string robotName;
        public int roboHealth;
        public int powerLevel;
        public Weapon weapon;
        public int roboAttackPower;

        public Robot(string robotName, string weapon, int weaponAttack)
        {
            this.robotName = robotName;
            roboHealth = 100;
            powerLevel = 5;
            this.weapon = new Weapon("Sword",20);
            roboAttackPower = 20;
            powerLevel = 100;
        }

        public void AttackDino(Dinosaur dinos)
        {

            int resultR = dinos.dinoHealth -= roboAttackPower;
            Console.WriteLine($"{robotName} attack {dinos.dinoType} for {roboAttackPower}, " +
            $"and {robotName} power lever up as {powerLevel + 1} ");

            
        }

    }
}

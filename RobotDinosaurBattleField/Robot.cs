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
        public int roboAttack;
        public int powerLevel;
      
        public int roundWin;
        public Weapon weapon;
        public int resultR;
      
      

        public Robot(string name)
        {
            //List<Robot> robot = new List<Robot>();
            
            robotName = name;
            roboHealth = 100;
            roboAttack = 50;
            powerLevel = 5;
            Weapon weapon= new Weapon("");
            roundWin = 0;
           
        }

        public void AttackDino(Dinosaur dinos)
        {

            int resultR = dinos.dinoHealth -= roboAttack;
            Console.WriteLine($"{robotName} attack {dinos.dinosaurType} for {roboAttack}, " +
            $"and {robotName} got {resultR} points and power lever up as {powerLevel + 1} ");

            ChooseYourWeapon();
        }

        public void ChooseYourWeapon()
        {
            Console.WriteLine($"{robotName} picked a sword.");
        }
    }
}

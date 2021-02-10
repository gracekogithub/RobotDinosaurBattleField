using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    public class BattleField
    {
        public bool roboTurn;
        public Fleet roboFleet;
        public Herd dinoHerd;
        public BattleField()
        {
            roboFleet = new Fleet();
            dinoHerd = new Herd();
            roboTurn = true;            
        }

        public void RunBattle()
        {
            Welcome();
            ChooseYourWeaponNow();
            AttackDinoNow();
            AttackRobotNow();
            ChooseRematch();
            Console.ReadLine();
        }
        public void Welcome()
        {
            Console.WriteLine("Welcome to Robot vs Dinosaur Battlefield!\n" +
                "The robot team will attack first.");
        }
        public void AttackRobotNow()
        {
            Console.WriteLine($"A dinosaur{dinoHerd.herd[0].dinoType} attacks a robot{roboFleet.fleet[0].robotName} now.");
        }
        public void ChooseYourWeaponNow()
        {
            Console.WriteLine($"{roboFleet.fleet[0].robotName} picked a sword.");
           
        }
        public void AttackDinoNow()
        {
            Console.WriteLine($"A Robot{roboFleet.fleet[0].robotName} attacks a {dinoHerd.herd[0].dinoType} now ");
        }
        public int ChooseRematch() 
        {
            Console.WriteLine();
            for (int i = 0; i < roboFleet.fleet.Count; i++)
            {
                Console.WriteLine("Choose a number " + i + " for " + roboFleet.fleet[i].robotName);
            }
            string userInput = Console.ReadLine();
            int convertedUserInput = Int32.Parse(userInput);
            return convertedUserInput;
        }
        public void TurnAttack(int attackIn, int defenseIn)
        {
            if (roboTurn == true)
            {
                roboFleet.fleet[attackIn].AttackDino(dinoHerd.herd[defenseIn]);
                if (dinoHerd.herd[defenseIn].dinoHealth <= 0)
                {
                    dinoHerd.herd.RemoveAt(defenseIn);
                    Console.WriteLine(dinoHerd.herd[defenseIn].dinoType + " was removed from the battlefield.");
                }
            }
            else
            {
                dinoHerd.herd[attackIn].AttackRobot(roboFleet.fleet[defenseIn]);
                if(roboFleet.fleet[defenseIn].roboHealth <= 0)
                {
                    roboFleet.fleet.RemoveAt(defenseIn);
                    Console.WriteLine(roboFleet.fleet[defenseIn].robotName + "has been removed. ");
                }
            }
            roboTurn = !roboTurn;
        }
    }

}
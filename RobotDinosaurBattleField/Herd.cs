using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    public class Herd
    {
        public List<Dinosaur> herd;

        public Herd()
        {
            herd = new List<Dinosaur>();
            Dinosaur dinosaur1 = new Dinosaur("DinoX", 20);
            Dinosaur dinosaur2 = new Dinosaur("DinoY", 20);
            Dinosaur dinosaur3 = new Dinosaur("DinoZ", 20);
            herd.Add(dinosaur1);
            herd.Add(dinosaur2);
            herd.Add(dinosaur3);
        }
        


    }
}

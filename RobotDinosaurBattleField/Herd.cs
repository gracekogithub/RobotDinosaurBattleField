using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleField
{
    class Herd
    {

        public int dinosaurEnergy;
        public List<Dinosaur> herd;



        public Herd()
        {
            herd = new List<Dinosaur>();
            Dinosaur dinosaur1 = new Dinosaur("DinoX");
            Dinosaur dinosaur2 = new Dinosaur("DinoY");
            Dinosaur dinosaur3 = new Dinosaur("DinoZ");
            herd.Add(dinosaur1);
            herd.Add(dinosaur2);
            herd.Add(dinosaur3);

            dinosaurEnergy = 5;
        }
        


    }
}

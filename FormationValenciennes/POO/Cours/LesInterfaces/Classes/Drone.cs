using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LesInterfaces.Interfaces;


namespace LesInterfaces.Classes
{
    internal class Drone : IVolant
    {
        public void Atterrir()
        {
            Console.WriteLine("J'atteris sur comme je peux... parfois sur le gens!");
        }

        public void Decoller()
        {
            Console.WriteLine("Je decolle à la verticale.");
        }

        public void Voler()
        {
            Console.WriteLine("Je vole tout seul...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LesInterfaces.Interfaces;


namespace LesInterfaces.Classes
{
    internal class Oiseau : IVolant , IAdresse
    {
        public void AdresseInformation()
        {
            throw new NotImplementedException();
        }

        public void Atterrir()
        {
            Console.WriteLine("J'atterris... comme je peux!");
        }

        public void Decoller()
        {
            Console.WriteLine("Je décolle depuis la branche d'un arbre");
        }

        public void Voler()
        {
            Console.WriteLine("Je peux voler grâce à des ailes");
        }
    }
}

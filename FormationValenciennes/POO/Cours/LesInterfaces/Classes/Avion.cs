using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LesInterfaces.Interfaces;

namespace LesInterfaces.Classes
{
    internal class Avion : IVolant
    {
        public void Atterrir()
        {
            Console.WriteLine("J'atteris sur une piste.");
        }

        public void Decoller()
        {
            Console.WriteLine("Je décolle depuis une piste.");
        }

        public void Voler()
        {
            Console.WriteLine("Je peux voler grace à la poussée de mes réacteurs");
        }
    }
}

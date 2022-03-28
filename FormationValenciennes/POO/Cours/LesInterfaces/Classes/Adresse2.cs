using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LesInterfaces.Interfaces;

namespace LesInterfaces.Classes
{
    internal class Adresse2 : IAdresse
    {
        public void AdresseInformation()
        {
            Console.WriteLine("J'affiche les informations depuis adresse 2");
        }
    }
}

using LesInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesInterfaces.Classes
{
    internal class TransportColis
    {
        private IVolant volant;

        public TransportColis(IVolant volant)
        {
            this.volant = volant;
        }

        public void Transporter()
        {
            volant.Decoller();
            volant.Voler();
            Console.WriteLine("Je transporte le colis");
        }

        public void Livrer()
        {
            volant.Atterrir();
            Console.WriteLine("Je Livre le colis!");
        }
    }
}

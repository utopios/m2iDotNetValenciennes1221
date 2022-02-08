using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage.Classes
{
    internal class Animal : EtreVivant
    {
        private bool battementCoeur;
        private string nomAnimal;
        private string typeAnimal;

        private protected bool BattementCoeur { get => battementCoeur; set => battementCoeur = value; }
        public string NomAnimal { get => nomAnimal; set => nomAnimal = value; }
        public string TypeAnimal { get => typeAnimal; set => typeAnimal = value; }

        public Animal(string nomAnimal, string typeAnimal) : base(nomAnimal, typeAnimal)
        {
            this.NomAnimal = nomAnimal;
            this.TypeAnimal = typeAnimal;
        }

       
        public override void Naissance()
        {
            BattementCoeur = true;
            Console.WriteLine("Mon coeur bat, je suis vivant");
        }

        public override void Mort()
        {
            battementCoeur = false;
            Console.WriteLine("Mon coeur s'est arrété, je suis mort!");
        }

       
    }
}

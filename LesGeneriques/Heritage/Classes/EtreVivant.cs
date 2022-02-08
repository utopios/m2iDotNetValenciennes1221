using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage.Classes
{
    internal class EtreVivant
    {
        bool vivant;
        private string nom;
        private string type;

        public EtreVivant(string nom, string type)
        {
            this.nom = nom;
            this.type = type;
        }

        public bool Vivant { get => vivant; set => vivant = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Type { get => type; set => type = value; }

       
        public virtual void Naissance()
        {
            vivant = true;
            Console.WriteLine("Tous les êtres vivants naissent...");
        }

        public virtual void Mort()
        {
            Console.WriteLine("Tous les êtres vivants meurent...");
        }

        public virtual void Alimentation()
        {
            Console.WriteLine("Tous les êtres vivants se nourissent...");
        }

        public virtual void Expression()
        {
            Console.WriteLine("Tous les êtres vivants s'expriment...");
        }

        public virtual void Reproduction()
        {
            Console.WriteLine("Tous les êtres vivants se reproduisent..");
        }
        public virtual void Oxigenation()
        {
            Console.WriteLine("Tous les êtres vivants s'oxigenent...");
        }

        public override string ToString()
        {
            return $"Je suis une être vivant de type {type} et je m'appelle {nom}";
        }

    }
}

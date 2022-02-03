using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionTPSalarie.Classes
{
    public class Salarie
    {
        private string matricule;
        private string categorie;
        private string service;
        private string nom;
        private decimal salaire;

        public string Matricule { get => matricule; set => matricule = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Service { get => service; set => service = value; }
        public string Nom { get => nom; set => nom = value; }
        public decimal Salaire { get => salaire; set => salaire = value; }

        public void AfficherSalaire()
        {
            Console.WriteLine($"Le salaire fixe de {Nom} est de  {Salaire} euros");
        }
    }
}

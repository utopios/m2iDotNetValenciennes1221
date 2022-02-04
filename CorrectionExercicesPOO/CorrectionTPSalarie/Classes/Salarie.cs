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
        private static decimal totalSalaires;
        private static int compteur = 0;
        public Salarie()
        {
            compteur++;
        }
        public Salarie(string matricule, string categorie, string service, string nom, decimal salaire) : this()
        {   
            Matricule = matricule;
            Categorie = categorie;
            Service = service;
            Nom = nom;
            Salaire = salaire;
        }

        public string Matricule { get => matricule; set => matricule = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Service { get => service; set => service = value; }
        public string Nom { get => nom; set => nom = value; }

        public static int Compteur { get => compteur; }
        public decimal Salaire
        {
            get => salaire; set
            {
                if(salaire > 0)
                {
                    totalSalaires -= salaire;
                }
                salaire = value;
                totalSalaires += value;
            }
        }



        public static decimal TotalSalaires { get => totalSalaires; }
        public void AfficherSalaire()
        {
            Console.WriteLine($"Le salaire fixe de {Nom} est de  {Salaire} euros");
        }

        public static void MettreAjourLeCompteur(int val = 0)
        {
            compteur = val;
        }

        public virtual void CalculerSalaire()
        {

        }
        public override string ToString()
        {
            return $"Nom {Nom}, Matrcicule {Matricule}, Catégorie {Categorie}, Service {Service}, Salaire {Salaire} euros";
        }
    }
}

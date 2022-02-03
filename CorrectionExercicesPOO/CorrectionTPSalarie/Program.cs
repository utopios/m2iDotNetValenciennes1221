using CorrectionTPSalarie.Classes;
using System;

namespace CorrectionTPSalarie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choix;
            do
            {
                Console.Write("Ajouter un salarie : (o/n) ");
                choix = Console.ReadLine();
                if(choix == "o")
                {
                    Salarie salarie = new Salarie();
                    Console.Write("Le matricule : ");
                    salarie.Matricule = Console.ReadLine();
                    Console.Write("Le service : ");
                    salarie.Service= Console.ReadLine();
                    Console.Write("La catégorie : ");
                    salarie.Categorie= Console.ReadLine();
                    Console.Write("Le Nom complet : ");
                    salarie.Nom = Console.ReadLine();
                    Console.Write("Le Salaire : ");
                    salarie.Salaire = Convert.ToDecimal(Console.ReadLine());
                    salarie.AfficherSalaire();
                }
            }while(choix != "n");

            Console.WriteLine($"Le total des salaires est de : {Salarie.TotalSalaires} euros");
        }
    }
}

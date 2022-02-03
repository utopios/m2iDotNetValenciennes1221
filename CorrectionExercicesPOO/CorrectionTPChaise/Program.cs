using CorrectionTPChaise.Classes;
using System;

namespace CorrectionTPChaise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choix;
            do
            {
                Console.Write("Un nouvelle chaise (o/n) ? ");
                choix = Console.ReadLine();
                if (choix == "o")
                {
                    Console.Write("Le nombre de pieds de la chaise : ");
                    int nbPieds = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Le type de matériaux de la chaise : ");
                    string materiaux = Console.ReadLine();
                    Console.Write("La couleur de la chaise : ");
                    string couleur = Console.ReadLine();
                    Chaise chaise = new Chaise(nbPieds, couleur, materiaux);
                    Console.WriteLine("--------- Affichage d'un nouvel objet ----------");
                    Console.WriteLine($"Je suis une chaise avec {chaise.NbPieds} en {chaise.Materiaux} et de couleur {chaise.Couleur}");
                    Console.WriteLine("------------------------------------------------");
                }
            } while (choix != "n");
        }
    }
}

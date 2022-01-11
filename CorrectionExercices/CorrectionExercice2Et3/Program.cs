using System;

namespace CorrectionExercice2Et3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez saisir votre nom : ");
            string nom = Console.ReadLine();
            Console.Write("Veuillez saisir votre prénom : ");
            string nomComplet = $"Bonjour {nom}";
            string prenom = Console.ReadLine();
            nomComplet = $"{nomComplet} {prenom}";
            Console.WriteLine(nomComplet);
        }
    }
}

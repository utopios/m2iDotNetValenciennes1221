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
            Console.Write("Veuillez saisir votre âge : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Marié ? ");
            bool marie = Convert.ToBoolean(Console.ReadLine());
            nomComplet = $"{nomComplet} {prenom} {age} {marie}";
            Console.WriteLine(nomComplet);


        }
    }
}

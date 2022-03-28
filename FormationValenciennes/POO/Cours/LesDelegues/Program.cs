using System;
using LesDelegues.Classes;
namespace LesDelegues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculatrice c = new ();
            // Utilisation de notre delegué avec une fonction Addition()
            c.Calcule(15, 20, Addition);

            // Utilisation de notre delegué avec une fonction Afficher()
            c.HowToDisplay("Salut !", Afficher);
            c.HowToDisplay("Salut !", AfficherPlus);

            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }

        // Création d'une fonction Addition prennant deux doubles en params
        public static double Addition(double a, double b) { return a + b; }

        // Création d'une fonction pour afficher une chaine de caractères
        public static void Afficher(string s)
        {
            Console.WriteLine(s);
        }

        public static void AfficherPlus(string s)
        {
            Console.WriteLine(s + " j'en affiche encore plus que l'autre méthode");
        }
    }
}

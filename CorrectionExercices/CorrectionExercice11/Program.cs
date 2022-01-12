using System;

namespace CorrectionExercice11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Le nombre est-il divisible par ... ?");
            Console.Write("Merci de saisir chiffre/nombre entier : ");
            int entier = Convert.ToInt32(Console.ReadLine());
            Console.Write("Merci de saisir chiffre/nombre diviseur: ");
            int diviseur = Convert.ToInt32(Console.ReadLine());
            string type;
            if(entier <= 9 && entier >= 0)
            {
                type = "chiffre";
            }
            else
            {
                type = "nombre";
            }
            if(entier % diviseur == 0)
            {                
                Console.WriteLine($"le {type} {entier} est divisible par {diviseur}");
            }
            else
            {
                Console.WriteLine($"le {type} {entier} n'est divisible par {diviseur}");
            }
        }
    }
}

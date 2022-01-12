using System;

namespace CorrectionExercice7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Merci de saisir la longueur du premier côté : ");
            double first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Merci de saisir la longueur du deuxième côté : ");
            double second = Convert.ToDouble(Console.ReadLine());
            double hypo = Math.Sqrt(Math.Pow(first,2) + Math.Pow(second,2));
            Console.WriteLine($"La valeur de l'hypothénuse est de {hypo}");
        }
    }
}

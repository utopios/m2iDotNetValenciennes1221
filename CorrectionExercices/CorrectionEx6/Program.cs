using System;

namespace CorrectionEx6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Calcul du périmètre et de l'aire d'un carré *****");
            Console.Write("Merci de saisir la longueur du côté : ");
            double cote = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"le périmètre du carré est de : {cote * 4}");
            Console.WriteLine($"l'aire du carré est de : {cote * cote}");
        }
    }
}

using System;

namespace CorrectionExercice8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Merci de saisir le prix HT du produit en Euros : ");
            decimal prixHT = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Merci de saisir le taux de tva en % : ");
            decimal tauxTVA = Convert.ToDecimal(Console.ReadLine());
            decimal TVA = prixHT * tauxTVA / 100;
            decimal prixTTC = prixHT + TVA;
            Console.WriteLine($"Le montant de la T.V.A est de {TVA} euros");
            Console.WriteLine($"Le montant TTC du produit est de {prixTTC} euros");
        }
    }
}

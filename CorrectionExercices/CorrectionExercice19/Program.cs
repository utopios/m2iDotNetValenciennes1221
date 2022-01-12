using System;

namespace CorrectionExercice19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Calcule Impôt ****");
            Console.Write("Merci de saisir le montant net imposable en euros : ");
            decimal net = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Merci de saisir le nombre d'adultes : ");
            int nombreAdulte = Convert.ToInt32(Console.ReadLine());
            Console.Write("Merci de saisir le nombre d'enfants : ");
            decimal nombreEnfant = Convert.ToInt32(Console.ReadLine());
            decimal nbPart = nombreAdulte;
            //if (nombreEnfant <= 2)
            //    nbPart += 0.5M * nombreEnfant;
            //else
            //    nbPart += (nombreEnfant - 1);
            //<=> ternaire
            nbPart += (nombreEnfant <= 2) ? 0.5M * nombreEnfant : (nombreEnfant - 1);
            decimal valInterval = net / nbPart;
            decimal taux = 0;
            decimal app = 0;
            switch(valInterval)
            {
                case (decimal n) when n < 10225:
                    taux = 0;
                    app = 0;
                    break;
                case (decimal n) when n >= 10225 && n < 26070:
                    taux = 0.11M;
                    app = 1124.75M;
                    break;
                case (decimal n) when n >= 26070 && n < 74545:
                    taux = 0.3M;
                    app = 6078.05M;
                    break;
                case (decimal n) when n >= 74545 && n < 160336:
                    taux = 0.41M;
                    app = 14278M;
                    break;
                case (decimal n) when n >= 160336 :
                    taux = 0.45M;
                    app = 20691.44M;
                    break;
                default:

                    break;
            }
            decimal impot = net * taux - app * nbPart;
            Console.WriteLine($"Le montant de vos impôt est de {Math.Round(impot)} euros");
        }
    }
}

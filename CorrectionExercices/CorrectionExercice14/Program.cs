using System;

namespace CorrectionExercice14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Quelle taille dois-je prendre ...? ****");
            Console.Write("Merci de saisir votre taille : ");
            double taille = Convert.ToDouble(Console.ReadLine());
            Console.Write("Merci de saisir votre poids : ");
            double poids = Convert.ToDouble(Console.ReadLine());
            int tailleVet = 0;
            if((taille >= 145 && taille <= 169 && poids >= 43 && poids <= 47) || (taille >= 145 && taille <= 166 && poids >= 48 && poids <= 53) || (taille >= 145 && taille <= 163 && poids >= 54 && poids <= 59) || (taille >= 145 && taille <= 160 && poids >= 60 && poids <= 65))
            {
                tailleVet = 1;
            }
            else if((taille >= 169 && taille <= 178 && poids >= 48 && poids <= 53) || (taille >= 166 && taille <= 175 && poids >= 54 && poids <= 59) || (taille >= 163 && taille <= 172 && poids >= 60 && poids <= 65) || (taille >= 160 && taille <= 169 && poids >= 66 && poids <= 71))
            {
                tailleVet = 2;
            }
            else if ((taille >= 178 && taille <= 183 && poids >= 54 && poids <= 59 ) || (taille >= 175 && taille <= 183 && poids >= 60 && poids <= 65) || (taille >= 172 && taille <= 183 && poids >= 66 && poids <= 71) || (taille >= 163 && taille <= 183 && poids >= 72 && poids <= 77))
            {
                tailleVet = 3;
            }

            if(tailleVet == 0)
            {
                Console.WriteLine("Aucune taille ne vous correspond");
            }
            else
            {
                Console.WriteLine($"Prennez la taille {tailleVet}");
            }
        }
    }
}

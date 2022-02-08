using System;

namespace CorrectionExercice12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Dans quelle catégorie mon enfant est-il ...? *****");
            Console.Write("Merci de saisir l'âge de votre enfant : ");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 3)
            {
                Console.WriteLine("Votre enfant est trop jeune");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Ce n'est plus un enfant");
            }
            else
            {
                string categorie;
                if (age >= 3 && age <= 6)
                {
                    categorie = "Baby";
                }
                else if (age >= 7 && age <= 8)
                {
                    categorie = "Poussin";
                }
                else if (age >= 9 && age <= 10)
                {
                    categorie = "Pupille";
                }
                else if (age >= 11 && age <= 12)
                {
                    categorie = "Minime";
                }
                else /*if (age >= 13)*/
                {
                    categorie = "Cadet";
                }
                //else
                //{
                //    categorie = "Aucune catégorie";
                //}
                Console.WriteLine($"Votre enfant est dans la catégorie {categorie}");
            }

        }
    }
}

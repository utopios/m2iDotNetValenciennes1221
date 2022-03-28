using System;

namespace PassageParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Le Passage d'arguments peut se faire par valeur ( pour les variabless de type valeur => Copie de la valeur)
             * Le Passage d'arguments peut se faire par référence ( pour les variables de type objet => Lecture et ecriture de la valeur)
             * Il possible de modifier ce comportement avec l'ajout de mot clé => IN , REF, OUT
             * IN => Pour passer un paramètre par référence avec l’intention d’éviter la copie, mais de ne pas changer la valeur.
             * REF=> Pour passer une valeur par référence => Afin de lire et modifier sa valeur
             * OUT=> la valur n'est pas lu mais ecrite en sortie de la fonction 
             */


            // OUT 
            //string ageStr= "20";
            int age;
            Console.Write("Veuillez saisir votre age :");

            //while(int.TryParse(ageStr, out age))
            while(!int.TryParse(Console.ReadLine(), out age))        
            {
                Console.Write("Erreur, Veuillez saisir votre age :");
            }

            Console.WriteLine($"Vous avez {age} ans.");






            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();

        }
    }
}

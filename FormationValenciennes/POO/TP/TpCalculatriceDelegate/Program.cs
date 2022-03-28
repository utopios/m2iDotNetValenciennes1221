using System;
using TpCalculatriceDelegate.Classes;

namespace TpCalculatriceDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Créer un programme console demandant la saisie de deux nombre à l'utilisateur et une fois fait
             * proposer un menu avec les 4 types d'opérations (+, - , / , *)
             * Afficher le résultat
             */

            // Declaration des variables
            double nb1, nb2, resultat=0;
            string choix = "0";


            // Récupération des saisies utilisateur
            Console.Write("Veuillez saisir un nombre : ");
            while(!double.TryParse(Console.ReadLine(), out nb1))
            {
                Console.Write("Erreur! Veuillez saisir un nombre : ");
            }

            Console.Write("Veuillez saisir un autre nombre : ");
            while (!double.TryParse(Console.ReadLine(), out nb2))
            {
                Console.Write("Erreur! Veuillez saisir un autre nombre : ");
            }

            while (choix !="1"&& choix !="2" && choix != "3" && choix != "4")
            {
                Console.Write("Veuillez saisir le type d'opération:\n\t1-Addition\n\t2-Soustraction\n\t3-Multiplication\n\t4-Division\n\nVotre choix : ");
                choix = Console.ReadLine();
            }

            Calculatrice c = new();

            switch (choix)
            {
                case "1":
                    resultat = c.Calcule(nb1, nb2, (a, b) => a + b);
                    break;
                case "2":
                    resultat = c.Calcule(nb1, nb2, (a, b) => a - b);
                    break;
                case "3":
                    resultat = c.Calcule(nb1, nb2, (a, b) => a * b);
                    break;
                case "4":
                    try
                    {
                        resultat = c.Calcule(nb1, nb2, SaveDivision);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        WaitUser();
                        Environment.Exit(0);
                    }                    
                    break;
            }


            // Affichage des résultats
            Console.WriteLine($"Le résultat est : {resultat}");




            WaitUser(); 
        }
        public static void WaitUser()
        {
            Console.WriteLine("Appuyez sur ENTER pour ferme le programme...");
            Console.Read();
        }

        public static double SaveDivision(double x , double y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException("Attention, vous tentez une division par 0");
            }
            return x / y;
        }
    }
}

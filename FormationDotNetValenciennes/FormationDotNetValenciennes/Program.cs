// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
namespace FormationDotNetValenciennes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Bonjour ");
            //Console.Write("toto");
            //Console.WriteLine("Hello World!");
            //Console.Write("All");
            //Console.WriteLine("Bonjour tout le monde");
            //string result;
            //Console.Write("Saisir un element : ");
            //string result = Console.ReadLine();
            ////Console.Read();
            //Console.WriteLine(result);

            //Déclarer une variable pour stocker le nom
            //CamelCase => façon de nommer les variables
            //string nomComplet = "abadi ihab";
            //Console.WriteLine(nomComplet);
            ////nomComplet = @"M. Abadi ihab \\ Tourcoing";
            //nomComplet = "M." + nomComplet;
            //Console.WriteLine(nomComplet);

            //double a = Math.Pow(100,2);
            //Console.WriteLine(a);
            //double b = Math.Sqrt(100);
            //Console.WriteLine(b);

            //int a = 10;
            //bool result = a < 5 || a > 20;
            //Console.WriteLine(result);
            //string chaine = "toto";
            //Console.WriteLine(chaine.ToUpper());
            //decimal solde = 100;
            //if(solde > 0)
            //{
            //    Console.WriteLine("Le compte est créditeur");        
            //    Console.WriteLine("Vous pouvez retirer de l'argent");
            //}
            //else if(solde == 0)
            //{
            //    Console.WriteLine("Le compte est vide");
            //}
            //else
            //{
            //    Console.WriteLine("Le compte est débiteur");
            //}

            int numeroMois = 2;
            string mois = null;
            //if(numeroMois == 1)
            //{
            //    mois = "Janvier";
            //}
            //else if(numeroMois == 2)
            //{
            //    mois = "Février";
            //}//....
            //<=>
            switch(numeroMois)
            {
                case 1:
                    Console.WriteLine("Janvier");
                    break;
                case 2:
                    Console.WriteLine("Février");
                    break;
                case 3:
                    Console.WriteLine("Mars");
                    break;
                default:
                    Console.WriteLine("erreur numéro mois");
                    break;
            }
        }
    }
}


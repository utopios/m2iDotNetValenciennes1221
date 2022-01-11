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
            string nomComplet = "abadi ihab";
            Console.WriteLine(nomComplet);
            //nomComplet = @"M. Abadi ihab \\ Tourcoing";
            nomComplet = "M." + nomComplet;
            Console.WriteLine(nomComplet);
        }
    }
}


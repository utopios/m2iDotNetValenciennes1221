using System;
using ExpressionsReguliere.Classes;

namespace ExpressionsReguliere
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Chloë@", "Di Persio", 25);

            Console.WriteLine(p1);




            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}


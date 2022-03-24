using System;
using ExpressionsReguliere.Classes;

namespace ExpressionsReguliere
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person("Chloé", "Di Persio", 25,"anthony@utopios.net");

            Console.WriteLine(p1);




            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}


using System;
using TpTheGreatTP.Classes;
namespace TpTheGreatTP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IHM ihm = new IHM();
            ihm.Start();

            Console.WriteLine("A bientôt ...");
            Console.Read();
        }
    }
}

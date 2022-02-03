using SuiteCoursPOO.Classes;
using System;

namespace SuiteCoursPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("toto", "tata", 33, 1);
            //Console.WriteLine(s.FirstName);
            s.Afficher();
        }
    }
}

using System;
using ExpressionsReguliere.Classes;

namespace ExpressionsReguliere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir votre nom : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre prénom : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre email : ");
            string email = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre téléphone : ");
            string phone = Console.ReadLine();

            bool valid = false;
            int age=0;
            string ageStr="";
            //while (!int.TryParse(ageStr, out age))
            //{
            //    Console.WriteLine("Veuillez saisir votre age : ");
            //    ageStr = Console.ReadLine();
            //}

            while (!valid)
            {
                Console.WriteLine("Veuillez saisir votre age : ");
                ageStr = Console.ReadLine();
                valid = Tools.IsNumeric(ageStr);
                if (valid)
                {
                    age = Convert.ToInt32(ageStr);
                }
                else
                {
                    Console.WriteLine("Veuillez saisir un nombre...");
                }
            }

            Person p1 = new Person(firstName, lastName, age, email, phone);


            Console.WriteLine(p1);




            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}


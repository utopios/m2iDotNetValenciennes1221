using System;
using System.Text.RegularExpressions;
using ExpressionsReguliere.Classes;

namespace ExpressionsReguliere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FormatPhone
            string userPhone ="";

            while (!Tools.IsPhone(userPhone))
            {
                Console.WriteLine("Veuillez saisir un numéro de téléphone : ");
               
                userPhone = Console.ReadLine();
            }


            userPhone = Tools.FormatPhone(userPhone);
            Console.WriteLine(userPhone);

            // SPLIT
            string[] tabString= Regex.Split(userPhone, @"\s");

            foreach (string str in tabString)
            {
                Console.WriteLine(str);
            }



            // REPLACE() => Remplace un caractere recherché par un autre
            string maChaine = "Bonjour,          je     m'appelle       Anthony      ";
            Console.WriteLine(Tools.ClearMultipleSpace(maChaine));



            Console.WriteLine("Veuillez saisir votre nom : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre prénom : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre email : ");
            string email = Console.ReadLine();
            Console.WriteLine("Veuillez saisir votre téléphone : ");
            string phone =Tools.FormatPhone(Console.ReadLine());

            bool valid = false;
            int age=0;
            

            while (!valid)
            {
                Console.WriteLine("Veuillez saisir votre age : ");
                string ageStr = Console.ReadLine();
                valid = Tools.IsNumeric(ageStr);
                if (valid)                
                    age = Convert.ToInt32(ageStr);                
                else                
                    Console.WriteLine("Veuillez saisir un nombre...");                
            }

            Person p1 = new Person(firstName, lastName, age, email, phone);


            Console.WriteLine(p1);

            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}


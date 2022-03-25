using LesExceptions.Classes;
using System;

namespace LesExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new();
   
            try
            {
                Console.Write("Veuillez saisir votre nom : ");
                p1.LastName = Console.ReadLine();
                Console.Write("Veuillez saisir votre prénom : ");
                p1.FirstName = Console.ReadLine();
                Console.Write("Veuillez saisir votre téléphone : ");
                p1.Phone = Console.ReadLine();
                Console.Write("Veuillez saisir votre email : ");
                p1.Email = Console.ReadLine();
                Console.Write("Veuillez saisir votre age : ");
                p1.Age = Convert.ToInt32(Console.ReadLine());
            }
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine("Autre chose : ",ex.Message);
            }



            Console.WriteLine(p1);
            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}

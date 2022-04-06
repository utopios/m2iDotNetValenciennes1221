using CoursHashMD5.Models;
using System;

namespace CoursHashMD5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.Login = "SuperAdmin";
            u.Password = "SuperAdmin";

            u.Add();


            Console.WriteLine("Hello World!");
            Console.Read();
        }
    }
}

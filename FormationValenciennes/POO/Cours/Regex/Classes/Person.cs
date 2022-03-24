using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionsReguliere.Classes
{
    public class Person 
    {
        private string firstName;
        private string lastName;
        private string email;
        private int age;

        public Person()
        {

        }

        public Person(string firstName, string lastName, int age, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
        }

        public string FirstName 
        { 
            get => firstName;
            set
            {
                if (Tools.IsName(value))                
                    firstName = value;                
                else
                    Console.WriteLine("Erreur prénom...");
            }
        }

        public string LastName 
        { 
            get => lastName;
            set
            {
                if (Tools.IsName(value))
                    lastName = value;
                else
                    Console.WriteLine("Erreur nom...");
            }
        }

        public int Age { get => age; set => age = value; }
        public string Email 
        {
            get => email;
            set
            {
                if (Tools.IsEmail(value))
                    email = value;
                else
                    Console.WriteLine("Erreur email...");
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {Age} ans - {Email}";
        }       
    }
}

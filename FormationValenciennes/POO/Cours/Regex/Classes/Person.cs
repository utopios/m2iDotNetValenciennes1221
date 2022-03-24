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
        private int age;

        public Person()
        {

        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
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

        public string LastName { get => lastName; set => lastName = value; }

        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {Age} ans";
        }       
    }
}

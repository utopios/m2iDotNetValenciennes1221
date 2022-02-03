using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiteCoursPOO.Classes
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

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }

        public virtual void Afficher()
        {
            Console.WriteLine($"{FirstName} {LastName} {Age}");
        }
    }
}

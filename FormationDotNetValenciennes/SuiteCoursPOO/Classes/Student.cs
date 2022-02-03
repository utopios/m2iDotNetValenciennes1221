using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiteCoursPOO.Classes
{
    public class Student : Person
    {
        //private string firstName;
        //private string lastName;
        //private int age;

        private int level;

        public Student():base()
        {
        }

        public Student(string firstName, string lastName, int age, int level):base(firstName, lastName, age)
        {
            //this.FirstName = firstName;
            //this.LastName= lastName;
            //this.Age = age;
            this.Level = level;
        }

        //public string FirstName { get => firstName; set => firstName = value; }
        //public string LastName { get => lastName; set => lastName = value; }
        //public int Age { get => age; set => age = value; }
        public int Level { get => level; set => level = value; }
    }
}

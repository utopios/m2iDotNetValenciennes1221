using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuiteCoursPOO.Classes
{
    public class Teacher : Person
    {
        private string course;
        public Teacher(string firstName, string lastName, int age, string course) : base(firstName, lastName, age)
        {
            Course = course;
        }

        public string Course { get => course; set => course = value; }

        public void AfficherSpecialTeacher()
        {
            Console.WriteLine("Special teacher");
        }
    }
}

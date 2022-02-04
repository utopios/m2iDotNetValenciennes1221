using SuiteCoursPOO.Classes;
using System;

namespace SuiteCoursPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[2];
            Student s = new Student("toto", "tata", 33, 1);
            //Console.WriteLine(s.FirstName);
            //s.Afficher();
            s.AfficherSpecialStudent();
            Console.WriteLine(s);
            Teacher t1 = new Teacher("jean", "dupond", 50, "c#");
            t1.AfficherSpecialTeacher();
            
            persons[0] = t1;
            persons[1] = s;

            foreach(Person person in persons)
            {
                Console.WriteLine(person.GetType());
                person.Afficher();
            }
            Person p = new Person();
            //Person sp = new Student("titi", "minet", 50, 1);
            //sp.Afficher();          
        }
    }
}

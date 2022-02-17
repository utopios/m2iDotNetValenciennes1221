using System.Collections.Generic;

namespace FormationAspNETCore.Models
{
    public class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phone;
        private static int counter = 0;
        public static List<Person> Liste = new List<Person> { new Person() { FirstName = "Toto", LastName = "Titi", Phone = "+33 6 14 52 63 87" }, new Person() { FirstName = "Doe", LastName = "John", Phone = "+33 6 14 85 96 32" }
    };

    public Person()
        {
            Id = ++counter;
        }

        public Person(string firstName, string lastName, string phone) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public static int Counter { get => counter; }

        public static List<Person> GetPersons()
        {
            return Liste; 
        }

        public static Person GetPersonById(int id)
        {           
            return Liste[id-1];
        }
    }
}

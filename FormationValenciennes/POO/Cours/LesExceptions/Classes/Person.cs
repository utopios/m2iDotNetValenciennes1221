using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesExceptions.Classes
{
    public class Person 
    {
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private int age;

        public Person()
        {

        }

        public Person(string firstName, string lastName, int age, string email, string phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            Phone = phone;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (Tools.IsName(value))
                    firstName = value;
                else
                    throw new FormatException("Erreur prénom...");
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
                    throw new FormatException("Erreur nom...");
            }
        }

        public int Age
        {
            get => age;
            set
            {
                if (value > 0 && value < 126)
                    age = value;
                else
                    throw new FormatException("Erreur age...");
            }
        }
        public string Email
        {
            get => email;
            set
            {
                if (Tools.IsEmail(value))
                    email = value;
                else
                    throw new FormatException("Erreur email...");
            }
        }

        public string Phone
        {
            get => phone;
            set
            {
                if (Tools.IsPhone(value))
                    phone = value;
                else
                    throw new FormatException("Erreur phone...");
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} - {Age} ans \n\tEmail : {Email}\n\tPhone : {Phone}";
        }
    }
}

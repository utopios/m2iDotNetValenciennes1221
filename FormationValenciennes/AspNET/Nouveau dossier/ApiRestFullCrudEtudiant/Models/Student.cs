using System.Collections.Generic;

namespace ApiRestFullCrudEtudiant.Models
{
    public class Student
    {
        private int id;
        private string gender;
        private string firstName;
        private string lastName;
        private string email;
        private int studentNumber;

        public Student()
        {

        }


        public Student(string gender, string firstName, string lastName, string email, int studentNumber)
        {
            Gender = gender;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            StudentNumber = studentNumber;
        }

        public int Id { get => id; set => id = value; }
        public string Gender { get => gender; set => gender = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int StudentNumber { get => studentNumber; set => studentNumber = value; }

        public int Add()
        {
            return Stu
        }

        public static List<Student> Get()
        {

        }
    }
}

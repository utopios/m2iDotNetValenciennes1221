namespace EFCoreDemo.Models
{
    public class Student
    {
        private int id;
        private string firstname;
        private string lastname;
        private string phone;
        private string email;

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
    }
}

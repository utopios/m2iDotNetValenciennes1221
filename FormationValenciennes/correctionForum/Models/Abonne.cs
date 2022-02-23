namespace correctionForum.Models
{
    public class Abonne
    {

        private int id;
        private string firstName;
        private string lastName;
        private string phone;
        private string email;
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public string Phone
        {
            get => phone;
            set => phone = value;
        }

        public string Email
        {
            get => email;
            set => email = value;
        }
    }
}
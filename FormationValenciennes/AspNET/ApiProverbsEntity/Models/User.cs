namespace ApiProverbsEntity.Models
{
    public class User
    {
        private int id;
        private string userName;
        private string password;
        private string token;
        private bool _isAdmin;

        public int Id { get => id; set => id = value; }
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public string Token { get => token; set => token = value; }
        public bool IsAdmin { get => _isAdmin; set => _isAdmin = value; }
    }
}

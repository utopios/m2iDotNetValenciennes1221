using ApiRestFullCrudEtudiant.Tools;
using Microsoft.Data.SqlClient;

namespace HashMD5.Models
{
    public class User
    {
        private int id;
        private string login;
        private string password;
        private string token;

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Token { get => token; set => token = value; }

        private int Add()
        {
            SqlConnection connection = Connection.New;
            SqlCommand command = new SqlCommand("INSERT INTO User (login, password) OUTPUT INSERTED.Id VALUES (@Login, @Password)", connection);
            command.Parameters.Add(new SqlParameter("@Login", Login));
            command.Parameters.Add(new SqlParameter("@Password", Password));
            

            connection.Open();
            Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();

            return Id;
        }
    }
}

using CoursHashMD5.Tools;
using Microsoft.Data.SqlClient;
using System;
using System.Security.Cryptography;

namespace CoursHashMD5.Models
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

        public int Add()
        {
            // Creation d'une instance de MD5
            MD5 md5HAsh = MD5.Create();

            string MdpHash = MyMD5.GetHashMD5( md5HAsh , Password);
            Console.WriteLine(MdpHash);

            SqlConnection connection = Connection.New;
            SqlCommand command = new SqlCommand("INSERT INTO Users (login, password) OUTPUT INSERTED.Id VALUES (@Login, @Password)", connection);
            command.Parameters.Add(new SqlParameter("@Login", Login));
            command.Parameters.Add(new SqlParameter("@Password", MdpHash));
            

            connection.Open();
            Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();

            return Id;
        }
    }
}

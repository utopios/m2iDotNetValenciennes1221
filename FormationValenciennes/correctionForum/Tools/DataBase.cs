using System.Data.SqlClient;

namespace correctionForum.Tools
{
    public class DataBase
    {
        private static string connectionString = "";
        public static SqlConnection Connection
        {
            get => new SqlConnection(connectionString);
        }
    }
}
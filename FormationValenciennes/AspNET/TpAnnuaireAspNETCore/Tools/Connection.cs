using Microsoft.Data.SqlClient;


namespace TpAnnuaireAspNETCore.Tools
{
    public class Connection
    {
        static string connectionString = @"Data Source=(LocalDB)\M2iValenciennes;Integrated Security=True";
        public static SqlConnection New { get => new SqlConnection(connectionString);}
    }
}

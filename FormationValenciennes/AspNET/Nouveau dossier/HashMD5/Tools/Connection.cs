using Microsoft.Data.SqlClient;

namespace ApiRestFullCrudEtudiant.Tools
{
    public class Connection
    {
        private static string chaine = @"Data Source=(LocalDB)\M2iValenciennes;Integrated Security=True";

        public static SqlConnection New { get => new SqlConnection(chaine); }
    }
}

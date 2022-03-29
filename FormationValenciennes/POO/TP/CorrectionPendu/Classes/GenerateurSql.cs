using CorrectionPendu.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPendu.Classes
{
    internal class GenerateurSql : IGenerateur
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        private string request;
        public string Generer()
        {
            //Rechercher aleatoirement un mot à partir d'une table mots
            string response = null;
            request = "SELECT TOP 1 mot FROM MOTS ORDER BY newid()";
            connection = new SqlConnection(@"Data Source=(LocalDB)\M2iValenciennes;Integrated Security=True");
            command = new SqlCommand(request, connection);
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                response = reader.GetString(0);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return response;
        }
    }
}

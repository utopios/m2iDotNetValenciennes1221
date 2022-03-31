using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace BanqueAdoNET.Data
{
    class DataBase
    {
        private static string chaine = @"Data Source=(Localdb)\M2IValenciennes;Integrated Security=True";

        public static SqlConnection Connection { get => new SqlConnection(chaine); }
    }
}

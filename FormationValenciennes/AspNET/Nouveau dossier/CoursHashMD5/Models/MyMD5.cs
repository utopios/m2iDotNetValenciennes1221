using System.Security.Cryptography;
using System.Text;

namespace CoursHashMD5.Models
{
    public class MyMD5
    {
        public static string GetHashMD5( MD5 md5Hash,string input)
        {
            // Créations d'un tableau de bytre recevant notre parametre (input) une fois hashé
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));


            // String Builder Instance
            StringBuilder sBuilder = new StringBuilder();

            for(int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }


            // Return de la chaine construite pas SBuilder
            return sBuilder.ToString();
        }
    }
}

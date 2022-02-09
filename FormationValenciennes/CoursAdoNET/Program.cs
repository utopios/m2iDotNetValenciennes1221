using Microsoft.Data.SqlClient;
using System;

namespace CoursAdoNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ADO.NET Mode Connecté
            // Connection à la BDD
            string connectionString = @"Data Source=(LocalDB)\M2iValenciennes;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);

            // Pour executer une requete SQl dans un programme Ado.NET => Utilisation d'un objet command
            // Préparation de la commande
            // string request = "INSERT INTO UTILISATEUR (nom, prenom,email,telephone) VALUES ('Toto','Titi','toto@gmail.com','+33 6 41 52 63 78') ";
            // string request2 = "INSERT INTO UTILISATEUR (nom, prenom,email,telephone) OUTPUT INSERTED.Id VALUES ('Duss','Jean-Claude','jcd@gmail.com','+33 6 74 21 85 74') ";
            //string request3 = "SELECT id, nom, prenom,email,telephone FROM UTILISATEUR";
            
            
            //SqlCommand command = new SqlCommand(request3, connection);

            //// Ouverture de la connection
            //connection.Open();

            //// 1ere méthode d'execution d'une commande => Retourne le nombre de lignes affectées par la commande 
            //int nbLigne = command.ExecuteNonQuery();
            //Console.WriteLine("Nombre de lignes affectées : " + nbLigne);

            //// 2eme méthode d'execution d'une commande => Retourne le nombre champ indiqué dans la requete 
            //int Id = (int)command.ExecuteScalar();
            //Console.WriteLine("Id d'insertion dans la table : " + Id);

            //// 3eme méthode d'execution de la commande => Avec un reader
            //SqlDataReader reader = command.ExecuteReader();

            //while (reader.Read())
            //{
            //    Console.WriteLine($"Id : {reader.GetInt32(0)}, Nom : {reader.GetString(1)}, Prénom : {reader.GetString(2)}, Email : {reader.GetString(3)},  Téléphone : {reader.GetString(4)}");
            //}

            //// Libération du reader
            //reader.Close();

            //// Liberation de l'objet command
            //command.Dispose();

            //// Fermeture de la connection à la BDD
            //connection.Close(); 






            #endregion










            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}

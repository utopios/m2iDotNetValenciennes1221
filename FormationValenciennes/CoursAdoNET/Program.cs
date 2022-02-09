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

            ///
            /// Avec récupération des saisies utilisateur => Parametres (SqlParameters)
            ///

            // Executer les requêtes avec des variables => On utilise pour cela une requête préparée avec des paramètres
            Console.Write("Merci de saisir votre nom : ");
            string nom = Console.ReadLine();
            Console.Write("Merci de saisir votre prénom : ");
            string prenom = Console.ReadLine();
            Console.Write("Merci de saisir votre email : ");
            string email = Console.ReadLine();
            Console.Write("Merci de saisir votre téléphone : ");
            string telephone = Console.ReadLine();

            // Préparation de la commande
            string request = $"INSERT INTO UTILISATEUR (nom, prenom, email, telephone) VALUES (@nom, @prenom, @email, @telephone)";
            //string request = $"INSERT INTO UTILISATEUR (nom, prenom, email, telephone) OUTPUT INSERTED.Id VALUES (@nom, @prenom, @email, @telephone)";
            SqlCommand command = new SqlCommand(request, connection);
            // Ajout de parametres 
            command.Parameters.Add(new SqlParameter("@nom", nom));
            command.Parameters.Add(new SqlParameter("@prenom", prenom));
            command.Parameters.Add(new SqlParameter("@email", email));
            command.Parameters.Add(new SqlParameter("@telephone", telephone));

            // Ouverture de la connection
            connection.Open();

            // 1ere méthode d'execution d'une commande => Retourne le nombre de lignes affectées par la commande 
            int nbLigne = command.ExecuteNonQuery();
            Console.WriteLine("Nombre de lignes affectées : " + nbLigne);

            //// 2eme méthode d'execution d'une commande => Retourne le nombre champ indiqué dans la requete 
            //int Id = (int)command.ExecuteScalar();
            //Console.WriteLine("Id d'insertion dans la table : " + Id);


            // Liberation de l'objet command
            command.Dispose();

            // Fermeture de la connection à la BDD
            connection.Close();
            #endregion










            Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
            Console.Read();
        }
    }
}

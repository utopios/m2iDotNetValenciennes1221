using CorrectionAnnuaireAdoNet.Tools;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionAnnuaireAdoNet.Classes
{
    public class Contact
    {
        private int id;
        private string firstName;
        private string lastName;
        //private string email;
        private string phone;
        private static string request;
        private static SqlConnection connection;
        private static SqlCommand command;
        private static SqlDataReader reader;

        public List<Email> Emails { get; set; }
        public Contact()
        {
        }

        public Contact(int id, string firstName, string lastName, string phone)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            //this.Email = email;
            this.Phone = phone;
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
       // public string Email { get => email; set => email = value; }
        public string Phone { get => phone; set => phone = value; }

        public bool Save()
        {
            request = "INSERT INTO utilisateur (nom, prenom, telephone) OUTPUT INSERTED.ID values (@nom, @prenom, @telephone)";
            connection = DataBaseTools.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@nom", LastName));
            command.Parameters.Add(new SqlParameter("@prenom", FirstName));
            //command.Parameters.Add(new SqlParameter("@email", Email));
            command.Parameters.Add(new SqlParameter("@telephone", Phone));
            connection.Open();
            Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return Id > 0;
        }

        public bool Update()
        {
            //logique de mise à jour
            request = "UPDATE utilisateur set nom=@nom, prenom=@prenom, telephone=@telephone where id=@id";
            connection = DataBaseTools.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@nom", LastName));
            command.Parameters.Add(new SqlParameter("@prenom", FirstName));
            //command.Parameters.Add(new SqlParameter("@email", Email));
            command.Parameters.Add(new SqlParameter("@telephone", Phone));
            command.Parameters.Add(new SqlParameter("@id", Id));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;        
        }

        public bool Delete()
        {
            //logique  pour supprimer
            request = "DELETE FROM utilisateur where id=@id";
            connection = DataBaseTools.Connection;
            command = new SqlCommand(request, connection);         
            command.Parameters.Add(new SqlParameter("@id", Id));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;          
        }

        public static Contact SearchByPhone(string phone)
        {
            //logique pour chercher un contact par téléphone
            Contact contact = null;
            request = "SELECT id, nom, prenom, from utilisateur where telephone=@phone";
            connection = DataBaseTools.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@phone", phone));
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
               contact = new Contact(reader.GetInt32(0), reader.GetString(2), reader.GetString(1), phone);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            if (contact != null)
                contact.Emails = Email.GetContactEmails(contact.Id);
            return contact;
        }
        public static List<Contact> GetContacts()
        {
            //Logique pour chercher liste des contacts
            List<Contact> contacts = new List<Contact>();
            request = "SELECT id, nom, prenom, email,telephone from utilisateur";
            connection = DataBaseTools.Connection;
            command = new SqlCommand(request, connection);

            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Contact contact = new Contact(reader.GetInt32(0), reader.GetString(2), reader.GetString(1), reader.GetString(4));
                contacts.Add(contact);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return contacts;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Phone}";
        }
    }
}

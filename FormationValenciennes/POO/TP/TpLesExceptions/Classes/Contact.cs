using TpLesExceptions.Tools;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLesExceptions.Classes
{
    public class Contact
    {
        private int id;
        private string firstName;
        private string lastName;
        private string email;
        private string phone;
        private int age;
        private static string request;
        private static SqlConnection connection;
        private static SqlCommand command;
        private static SqlDataReader reader;

        public Contact()
        {

        }

        public Contact(int id, string lastname, string firstname,string email, string phone,int age)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Phone = phone;
            Age = age;
        }

        public int Id 
        { 
            get => id;
            set
            {
                id = value;
            }
        }
        public string FirstName 
        { 
            get => firstName;
            set
            {
                if (Tools.IsAlphabetic(value))
                    firstName = value;
                else
                    throw new FormatException("Erreur, le prénom doit commencer par une majuscule et ne comporter que de des lettres, des espaces, le tiret haut (-) et caractères accentués (é,è,ë).");
            }
        }
        public string LastName 
        { 
            get => lastName;
            set
            {
                if (Tools.IsAlphabetic(value))
                    lastName = value;
                else
                    throw new FormatException("Erreur, le nom doit commencer par une majuscule et ne comporter de des lettres, des espaces, le tiret haut (-) et caractères accentués (é,è,ë).");
            }
        }
        public string Phone 
        { 
            get => phone;
            set
            {
                if (Tools.IsPhone(value))
                    phone = value;
                else
                    throw new FormatException("Erreur, le téléphone doit correspondre aux formats suivants : +33 X XX XX XX XX / 33 X XX XX XX XX / 0X XX XX XX XX.");
            }
        }
        public string Email 
        { 
            get => email;
            set
            {
                if (Tools.IsEmail(value))
                    email = value;
                else
                    throw new FormatException("Erreur, l'email doit correspondre aux formats suivants : abc@def.gh");
            }
        }
        public int Age 
        { 
            get => age;
            set
            {
                if (value > 0 && value < 126)
                    age = value;
                else
                    throw new FormatException("Erreur, l'age doit être un chiffe/nombre, vérifiez votre saisie.");
            }
        }

        public bool Save()
        {
            request = "INSERT INTO CONTACT (lastname, firstname, email, phone, age) OUTPUT INSERTED.ID values (@nom, @prenom, @email, @telephone, @age)";
            connection = DataBaseTools.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@nom", LastName.ToUpper()));
            command.Parameters.Add(new SqlParameter("@prenom", FirstName));
            command.Parameters.Add(new SqlParameter("@email", Email.ToLower()));
            command.Parameters.Add(new SqlParameter("@telephone", Tools.FormatPhone(Phone)));
            command.Parameters.Add(new SqlParameter("@age", Age));
            connection.Open();
            Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return Id > 0;
        }

        public bool Update()
        {
            //logique de mise à jour
            request = "UPDATE CONTACT set lastname=@nom, firstname=@prenom, email=@email, phone=@telephone, age=@age where id=@id";
            connection = DataBaseTools.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@nom", LastName.ToUpper()));
            command.Parameters.Add(new SqlParameter("@prenom", FirstName));
            command.Parameters.Add(new SqlParameter("@email", Email.ToLower()));
            command.Parameters.Add(new SqlParameter("@telephone", Tools.FormatPhone(Phone)));
            command.Parameters.Add(new SqlParameter("@age", Age));
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
            request = "DELETE FROM CONTACT where id=@id";
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
            request = "SELECT id, lastname, firstname, email, phone, age FROM CONTACT WHERE phone=@phone";
            connection = DataBaseTools.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@phone", phone));
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
               contact = new Contact(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), phone, reader.GetInt32(5));
            }
            reader.Close();
            command.Dispose();
            connection.Close();

            return contact;
        }
        public static List<Contact> GetContacts()
        {
            //Logique pour chercher liste des contacts
            List<Contact> contacts = new List<Contact>();
            request = "SELECT id,lastname, firstname, email, phone, age from CONTACT";
            connection = DataBaseTools.Connection;
            command = new SqlCommand(request, connection);

            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Contact contact = new Contact(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetInt32(5));
                contacts.Add(contact);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return contacts;
        }

        public string Display()
        {
            return $"\n{Id} - {FirstName} {LastName} => {age} ans\n\tEmail : {Email}\n\tTéléphone : {Phone}\n";
        }

        public override string ToString()
        {
            return $"\n{Id} - {FirstName} {LastName} => {Phone}\n";
        }        
    }
}

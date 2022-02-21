using TpAnnuaireAspNETCore.Models;
using TpAnnuaireAspNETCore.Tools;
using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Text;

namespace TpAnnuaireAspNETCore.DAO
{
    class ContactDAO : AbstractDAO<Contact>
    {
        public override bool Create(Contact element)
        {
            request = "INSERT INTO contact(firstName, lastName, email, phone, url) " +
                "OUTPUT INSERTED.ID VALUES (@firstName, @lastName, @email, @phone, @url)";
            connection = Connection.New;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@firstName", element.FirstName));
            command.Parameters.Add(new SqlParameter("@lastName", element.LastName));
            command.Parameters.Add(new SqlParameter("@email", element.Email));
            command.Parameters.Add(new SqlParameter("@phone", element.Phone));
            command.Parameters.Add(new SqlParameter("@url", element.Url));
            connection.Open();
            element.Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return element.Id > 0;
        }

        public override bool Delete(Contact element)
        {
            request = "DELETE FROM contact WHERE id=@id";
            connection = Connection.New;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@id", element.Id));
            connection.Open();
            int nbrLigne = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbrLigne > 0;
        }

        public override Contact Find(int index)
        {
            Contact contact = null;
            request = "SELECT id, firstname, lastname,email, phone,url FROM contact WHERE id=@id";
            connection = Connection.New;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@id", index));
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                contact = new Contact
                {
                    Id = index,
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Email = reader.GetString(3),
                    Phone = reader.GetString(4),
                    Url = reader.GetString(5)
                };
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return contact;
        }

        public override List<Contact> Find(Func<Contact, bool> criteria)
        {
            List<Contact> contacts = new List<Contact>();
            FindAll().ForEach(c =>
            {
                if (criteria(c))
                {
                    contacts.Add(c);
                }
            });
            return contacts;
        }

        public override List<Contact> FindAll()
        {
            List<Contact> contacts = new List<Contact>();
            request = "SELECT id, firstname, lastname, email, phone,url FROM contact";
            connection = Connection.New;
            command = new SqlCommand(request, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Contact c = new Contact
                {
                    Id = reader.GetInt32(0),
                    FirstName = reader.GetString(1),
                    LastName = reader.GetString(2),
                    Email = reader.GetString(3),
                    Phone = reader.GetString(4),
                    Url = reader.GetString(5)
                };
                contacts.Add(c);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return contacts;
        }

        public override bool Update(Contact element)
        {
            request = "UPDATE contact SET firstname = @firstname, lastname = @lastname, email = @email, phone = @phone, url = @url WHERE id = @id";
            connection = Connection.New;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@firstname", element.FirstName));
            command.Parameters.Add(new SqlParameter("@lastname", element.LastName));
            command.Parameters.Add(new SqlParameter("@email", element.Email));
            command.Parameters.Add(new SqlParameter("@phone", element.Phone));
            command.Parameters.Add(new SqlParameter("@url", element.Url));
            command.Parameters.Add(new SqlParameter("@id", element.Id));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;
        }
    }
}

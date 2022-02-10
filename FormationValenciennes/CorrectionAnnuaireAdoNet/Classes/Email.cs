using CorrectionAnnuaireAdoNet.Tools;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionAnnuaireAdoNet.Classes
{
    public class Email: BaseModel<Email>
    {
        private int id;
        private string mail;
        private int contactId;
        //private static string request;
        //private static SqlConnection connection;
        //private static SqlCommand command;
        //private static SqlDataReader reader;

        public int Id { get => id; set => id = value; }
        public string Mail { get => mail; set => mail = value; }
        public int ContactId { get => contactId; set => contactId = value; }

        public Email(int id, string mail, int contactId) : this(mail, contactId)
        {
            Id = id;
           
        }

        public Email(string mail, int contactId)
        {
            Mail = mail;
            ContactId = contactId;
        }

        public override bool Save()
        {
            request = "INSERT INTO email (contact_id, mail)  OUTPUT INSERTED.ID values (@contact_id, @mail)";
            connection = DataBaseTools.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@contact_id", ContactId));
            command.Parameters.Add(new SqlParameter("@mail", Mail));
            connection.Open();
            Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return Id > 0;
        }

        public static List<Email> GetContactEmails(int contactId)
        {
            List<Email> emails = new List<Email>();
            request = "SELECT id, mail from email where contact_id = @contactId";
            connection = DataBaseTools.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@contactId", contactId));
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Email email = new Email(reader.GetInt32(0), reader.GetString(1), contactId);
                emails.Add(email);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return emails;
        }

        

        public override Email GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override List<Email> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}

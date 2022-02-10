using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionAnnuaireAdoNet.Classes
{
    public class Email
    {
        private int id;
        private string mail;
        private int contactId;

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

        public bool Save()
        {
            return false;
        }

        public static List<Email> GetContactEmails(int contactId)
        {
            return null;
        }

    }
}

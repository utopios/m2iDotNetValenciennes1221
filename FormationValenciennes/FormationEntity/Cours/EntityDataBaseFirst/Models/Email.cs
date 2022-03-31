using System;
using System.Collections.Generic;

#nullable disable

namespace EntityDataBaseFirst.Models
{
    public partial class Email
    {
        public Email()
        {
            StudentsEmails = new HashSet<StudentsEmail>();
        }

        public int Id { get; set; }
        public string Email1 { get; set; }

        public virtual ICollection<StudentsEmail> StudentsEmails { get; set; }
    }
}

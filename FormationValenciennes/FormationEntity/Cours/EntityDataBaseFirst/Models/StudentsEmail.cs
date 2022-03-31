using System;
using System.Collections.Generic;

#nullable disable

namespace EntityDataBaseFirst.Models
{
    public partial class StudentsEmail
    {
        public int StudentId { get; set; }
        public int EmailId { get; set; }

        public virtual Email Email { get; set; }
        public virtual Student Student { get; set; }
    }
}

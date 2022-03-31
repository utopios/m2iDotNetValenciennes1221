using System;
using System.Collections.Generic;

#nullable disable

namespace EntityDataBaseFirst.Models
{
    public partial class Student
    {
        public Student()
        {
            StudentsCourses = new HashSet<StudentsCourse>();
            StudentsEmails = new HashSet<StudentsEmail>();
        }

        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string StudentCardId { get; set; }

        public virtual ICollection<StudentsCourse> StudentsCourses { get; set; }
        public virtual ICollection<StudentsEmail> StudentsEmails { get; set; }
    }
}

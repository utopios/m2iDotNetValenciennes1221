using System;
using System.Collections.Generic;

#nullable disable

namespace EntityDataBaseFirst.Models
{
    public partial class Course
    {
        public Course()
        {
            StudentsCourses = new HashSet<StudentsCourse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Professor { get; set; }

        public virtual ICollection<StudentsCourse> StudentsCourses { get; set; }
    }
}

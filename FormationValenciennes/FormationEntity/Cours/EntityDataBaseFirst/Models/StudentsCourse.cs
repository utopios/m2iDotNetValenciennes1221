using System;
using System.Collections.Generic;

#nullable disable

namespace EntityDataBaseFirst.Models
{
    public partial class StudentsCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreDemo.Models
{
    public class Course
    {
        private int id; 
        private string name;
        private string professor;
        private ICollection<Student> students;

        [Key]
        public int Id { get => id; set => id = value; }
        [Required]
        public string Name { get => name; set => name = value; }
        [Required]
        public string Professor { get => professor; set => professor = value; }
        
        public ICollection<Student> Students { get => students; set => students = value; }
    }
}


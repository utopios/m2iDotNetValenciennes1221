using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDemo.Models
{
    public class Student
    {
        private int id;
        private string firstname;
        private string lastname;
        private string phone;
        private string email;
        private ICollection<Course> courses;

        [Key]
        public int Id { get => id; set => id = value; }
        [Required]
        [Column("prenom")]
        public string Firstname { get => firstname; set => firstname = value; }
        [Required]
        [Column("nom")]
        public string Lastname { get => lastname; set => lastname = value; }
        [Required]
        [Column("telephone")]
        [MaxLength(17)]
        public string Phone { get => phone; set => phone = value; }
        [Required]
        [Column("email")]
        public string Email { get => email; set => email = value; }

        public ICollection<Course> Courses { get => courses; set => courses = value; }
    }
}

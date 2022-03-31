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
        [Required(ErrorMessage = "Veuillez saisir un prénom!")]
        [Column("prenom")]
        public string Firstname { get => firstname; set => firstname = value; }
        [Required(ErrorMessage ="Veuillez saisir un nom!")]
        [Column("nom")]
        public string Lastname { get => lastname; set => lastname = value; }
        [Required(ErrorMessage = "Veuillez saisir un téléphone!")]
        [Column("telephone")]
        [MaxLength(17)]
        public string Phone { get => phone; set => phone = value; }
        [Required(ErrorMessage = "Veuillez saisir un email!")]
        [Column("email")]
        public string Email { get => email; set => email = value; }

        public ICollection<Course> Courses { get => courses; set => courses = value; }
    }
}

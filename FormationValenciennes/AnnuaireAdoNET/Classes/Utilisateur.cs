using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnuaireAdoNET.Classes
{
    internal class Utilisateur
    {
        private int id;
        private string nom;
        private string prenom;
        private string email;
        private string telephone;

        public Utilisateur(string nom, string prenom, string email, string telephone)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.telephone = telephone;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public string Telephone { get => telephone; set => telephone = value; }

        // CRUD => Create , Read, Update, Delete 
        public void Add()
        {

        }

        public void Get()
        {

        }

        public void Update()
        {

        }

        public void Delete()
        {

        }
    }
}

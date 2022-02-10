using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaireHeritage.Classes
{
    internal class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private static int counter = 0;

        public Client()
        {
            Id=++counter;
        }
        //public Client(string name) : this()
        //{
        //    Nom = name;
        //}

        //public Client(int id) : this()
        //{
        //    Id = id;
        //}

        public Client(string nom, string prenom, string telephone) :this()
        {
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public static int Counter { get => counter; }

        public override string ToString()
        {
            return $"Id: {Id} - Nom : {Nom}, Prénom :{Prenom}, Téléphone : {Telephone}";
        }

        public bool Save()
        {
            return false;
        }
    }
}

using LesInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesInterfaces.Classes
{
    internal class Personne
    {
        private string nom;
        private string prenom;
        private IAdresse adresse;

        public Personne( IAdresse Adresse)
        {
            this.Adresse = Adresse;
            Adresse.AdresseInformation();
        }

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        internal IAdresse Adresse { get => adresse; set => adresse = value; }

        public override string ToString()
        {
            return $"Nom : {Nom} - Prénom : {Prenom}";
        }
    }
}

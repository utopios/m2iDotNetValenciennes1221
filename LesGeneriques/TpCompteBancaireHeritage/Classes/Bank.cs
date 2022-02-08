using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaireHeritage.Classes
{
    internal class Bank
    {
        private List<Compte> comptes;

        internal List<Compte> Comptes { get => comptes; set => comptes = value; }

        public Bank()
        {
            Comptes = new List<Compte>();
        }

        public bool AjouterCompte(Compte compte)
        {
            // Instruction pour ajouter un compte à la liste de compte 
            return true;
        }

        public Compte RechercherCompte(int id)
        {
            // Ecrire les instructions permettant de rechercher un compte dans la liste des comptes
            Compte compte = new Compte();
            return compte;
        }
    }
}

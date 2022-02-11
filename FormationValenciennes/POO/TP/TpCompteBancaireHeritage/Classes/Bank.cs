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
            //int avant = Comptes.Count;
            //Comptes.Add(compte);
            //int apres = Comptes.Count;
            //return apres - avant == 1? true : false;
            return compte.Client.Save() && compte.Save();

        }

        public Compte RechercherCompte(int id)
        {
            //Compte c = null;
            //c = Comptes.Find(c => c.Id == id);
            //return c;

            // Ecriture simplifiée
           // return Comptes.Find(c => c.Id == id);
           return Compte.GetCompteById(id);
        }
    }
}

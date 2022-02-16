using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCompteBancaireHeritageWPF.DAO;

namespace TpCompteBancaireHeritageWPF.Classes
{
    internal class CompteEpargne : Compte
    {
        private decimal taux;

        public decimal Taux { get => taux; set => taux = value; }

        public CompteEpargneDAO daoEpargne;

        public CompteEpargne(decimal taux) 
        {
            Taux = taux;
            daoEpargne= new CompteEpargneDAO();
        }
        public CompteEpargne(decimal solde, Client client, decimal taux) : base(solde, client)
        {
            Taux = taux;
            daoEpargne = new CompteEpargneDAO();
        }

        public override bool AjouterCompte()
        {
            return daoEpargne.Save(this);
        }

        public bool CalculerInteret()
        {
            return Depot(new Operation(Solde * Taux / 100));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaireHeritage.Classes
{
    internal class CompteEpargne : Compte
    {
        private double taux;

        public double Taux { get => taux; set => taux = value; }

        public CompteEpargne(double solde, Client client, double taux) : base(solde, client)
        {
            Taux = taux;
        }

        public bool CalculerInteret()
        {
            return Depot(new Operation(Solde * Taux / 100));
        }
    }
}

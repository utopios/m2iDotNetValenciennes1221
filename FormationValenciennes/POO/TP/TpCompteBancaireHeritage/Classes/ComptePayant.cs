using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaireHeritage.Classes
{
    internal class ComptePayant : Compte
    {
        private double coutOperation;

        public double CoutOperation { get => coutOperation; set => coutOperation = value; }

        public ComptePayant(double solde, Client client, double CoutOperation) : base(solde, client)
        {
            this.CoutOperation = CoutOperation;
        }

        public override bool Depot(Operation operation)
        {
            if (operation.Montant > CoutOperation)
            {
                if (base.Depot(operation))
                {
                    return base.Retrait(new Operation(CoutOperation * -1));
                }
                else
                    return false;
            }
            return false;
        }

        public override bool Retrait(Operation operation)
        {
            if (Solde >= Math.Abs(operation.Montant) + CoutOperation)
            {
                if (base.Retrait(operation))
                {
                    return base.Retrait(new Operation(CoutOperation * -1));
                }
                else
                    return false;
            }
            return false;
        }
    }
}

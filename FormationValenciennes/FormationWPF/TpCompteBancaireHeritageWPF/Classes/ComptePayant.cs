using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCompteBancaireHeritageWPF.DAO;

namespace TpCompteBancaireHeritageWPF.Classes
{
    internal class ComptePayant : Compte
    {
        private decimal coutOperation;

        public decimal CoutOperation { get => coutOperation; set => coutOperation = value; }

        public ComptePayantDAO daoPayant;

        public ComptePayant(decimal CoutOperation)
        {
            this.CoutOperation = CoutOperation;
            daoPayant= new ComptePayantDAO();
        }
        public ComptePayant(decimal solde, Client client, decimal CoutOperation) : base(solde, client)
        {
            this.CoutOperation = CoutOperation;
            daoPayant = new ComptePayantDAO();
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

        public override bool AjouterCompte()
        {
            return daoPayant.Save(this);
        }
    }
}

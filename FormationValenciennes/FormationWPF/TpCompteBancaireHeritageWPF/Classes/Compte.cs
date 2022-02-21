using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCompteBancaireHeritageWPF.DAO;
using TpCompteBancaireHeritageWPF.Tools;

namespace TpCompteBancaireHeritageWPF.Classes
{
    public class Compte 
    {
        private int id;
        private decimal solde;
        private Client client;
        private List<Operation> operations;
        private static int counter = 0;
        private CompteDAO compteDAO;
        private OperationDAO operationDAO;

        public Compte()
        {
            //id = ++counter;
            Operations = new List<Operation>();
            compteDAO = new CompteDAO();
        }

        public Compte(decimal solde, Client client) : this()
        {            
            Solde = solde;
            Client = client;            
        }

        public int Id { get => id; set => id = value; }
        public decimal Solde { get => solde; set => solde = value; }
        internal Client Client { get => client; set => client = value; }
        internal List<Operation> Operations { get => operations; set => operations = value; }
        public static int Counter { get => counter; }

        public virtual bool Depot(Operation operation)
        {
            
            operationDAO = new OperationDAO();
            if (operation.Montant > 0)
            {
                //if(operation.Save(Id))
                if(operationDAO.Save(operation, Id))
                {
                    Operations.Add(operation);
                    Solde += operation.Montant;
                    return compteDAO.Update(this);
                }               
            }
            return false;    
        }

        public virtual bool Retrait(Operation operation)
        {
            compteDAO = new CompteDAO();
            operationDAO = new OperationDAO();
            if (operation.Montant < 0 && Solde >= Math.Abs(operation.Montant))
            {
                if (operationDAO.Save(operation, Id))
                {
                    Operations.Add(operation);
                    Solde += operation.Montant;
                    return compteDAO.Update(this);
                }
            }
            return false;
        }

        public virtual bool AjouterCompte()
        {            
            return  compteDAO.Save(this);
        }
        
        public Compte RechercherCompte(int id)
        {
            return compteDAO.Get(id);
        }
        public override string ToString()
        {
            string result = $"Client : {Client}\n";
            result += $"\n\t\t\t\t\t\tSolde : {Solde} Euros";
            result += $"\n------------------- Operations -------------------\n";
            Operations.ForEach(o =>
            {
                result += $"{o}\n";
            });
            result += $"--------------------------------------------------\n";

            return result;
        }
        
    }
}

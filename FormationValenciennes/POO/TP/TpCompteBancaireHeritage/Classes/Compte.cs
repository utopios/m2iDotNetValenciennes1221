using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaireHeritage.Classes
{
    internal class Compte
    {
        private int id;
        private double solde;
        private Client client;
        private List<Operation> operations;
        private static int counter = 0;

        public Compte()
        {
            id = ++counter;
            Operations = new List<Operation>();
        }

        public Compte(double solde, Client client) : this()
        {            
            Solde = solde;
            Client = client;            
        }

        public int Id { get => id; set => id = value; }
        public double Solde { get => solde; set => solde = value; }
        internal Client Client { get => client; set => client = value; }
        internal List<Operation> Operations { get => operations; set => operations = value; }
        public static int Counter { get => counter; }

        public virtual bool Depot(Operation operation)
        {
            if (operation.Montant > 0)
            {
                Operations.Add(operation);
                Solde += operation.Montant;
                return true;
            }
            return false;    
        }

        public virtual bool Retrait(Operation operation)
        {
            if (operation.Montant < 0)
            {
                Operations.Add(operation);
                Solde += operation.Montant;
                return true;
            }
            return false;
        }

        public virtual bool AjouterCompte(Bank bank)
        {            
            return bank.AjouterCompte(this); ;
        }
        
        public static Compte RechercherCompte(Bank bank,int id)
        {
            return bank.RechercherCompte(id);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaireHeritage.Classes
{
    internal class IHM
    {
        Bank bank;

        public IHM()
        {
            bank = new Bank();
        }

        public void Start()
        {
            Menu();
            string choix = Console.ReadLine();
            do
            {
                switch (choix)
                {
                    case "1":
                        ActionCreationCompte();
                        break;
                    case "2":
                        ActionDepot();
                        break;
                    case "3":
                        ActionRetrait();
                        break;
                    case "4":
                        ActionAffichageCompte();
                        break;
                    case "5":
                        ActionCalculInterets();
                        break;
                }
            } while (true);
        }

        private void Menu()
        {

        }

        public void ActionCreationCompte()
        {
            // Création d'un client

            // Création du compte (Compte, CompteEpargne,ComptePayant)
        }

        public void ActionDepot()
        {
            // Collecter les éléments pour créer un dépot:
            // Trouver le compte
            // Montant => créer l'opération
            // Ajouter l'opération a la liste des opération du compte
            // Update le solde du compte
        }

        public void ActionRetrait()
        {
            // Collecter les éléments pour créer un retrait:
            // Trouver le compte
            // Montant => créer l'opération
            // Ajouter l'opération a la liste des opération du compte
            // Update le solde du compte
        }

        public void ActionAffichageCompte()
        {
            Compte c = null;
            c = ActionRechercherCompte();
            Console.WriteLine(c);
            if(c != null)
            {
                // Recupérer l'id au client (fait)
                // Rechercher le compte avec l'id (fait)
                // Afficher le compte (fait)
            }
            else            
                Console.WriteLine("Erreur, veuille choisir un compte valable...");           
        }

        public void ActionCalculInterets()
        {
            Compte c = ActionRechercherCompte();
            // Recupérer l'id au client
            // Rechercher le compte avec l'id
            // Vérifier qu'il s'agit d'un compte épargne ( typeof() )
            // Calculer les intérêts
            // Ajouter l'opération
            // Update le solde
        }

        public Compte ActionRechercherCompte()
        {
            Console.Write("Veuillez saisir l'id du compte : ");
            int id = Convert.ToInt32(Console.ReadLine());
            return Compte.RechercherCompte(bank, id);
        }
    }
}

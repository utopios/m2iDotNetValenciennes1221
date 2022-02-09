using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpCompteBancaireHeritage.Data;

namespace TpCompteBancaireHeritage.Classes
{
    internal class IHM
    {
        Bank bank;

        public IHM()
        {
            bank = new Bank();
            ClientCompteInjection.Injecter(bank);
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
            Console.WriteLine("\n--------------- Banque Peu Populaire -------------\n");
            Console.WriteLine("1- Créer un compte bancaire");
            Console.WriteLine("2- Effectuer un dépôt");
            Console.WriteLine("3- Effectuer un retrait");
            Console.WriteLine("4- Opérations et solde");
            Console.WriteLine("5- Calcul Interêts\n");
            Console.WriteLine("0---Quitter\n");

            Console.Write("Faites votre choix : ");
        }

        public void ActionCreationCompte()
        {
            Client client = new Client();

            Compte compte = new Compte();   

            compte.AjouterCompte(bank);
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
                Console.WriteLine("Erreur, veuillez choisir un compte valable...");           
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

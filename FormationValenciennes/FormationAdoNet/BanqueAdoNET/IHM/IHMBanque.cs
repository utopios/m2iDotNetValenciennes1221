using BanqueAdoNET.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BanqueAdoNET.IHM
{
    class IHMBanque
    {
        public IHMBanque()
        {
           
        }

        public void Start()
        {
            string choix;
            do
            {
                Menu();
                choix = Console.ReadLine();
                Console.Clear();
                switch(choix)
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
                        ActionInteret();
                        break;
                }
            } while (choix != "0");
        }
        private void Menu()
        {
            Console.WriteLine("\n--------------- Banque -------------" + Environment.NewLine);
            Console.WriteLine("1- Créer un compte bancaire");
            Console.WriteLine("2- Effectuer un dépôt");
            Console.WriteLine("3- Effecteur un retrait");
            Console.WriteLine("4- Opérations et solde");
            Console.WriteLine("5- Calcule Interet\n");
            Console.WriteLine("0---Quitter\n");

            Console.Write("Faites votre choix : ");
        }

        private void TryRead(string message, Action ReadElement)
        {
            bool convertOk = false;
            do
            {
                Console.Write(message);
                try
                {
                    ReadElement();
                    convertOk = true;
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);                    
                }
            } while (!convertOk);
        }

        private void ActionCreationCompte()
        {
            Console.WriteLine("--- Création client ---");
            Client client = new Client();           
            TryRead("Merci de saisir le nom : ", () => client.Nom = Console.ReadLine());
            TryRead("Merci de saisir le prénom : ", () => client.Prenom = Console.ReadLine());
            TryRead("Merci de saisir le téléphone : ", () => client.Telephone= Console.ReadLine());
            client.Id = client.Add();
            decimal solde = 0;
            Console.WriteLine("--- Création Compte ---");
            TryRead("Solde Initial : ", () => solde = Convert.ToDecimal(Console.ReadLine()));
            Console.WriteLine("1---Compte normal");
            Console.WriteLine("2---Compte épargne");
            Console.WriteLine("3---Compte payant");
            string choix = Console.ReadLine();
            Compte compte = null;
            if(choix == "1")
            {
                compte = new Compte(solde, client);
            }
            else if(choix == "2")
            {
                Console.Write("le taux d'épargne : ");
                decimal t = Convert.ToDecimal(Console.ReadLine());
                compte = new CompteEpargne(solde, client,t);
            }
            else if(choix == "3")
            {
                Console.Write("le coût d'opération : ");
                decimal cout = Convert.ToDecimal(Console.ReadLine());
                compte = new ComptePayant(solde, client, cout);
            }
            else
            {
                Console.WriteLine("Erreur type compte");
            }
            if(compte != null)
            {
                compte.ADecouvert += Compte.ActionNotificationDecouvert;
                if(compte.AjouterCompte())
                {
                    Console.WriteLine($"Compte ajouté avec le numéro {compte.Id}");
                }
                else
                {
                    Console.WriteLine("Erreur ajout compte");
                }
            }
        }

        private void ActionDepot()
        {
            Compte compte = ActionRechercheCompte();

            if(compte != null)
            {
                Console.Write("Merci de saisir le montant du dépôt : ");
                decimal montant = Convert.ToDecimal(Console.ReadLine());
                Operation operation = new Operation(montant);
                if (compte.Depot(operation))
                {
                    Console.WriteLine("Dépôt efféctué");
                } else
                {
                    Console.WriteLine("Erreur dépôt");
                }
            }
        }

        private void ActionRetrait()
        {
            Compte compte = ActionRechercheCompte();
            if (compte != null)
            {
                Console.Write("Merci de saisir le montant du retrait : ");
                decimal montant = Convert.ToDecimal(Console.ReadLine());
                Operation operation = new Operation(montant * -1);
                if (compte.Retrait(operation))
                {
                    Console.WriteLine("Retrait efféctué");
                }
                else
                {
                    Console.WriteLine("Erreur retrait");
                }
            }
        }

        private void ActionAffichageCompte()
        {
            Compte compte = ActionRechercheCompte();
            if(compte != null)
            {
                Console.WriteLine(compte);
            }
        }

        private void ActionInteret()
        {
            Compte compte = ActionRechercheCompte();
            if(compte!= null && compte is CompteEpargne compteEpargne)
            {
                if (compteEpargne.CalculeInteret())
                {
                    Console.WriteLine("Interêt ajouté");
                }                
            }
        }

        private Compte ActionRechercheCompte()
        {
            Console.Write("Merci de saisir le numéro de compte : ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Compte compte = Compte.RechercherCompte(numero);
            if(compte == null)
            {
                Console.WriteLine("Aucun compte avec ce numéro");
            }
            return compte;
        }
    }
}

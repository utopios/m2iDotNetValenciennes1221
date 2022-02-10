using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionAnnuaireAdoNet.Classes
{
    internal class IHM
    {
       
        public static void Start()
        {
            string choix;
            do
            {
                Console.Clear();
                choix = Menu();
                switch (choix)
                {
                    case "1":
                        ActionAjouterUtilisateur();
                        break;
                    case "2":
                        ActionSupprimerUtilisateurId();
                        break;
                    case "3":
                        ActionRechercherUtilisateurTelephone();
                        break;
                    case "4":
                        ActionModifierUtilisateur();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                }
                WaitUser();
            } while (choix != "0");
        }
        private static void ActionAjouterUtilisateur()
        {
            Contact contact = new Contact();
            Console.Write("Merci de saisir le nom : ");
            contact.LastName = Console.ReadLine();
            Console.Write("Merci de saisir le prénom : ");
            contact.FirstName = Console.ReadLine();
            //Console.Write("Merci de saisir l'email : ");
            //contact.Email = Console.ReadLine();
            Console.Write("Merci de saisir le téléphone : ");
            contact.Phone = Console.ReadLine();
            if(contact.Save())
            {
                Console.WriteLine("Le contact a bien été ajouté");
            }
            else
            {
                Console.WriteLine("Erreur d'ajout");
            }
            
        }
        private static void ActionSupprimerUtilisateurId()
        {
            Contact contact = SearchContact();
            if(contact !=null && contact.Delete())
            {
                Console.WriteLine("Contact supprimé");
            }
            
        }
        private static void ActionRechercherUtilisateurTelephone()
        {
            Contact contact = SearchContact();
            if (contact != null)
            {
                Console.WriteLine(contact);
            }
        }
        private static void ActionModifierUtilisateur()
        {
            Contact contact = SearchContact();
            if (contact != null)
            {
                Console.Write("Merci de saisir le nouveau nom : ");
                contact.LastName = Console.ReadLine();
                Console.Write("Merci de saisir le nouveau prénom : ");
                contact.FirstName = Console.ReadLine();
                //Console.Write("Merci de saisir le nouveau email : ");
                //contact.Email = Console.ReadLine();
                Console.Write("Merci de saisir le nouveau téléphone : ");
                contact.Phone = Console.ReadLine();
                if (contact.Update())
                {
                    Console.WriteLine("contact modifié");
                }
                else
                {
                    Console.WriteLine("Erreur modification contact");
                }
            }
            
        }
        private static string Menu()
        {
            Console.WriteLine("\n--------------- BDD Utilisateurs -------------\n");
            Console.WriteLine("1- Ajouter un utilisateur");
            Console.WriteLine("2- Supprimer un utilisateur");
            Console.WriteLine("3- Rechercher un utilisateur par son téléphone");
            Console.WriteLine("4- Modifier un utilisateur avec son id");
            Console.WriteLine("\n0---Quitter\n");
            Console.Write("Faites votre choix : ");
            return Console.ReadLine();
        }
        private static void WaitUser()
        {
            Console.WriteLine("Veuillez presser Enter pour retourner au menu principal");
            Console.ReadLine();
            Console.Clear();
        }

        private static Contact SearchContact()
        {
            Console.Write("Merci de saisir letéléphone : ");
            string telephone = Console.ReadLine();
            Contact contact = Contact.SearchByPhone(telephone);
            if(contact == null)
            {
                Console.WriteLine("Aucun contact avec ce numéro");
            }
            return contact;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpLesExceptions.Classes
{
    internal class IHM
    {

        public static void Start()
        {
            string choix;
            do
            {
                Console.Clear();
                Console.WriteLine("\n--------------- CONTACT REGEX ---------------\n");
                DisplayPersons();
                choix = Menu();
                switch (choix)
                {
                    case "1":
                        Console.Clear();
                        ActionAjouterUtilisateur();
                        break;
                    case "2":
                        Console.Clear();
                        ActionSupprimerUtilisateur();
                        break;
                    case "3":
                        Console.Clear();
                        ActionRechercherUtilisateur();
                        break;
                    case "4":
                        Console.Clear();
                        ActionModifierUtilisateur();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                }
                WaitUser();
            } while (choix != "0");
        }

        private static string Menu()
        {
            Console.WriteLine("\n------------------- MENU --------------------\n");
            Console.WriteLine("1- Ajouter un utilisateur");
            Console.WriteLine("2- Supprimer un utilisateur");
            Console.WriteLine("3- Rechercher un utilisateur");
            Console.WriteLine("4- Modifier un utilisateur");
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

        private static void UserForm(Contact c)
        {
            bool valid = false;
            while (!valid)
                try
                {
                    Console.Write(c.Id > 0 ? "\nMerci de saisir le nouveau nom : " : "\nMerci de saisir le nom : ");
                    c.LastName = Console.ReadLine();
                    valid = true;
                }
                catch (FormatException ex)
                {
                    OnRed(ex.Message);
                }
            valid = false;

            while (!valid)
                try
                {
                    Console.Write(c.Id > 0 ? "Merci de saisir le nouveau prénom : " : "Merci de saisir le prénom : ");
                    c.FirstName = Console.ReadLine();
                    valid = true;
                }
                catch (FormatException ex)
                {
                    OnRed(ex.Message);
                }

            valid = false;

            while (!valid)
                try
                {
                    Console.Write(c.Id > 0 ? "Merci de saisir le nouvel email : " : "Merci de saisir l'email : ");
                    c.Email = Console.ReadLine();
                    valid = true;
                }
                catch (FormatException ex)
                {
                    OnRed(ex.Message);
                }

            valid = false;

            while (!valid)
                try
                {
                    Console.Write(c.Id > 0 ? "Merci de saisir le nouveau téléphone : " : "Merci de saisir le téléphone : ");
                    c.Phone = Console.ReadLine();
                    valid = true;
                }
                catch (FormatException ex)
                {
                    OnRed(ex.Message);
                }

            valid = false;

            while (!valid)
                try
                {
                    Console.Write(c.Id > 0 ? "Merci de saisir l'âge : " : "Merci de saisir l'âge : ");
                    c.Age = Convert.ToInt32(Console.ReadLine());
                    valid = true;
                }
                catch (FormatException ex)
                {
                    OnRed(ex.Message);
                }
        }

        private static void DisplayPersons()
        {
            List<Contact> list = Contact.GetContacts();
            if (list != null)
                foreach (Contact contact in list)
                    OnCyan(contact.ToString());
            else
                OnRed("Aucun contact dans la base de donné");
        }

        private static Contact SearchContact()
        {
            Console.WriteLine("         --- Rechercher un Contact ---");
            string telephone = "";
            Contact contact = new();
            while (!Tools.IsPhone(telephone))
            {
                try
                {
                    Console.Write("\nMerci de saisir le téléphone : ");
                    contact.Phone = Console.ReadLine();
                    telephone = Tools.FormatPhone(contact.Phone);
                    contact = Contact.SearchByPhone(telephone);
                }
                catch (FormatException ex)
                {
                    OnRed(ex.Message);
                }
            }

            if (contact == null)
                OnRed("Aucun contact avec ce numéro");

            return contact;
        }

        private static void ActionAjouterUtilisateur()
        {
            Console.WriteLine("\n--------------- CONTACT REGEX ---------------\n");
            Console.WriteLine("         --- Ajouter un Contact ---");
            Contact contact = new();
            UserForm(contact);
            try
            {
                contact.Save();
                OnGreen("Le contact a bien été ajouté");

            }
            catch (Exception ex)
            {
                OnRed(ex.Message + " Erreur lors de l'ajout du contact");
            }
        }

        private static void ActionSupprimerUtilisateur()
        {
            Contact contact = SearchContact();
            if (contact != null && contact.Delete())
                OnGreen("Contact supprimé");
            else
                OnRed("Erreur lors de la suppression")
        }

        private static void ActionRechercherUtilisateur()
        {
            Console.WriteLine("\n--------------- CONTACT REGEX ---------------\n");
            Contact contact = SearchContact();
            if (contact != null)
                OnCyan(contact.Display());
        }

        private static void ActionModifierUtilisateur()
        {
            Console.WriteLine("\n--------------- CONTACT REGEX ---------------\n");
            Contact contact = SearchContact();

            if (contact != null)
            {
               UserForm(contact);

                try
                {
                    contact.Update();
                    OnGreen("contact modifié");
                }
                catch (Exception ex)
                {
                    OnRed(ex.Message + " Erreur lors de la modification contact");
                }                    
            }
        }

        private static void OnRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnGreen(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void OnCyan(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

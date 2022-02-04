using CorrectionTPSalarie.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionTPHéritageSalarie.Classes
{
    public class IHM
    {
        private Salarie[] salaries;
        private int compteur;
        public IHM(int taille)
        {
            salaries = new Salarie[taille];
            compteur = 0;
        }

        public void Start()
        {
            string choix;
            do
            {
                MenuPrincipal();
                Console.Write("Entrez votre choix : ");
                choix = Console.ReadLine();
                Console.Clear();
                switch (choix)
                {
                    case "1":
                        ActionAjoutEmploye();
                        break;
                    case "2":
                        ActionAfficherSalaireEmployes();
                        break;
                    case "3":
                        ActionRechercheEmployes();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                }
                Continuer();
            } while (choix != "0");
        }

        private void MenuPrincipal()
        {
            Console.WriteLine("1 -- Ajouter un employé");
            Console.WriteLine("2 -- Afficher le salaire des employés");
            Console.WriteLine("3 -- Rechercher un employé");
            Console.WriteLine("0 -- Quitter");
        }

        private void MenuEmploye()
        {
            Console.WriteLine("1 -- Salarié");
            Console.WriteLine("2 -- Commercial");
            Console.WriteLine("0 -- Retour");
        }

        private void ActionAjoutEmploye()
        {
            if (compteur < salaries.Length)
            {
                Salarie salarie;
                MenuEmploye();
                string choix = Console.ReadLine();
                if (choix == "1" || choix == "2")
                {
                    Console.Write("Le nom complet du salarié : ");
                    string nom = Console.ReadLine();
                    Console.Write("Le matricule: ");
                    string matricule = Console.ReadLine();
                    Console.Write("Le service du salarié : ");
                    string service = Console.ReadLine();
                    Console.Write("La catégorie du salarié : ");
                    string categorie = Console.ReadLine();
                    Console.Write("Le salaire fix du salarié : ");
                    decimal salaire = Convert.ToDecimal(Console.ReadLine());
                    if (choix == "1")
                    {
                        salarie = new Salarie(matricule, categorie, service, nom, salaire);
                    }
                    else
                    {
                        Console.Write("Le chiffre d'affaire : ");
                        decimal chiffreAffaire = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("La commission : ");
                        decimal commission = Convert.ToDecimal(Console.ReadLine());
                        salarie = new Commercial(matricule, categorie, service, nom, salaire, commission, chiffreAffaire);
                    }
                    salaries[compteur++] = salarie;
                }
            }
            else
            {
                Console.WriteLine("L'entreprise ne peut plus avoir de salariés");
            }      
        }

        private void ActionAfficherSalaireEmployes()
        {
            for(int i = 0; i < compteur; i++)
            {
                //Console.WriteLine(salaries[i]);
                salaries[i].CalculerSalaire();
            }
        }

        private void ActionRechercheEmployes()
        {

        }

        private void Continuer()
        {
            Console.Write("Une touche pour continuer ....");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

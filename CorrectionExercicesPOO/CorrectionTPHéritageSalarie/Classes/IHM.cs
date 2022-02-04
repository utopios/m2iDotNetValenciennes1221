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
            Console.WriteLine("1 -- Salairé");
            Console.WriteLine("2 -- Commercial");
            Console.WriteLine("0 -- Retour");
        }

        private void ActionAjoutEmploye()
        {

        }

        private void ActionAfficherSalaireEmployes()
        {

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

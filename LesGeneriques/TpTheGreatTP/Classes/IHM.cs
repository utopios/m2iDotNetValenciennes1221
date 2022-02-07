using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpTheGreatTP.Classes
{
    internal class IHM
    {
        private Tirage tirage;

        public IHM()
        {
            tirage = new Tirage();
        }
        public void Start()
        {
            bool confirm = false;
            do
            {
                MainMenu();
                string choix = Choice();
                switch (choix)
                {
                    case "1":
                        Console.Clear();
                        PullAction();
                        break;
                    case "2":
                        Console.Clear();
                        PulledListAction();
                        break;
                    case "3":
                        Console.Clear();
                        ToPullListAction();
                        break;
                    case "0":
                        confirm = true;
                        //Environment.Exit(0);
                        break;
                    default:
                        break;
                }


            } while (!confirm);

        }
        private void MainMenu()
        {
            Console.WriteLine("--------------- Grande Ordinatrice ---------------\n");
            Console.WriteLine("\t1-- Effectuer un tirage au sort");
            Console.WriteLine("\t2-- Voir la liste des personnes deja tirées");
            Console.WriteLine("\t3-- Voir la liste des personnes restantes");
            Console.WriteLine("\t0-- Quitter\n");
        }

        private string Choice()
        {
            Console.Write("Veuillez entrer votre choix : ");
            return Console.ReadLine();
        }

        private void PullAction()
        {
            string confirm;
            string prenom;

            do
            {
                prenom = tirage.Pull();
                Console.WriteLine(prenom);
                Console.Write("Acceptez-vous ce choix ? :");
                confirm = Console.ReadLine().ToUpper();
            } while (confirm != "OUI");
            if (confirm =="OUI")
            {
                tirage.AddPulled(prenom);
                Console.WriteLine("Le tirage a été sauvegardé...");
            }
        }

        private void PulledListAction()
        {

        }

        private void ToPullListAction()
        {

        }
    }
}

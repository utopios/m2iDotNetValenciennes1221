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
                DisplayPulled(prenom);
                //Console.WriteLine(prenom);
                Console.Write("Acceptez-vous ce choix ? :");
                confirm = Console.ReadLine().ToUpper();
            } while (confirm != "OUI");
            if (confirm =="OUI")
            {
                tirage.AddPulled(prenom);
                Console.WriteLine("Le tirage a été sauvegardé...");
            }
        }

        public void DisplayPulled(string prenom)
        {
            string chaine = "";
            foreach (char c in prenom)
                chaine += "*";

            Console.WriteLine("---------------- Effectuer un tirage ----------------");
            Console.WriteLine(" Oh grande ordinatrice \n\t\t\tQui va corriger au tableau ? \n");
            Console.WriteLine("Appuyer sur Enter pour effectuer les tirage au sort");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Le/La chanceux/euse d'aujourd'hui est : "+ prenom);
            Console.WriteLine($"\n\t\t******************{chaine}");
            Console.WriteLine($"\t\t* * * BRAVO {prenom.ToUpper()} * * *");
            Console.WriteLine($"\t\t******************{chaine}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private void PulledListAction()
        {
            string chaine = "";

            ColorRed("---------------- Afficher les personnes déjà tirées ----------------\n");

            foreach (string nom in tirage.DrawedList)
            {
                Console.WriteLine(chaine+nom);
                chaine += "  ";
            }
            Console.WriteLine("\nAppuyez sur Enter pour retourner au menu principal...");
            Console.ReadLine();
            Console.Clear();

        }

        private void ToPullListAction()
        {
            string chaine = "";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---------------- Afficher les personnes à venir ----------------\n");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (string nom in tirage.OriginList)
            {
                if (!tirage.DrawedList.Contains(nom))
                {
                    Console.WriteLine(chaine + nom);
                    chaine += "  ";
                }                
            }
            Console.WriteLine("\nAppuyez sur Enter pour retourner au menu principal...");
            Console.ReadLine();
            Console.Clear();
        }

        public void ColorRed(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

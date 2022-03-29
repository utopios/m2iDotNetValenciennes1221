using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionPendu.Classes
{
    public class IHM
    {
        private Pendu pendu;
        private GenerateurDeMot generateurDeMot;
        //private GenerateurSql generateurDeMot;

        public IHM()
        {
            //generateurDeMot = new GenerateurSql();
            generateurDeMot = new GenerateurDeMot();
        }
        public void Start()
        {
            pendu = new Pendu();
            pendu.GenererMasque(generateurDeMot);
            do
            {
                Affichage();
                Console.Write("Veuillez saisir une lettre : ");
                char c = Convert.ToChar(Console.ReadLine());
                if(pendu.TestChar(c))
                {
                    Console.WriteLine("Bravo vous avez trouvé un caractère dans le mot");
                }
                else
                {
                    Console.WriteLine($"Le caractère n'existe pas, il vous reste : {pendu.NbEssai}");
                }
            } while (pendu.NbEssai > 0 && !pendu.TestWin());

            if(pendu.NbEssai > 0)
            {
                Console.WriteLine("Bravo vous avez gagné !!!!!");
                Console.Read();
            }
            else
            {
                Console.WriteLine("Désolé, vous avez perdu :(");
                Console.Read();
            }
        }

        private void Affichage()
        {
            Console.WriteLine("---- Le jeu du Pendu ------");
            Console.WriteLine($"Le mot à trouver est : {pendu.Masque}");
        }
    }
}

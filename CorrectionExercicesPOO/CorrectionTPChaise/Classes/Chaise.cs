using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionTPChaise.Classes
{
    public class Chaise
    {
        private int nbPieds;
        private string couleur;
        private string materiaux;
        private static int compteur = 0;
        public int NbPieds
        {
            get => nbPieds; set
            {
                if(value >= 2)
                    nbPieds = value;
                else
                    //Normalement, on utilisera une exception (A voir dans les prochains modules).
                    Console.WriteLine("Erreur de nombre de pieds");
            }
        }
        public string Couleur { get => couleur; set => couleur = value; }
        public string Materiaux { get => materiaux; set => materiaux = value; }

        public static int Compteur { get => compteur;}

        public Chaise()
        {
            compteur++;
        }
        public Chaise(int nbPieds, string couleur, string materiaux) : this()
        {
            NbPieds = nbPieds;
            Couleur = couleur;
            Materiaux = materiaux;
        }


    }
}

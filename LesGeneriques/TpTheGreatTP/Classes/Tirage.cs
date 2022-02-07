using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpTheGreatTP.Classes
{
    internal class Tirage
    {
        private static List<string> originList;
        private static List<string> drawedList;

        public Tirage()
        {
            Init();
        }

        public void Init()
        {
            originList = new List<string>() { "Guillaume", "Romaric", "Michel", "Yoann", "Christophe", "Jonathan", "Abdelkader", "Aboubacar", "Al-Douri", "Samia", "Simon-Pierre", "Sofiane", "Yannick", "Nisar", "Meziane" };
            drawedList = new List<string>();
        }

        public string Pull()
        {
            string prenom;
            if (originList.Count > 0)
            {
                Random rnd = new Random();

                do
                {
                    prenom = originList[rnd.Next(originList.Count)];
                } while (drawedList.Find(x => x == prenom) == prenom);
            }
            else
            {
                prenom= "Veuillez remplir la liste";
            }

            return prenom;
        }

        public void AddPulled(string prenom)
        {
            drawedList.Add(prenom);

            if (originList.Count == drawedList.Count)
            {
                drawedList.Clear();
            }
        }
    }
}

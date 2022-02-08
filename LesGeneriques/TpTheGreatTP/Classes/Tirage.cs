using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpTheGreatTP.Classes
{
    class Tirage
    {
        private List<string> originList;
        private List<string> drawedList;

        public List<string> OriginList { get => originList; set => originList = value; }
        public List<string> DrawedList { get => drawedList; set => drawedList = value; }

        public Tirage()
        {
            Init();
        }

        public void Init()
        {
            OriginList = new List<string>() { "Guillaume", "Romaric", "Michel", "Yoann", "Christophe", "Jonathan", "Abdelkader", "Aboubacar", "Al-Douri", "Samia", "Simon-Pierre", "Sofiane", "Yannick", "Nisar", "Meziane" };
            DrawedList = new List<string>();
        }

        public string Pull()
        {
            string prenom;
            if (OriginList.Count > 0)
            {
                Random rnd = new Random();

                do
                {
                    prenom = OriginList[rnd.Next(OriginList.Count)];
                } while (DrawedList.Find(x => x == prenom) == prenom);
            }
            else
            {
                prenom= "Veuillez remplir la liste";
            }

            return prenom;
        }

        public void AddPulled(string prenom)
        {
            DrawedList.Add(prenom);

            if (OriginList.Count == DrawedList.Count)
            {
                DrawedList.Clear();
            }
        }
    }
}

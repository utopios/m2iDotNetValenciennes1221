using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpTheGreatTP.Classes
{
    class Tirage
    {
        private string PathFileOrigin = "listeOrigine.txt";
        private string PathFile = "liste.txt";
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
            try
            {
                StreamReader reader = new StreamReader(PathFileOrigin);
                string ContentOrigine = reader.ReadToEnd();
                OriginList = ContentOrigine != "" ? JsonConvert.DeserializeObject<List<string>>(ContentOrigine) : new List<string>();
                reader.Close();
                reader = new StreamReader(PathFile);
                string Content = reader.ReadToEnd();
                DrawedList = Content != "" ? JsonConvert.DeserializeObject<List<string>>(Content) : new List<string>();
                reader.Close();

            }
            catch (Exception)
            {
                Save();
                SaveOrigin();                
            }
        }

        public void Save()
        {
            StreamWriter writer = new StreamWriter(PathFile);
            if (DrawedList.Count == 0)
            {
                DrawedList = new List<string>();
            }
            writer.WriteLine(JsonConvert.SerializeObject(DrawedList));
            writer.Close();
        }

        public void SaveOrigin()
        {
            StreamWriter writer = new StreamWriter(PathFileOrigin);            
            writer.WriteLine(JsonConvert.SerializeObject(OriginList));
            writer.Close();
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
            Save();

            if (OriginList.Count == DrawedList.Count)
            {
                DrawedList.Clear();
                Save();
            }
        }
    }
}

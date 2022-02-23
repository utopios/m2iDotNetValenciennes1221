using System.Collections.Generic;

namespace correctionForum.Models
{
    public class Forum
    {
        private int id;
        private string name;
        private Moderateur moderateur;
        private List<Nouvelle> Nouvelles;
        private List<Abonne> Abonnes;

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public Moderateur Moderateur
        {
            get => moderateur;
            set => moderateur = value;
        }

        public List<Nouvelle> Nouvelles1
        {
            get => Nouvelles;
            set => Nouvelles = value;
        }

        public List<Abonne> Abonnes1
        {
            get => Abonnes;
            set => Abonnes = value;
        }
    }
}
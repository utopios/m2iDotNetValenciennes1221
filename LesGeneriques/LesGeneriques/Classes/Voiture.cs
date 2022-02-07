using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesGeneriques.Classes
{
    class Voiture
    {
        private string model;
        private string couleur;
        private int reservoir;
        private int autonomie;

        public Voiture(string model, string couleur, int reservoir, int autonomie)
        {
            this.model = model;
            this.couleur = couleur;
            this.reservoir = reservoir;
            this.autonomie = autonomie;
        }

        public string Model { get => model; set => model = value; }
        public string Couleur { get => couleur; set => couleur = value; }
        public int Reservoir { get => reservoir; set => reservoir = value; }
        public int Autonomie { get => autonomie; set => autonomie = value; }

        public override string ToString()
        {
            return $"Model : { model} - Couleur : {Couleur}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage.Classes
{
    internal class Chien : Mammifere
    {
        private string nomChien;
        private string typeChien;

        public Chien(string NomChien, string TypeChien) : base(NomChien, TypeChien)
        {
            this.nomChien = NomChien;
            this.typeChien = TypeChien;
        }

        public string NomChien { get => nomChien; set => nomChien = value; }
        public string TypeChien { get => typeChien; set => typeChien = value; }

        public new void Alimentation()
        {
            base.Alimentation();
            Console.WriteLine("Je mange des croquettes pour chien!");
        }
        public void Aboyer()
        {
            Console.WriteLine("Wouaf! Wouaf !");
        }
    }
}

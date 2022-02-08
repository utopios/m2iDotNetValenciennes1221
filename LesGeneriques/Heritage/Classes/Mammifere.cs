 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage.Classes
{
    internal class Mammifere :Animal
    {
        private string nomMammifere;
        private string typeMammifere;


        public string TypeMammifere { get => typeMammifere; set => typeMammifere = value; }
        public string NomMammifere { get => nomMammifere; set => nomMammifere = value; }

        public Mammifere(string NomMamifere, string TypeMamifere) : base(NomMamifere, TypeMamifere)
        {
            this.nomMammifere = NomMamifere;
            this.typeMammifere = TypeMamifere;
        }
        public override void Reproduction()
        {
            Console.WriteLine("Je me reproduit par gestation");
        }

        public override void Oxigenation()
        {
            Console.WriteLine("Inspiration.... Expiration... J'ai des poumons");
        }
    }
}

using CorrectionTPSalarie.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionTPHéritageSalarie.Classes
{
    public class Commercial : Salarie
    {
        private decimal commission;
        private decimal chiffreAffaire;

        public Commercial() : base()
        {
        }

        public Commercial(string matricule, string categorie, string service, string nom, decimal salaire, decimal commission, decimal chiffreAffaire) : base(matricule, categorie, service,nom, salaire)
        {
            ChiffreAffaire = chiffreAffaire;
            Commission = commission;
        }

        public decimal Commission { get => commission; set => commission = value; }
        public decimal ChiffreAffaire { get => chiffreAffaire; set => chiffreAffaire = value; }

        public override void CalculerSalaire()
        {
            decimal salaireTotal = Salaire + ChiffreAffaire * Commission / 100;
            Console.WriteLine($"Le salaire total est : {salaireTotal} euros");
        }

        public override string ToString()
        {
            return base.ToString()  + $", Chiffre d'affaire {ChiffreAffaire}, Commission {Commission}";
        }
    }
}

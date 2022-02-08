using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCompteBancaireHeritage.Classes
{
    internal class Operation
    {
        private int id;
        private DateTime date;
        private double montant;
        private static int counter = 0;

        public Operation()
        {
            Id = ++counter;
            Date = DateTime.Now;
        }

        public Operation(double montant) : this()
        {            
            this.Montant = montant;
        }

        public int Id { get => id; set => id = value; }
        
        public static int Counter { get => counter; }
        public double Montant { get => montant; set => montant = value; }
        public DateTime Date { get => date; set => date = value; }

        public override string ToString()
        {
            return $"Id: {Id} - Date : {Date}, montant : {Montant}";
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpCalculatriceDelegate.Classes
{
    internal class Calculatrice
    {

        // Func pour les délégué avec un retour :
        // Le premier double est le type de retour, et les deux autres sont les params
        public double Calcule(double a, double b, Func<double, double, double> methode)
        {
            return methode(a, b);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesDelegues.Classes
{
    internal class Calculatrice
    {

        //// A l'origine des délégates => Il Fallait des déclarer au préalable
        //public delegate double DelegateMethodeCalcul(double a , double b);


        //// Création d'une fonction utilisant ce delegué
        //public void Calcule(double a, double b, DelegateMethodeCalcul methode )
        //{
        //    Console.WriteLine($"Le résultat du calcul est de : {methode(a, b)}");
        //}

        // Il existe depuis c#7 deux délégués génériques pour définir les délégués:
        // Action<> => Délégué sans retour
        // Func<> => Délégué faisant un retour

        // Func pour les délégué avec un retour :
        // Le premier double est le type de retour, et les deux autres sont les params
        public void Calcule(double a, double b, Func<double, double, double> methode)
        {
            Console.WriteLine($"Le résultat du calcul est de : {methode(a, b)}");
        }


        //// A l'origine des délégates => Il Fallait des déclarer au préalable
        //public delegate void DelegateVoid(string s);

        //// Création d'une fonction utilisant ce delegué
        //public void HowToDisplay(string message, DelegateVoid methode)
        //{
        //    methode(message);
        //}

        // Création d'une fonction utilisant ce delegué
        public void HowToDisplay(string message, Action<string> methode)
        {
            methode(message);
        }
    }
}

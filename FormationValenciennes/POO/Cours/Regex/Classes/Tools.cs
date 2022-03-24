using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ExpressionsReguliere.Classes
{
    internal class Tools
    {

        /*
         *  Pattern REGEX
         *  ^ = Commence
         *  $ = Termine
         *  \d = nombre
         *  \w = Lettre , Nombre, _undercore
         *  \s = White-space(tabs, espacement...etc)
         *  \D = Tout sauf les \d
         *  \W = Tout sauf les \w
         *  \S = Tout sauf les \s
         *  [a-z] = Autoriser les lettres minuscule
         *  [a-zA-Z] = Autoriser les lettres minuscule et majuscule
         *  | = OU
         *  * = 0 ou plus
         *  + = au moins une fois
         *  ? = 0 ou 1
         *  {1} = répétition ( repete 1 fois les instructions )
         *  {2,4} = répétition ( repete entre 2 et 4 fois les instructions )
         */

        public static bool IsName(string name)
        {            
            string pattern = @"^[A-Z]{1}[a-zA-Z\séèë\-_]*$";
            return Regex.IsMatch(name, pattern);
        }

        // Créer Une méthode pour vérifier une adresse email:

        public static bool IsEmail(string name)
        { 
            string pattern = @"^([a-zA-Z0-9\.\-_]+)@([a-zA-Z0-9\.\-_]+)\.([a-zA-Z]{2,11})$";
            return Regex.IsMatch(name, pattern);
        }
    }
}

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
        public static bool IsEmail(string email)
        { 
            string pattern = @"^([a-zA-Z0-9\.\-_]+)@([a-zA-Z0-9\-_]+)(\.)?([a-zA-Z0-9\-_]+)?(\.){1}([a-zA-Z]{2,11})$";
            return Regex.IsMatch(email, pattern);
        }

        // Créer une méthode pour vérifier le téléphone
        public static bool IsPhone(string phone)
        {
            // +33 6 59 78 65 32 => Le Bon Format
            // 33 6 59 78 65 32
            // 03 20 45 69 87 => Le Bon Format
            // 06-23-45-69-87
            // 06.23.45.69.87
            // 0723456987
            string pattern = @"^([0|\+33|33]+)(\.|\-|\s)?([1-9]{1})((\.|\-|\s)?[0-9]{2}){4}$";
            return Regex.IsMatch(phone, pattern);
        }

        // Créer une méthode pour vérifier l'age
        public static bool IsNumeric(string chaine)
        {
            string pattern = @"^([0-9]+)(\,)?([0-9]*)$";
            return Regex.IsMatch(chaine, pattern);
        }

        public static bool IsAlphabetic(string chaine)
        {
            string pattern = @"^[A-Z]{1}[a-zA-Z\séèë\-_\s]*$";
            return Regex.IsMatch(chaine, pattern);
        }

        public static string ClearMultipleSpace(string chaine)
        {
            string pattern = @"\s+";
            string CleanedString = Regex.Replace(chaine, pattern, " ");
            return CleanedString;
        }

    }
}

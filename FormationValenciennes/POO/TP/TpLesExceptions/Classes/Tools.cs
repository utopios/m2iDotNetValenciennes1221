﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TpLesExceptions.Classes
{
    internal class Tools
    {
        public static bool IsName(string name)
        {            
            string pattern = @"^[A-Z]{1}[a-zA-Z\séèë\-_]*$";
            return Regex.IsMatch(name, pattern);
        }
      
        public static bool IsEmail(string email)
        { 
            string pattern = @"^([a-zA-Z0-9\.\-_]+)@([a-zA-Z0-9\-_]+)(\.)?([a-zA-Z0-9\-_]+)?(\.){1}([a-zA-Z]{2,11})$";
            return Regex.IsMatch(email, pattern);
        }

        public static bool IsPhone(string phone)
        {           
            string pattern = @"^([0|\+33|33]+)(\.|\-|\s)?([1-9]{1})((\.|\-|\s)[0-9]{2}){4}$";
            return Regex.IsMatch(phone, pattern);
        }
       
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

        public static string FormatPhone(string phone)
        {
            string pattern = @"[\.\-]+";
            string FormatedString = Regex.Replace(phone, pattern, " ");

            pattern = @"^(0|33)";
            FormatedString = Regex.Replace(FormatedString, pattern, "+33 ");

            return ClearMultipleSpace(FormatedString);
        }
    }
}

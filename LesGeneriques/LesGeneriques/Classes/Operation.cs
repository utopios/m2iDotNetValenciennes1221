using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesGeneriques.Classes
{
    class Operation<T> // Création d'une classe Générique
    {
        public string EstEquivalent(T a , T b)
        {
            if (a.Equals(b))          
                return "C'est équivalent!";            
            else
                return "Ce n'est pas équivalent";
        }
    }
}
